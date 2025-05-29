using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NAudio.Wave;
using WindowsMediaPlayer.Models;

namespace WindowsMediaPlayer.Services
{
    public class AudioManager : IDisposable
    {
        private List<string> listaCanciones = new List<string>();
        private int indiceActual = 0;
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private bool estaReproduciendo = false;
        private EstadoReproductor estado = EstadoReproductor.Detenido;

        public event EventHandler<string> CancionCambiada;
        public event EventHandler<EstadoReproductor> EstadoCambiado;
        public event EventHandler<TimeSpan> ProgresoActualizado;

        public EstadoReproductor Estado => estado;
        public bool EstaReproduciendo => estaReproduciendo;
        public int TotalCanciones => listaCanciones.Count;
        public string CancionActual => listaCanciones.Count > 0 ? Path.GetFileName(listaCanciones[indiceActual]) : "";
        public TimeSpan TiempoTotal => audioFile?.TotalTime ?? TimeSpan.Zero;
        public TimeSpan TiempoActual => audioFile?.CurrentTime ?? TimeSpan.Zero;

        public bool CargarCanciones()
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Archivos de audio|*.mp3;*.wav";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    listaCanciones = openFileDialog.FileNames.ToList();
                    indiceActual = 0;
                    return true;
                }
            }
            return false;
        }

        public void ReproducirCancionActual()
        {
            if (listaCanciones.Count == 0) return;

            DetenerReproduccion();

            try
            {
                audioFile = new AudioFileReader(listaCanciones[indiceActual]);
                outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);
                outputDevice.Play();

                estaReproduciendo = true;
                estado = EstadoReproductor.Reproduciendo;

                CancionCambiada?.Invoke(this, CancionActual);
                EstadoCambiado?.Invoke(this, estado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al reproducir archivo: {ex.Message}");
            }
        }

        public void Play()
        {
            if (listaCanciones.Count == 0) return;

            if (!estaReproduciendo)
                ReproducirCancionActual();
            else
                outputDevice?.Play();

            estado = EstadoReproductor.Reproduciendo;
            EstadoCambiado?.Invoke(this, estado);
        }

        public void Pause()
        {
            if (outputDevice != null && estado == EstadoReproductor.Reproduciendo)
            {
                outputDevice.Pause();
                estaReproduciendo = false;
                estado = EstadoReproductor.Pausado;
                EstadoCambiado?.Invoke(this, estado);
            }
        }

        public void Stop()
        {
            DetenerReproduccion();
            estado = EstadoReproductor.Detenido;
            EstadoCambiado?.Invoke(this, estado);
        }

        public void SiguienteCancion()
        {
            if (listaCanciones.Count == 0) return;
            indiceActual = (indiceActual + 1) % listaCanciones.Count;
            ReproducirCancionActual();
        }

        public void CancionAnterior()
        {
            if (listaCanciones.Count == 0) return;
            indiceActual = (indiceActual - 1 + listaCanciones.Count) % listaCanciones.Count;
            ReproducirCancionActual();
        }

        public void CambiarVolumen(float volumen)
        {
            if (audioFile != null)
                audioFile.Volume = volumen / 100f;
        }

        public void CambiarPosicion(TimeSpan posicion)
        {
            if (audioFile != null)
                audioFile.CurrentTime = posicion;
        }

        public void ActualizarProgreso()
        {
            ProgresoActualizado?.Invoke(this, TiempoActual);
        }

        private void DetenerReproduccion()
        {
            outputDevice?.Stop();
            outputDevice?.Dispose();
            audioFile?.Dispose();
            outputDevice = null;
            audioFile = null;
            estaReproduciendo = false;
        }

        public void Dispose()
        {
            DetenerReproduccion();
        }
    }
}