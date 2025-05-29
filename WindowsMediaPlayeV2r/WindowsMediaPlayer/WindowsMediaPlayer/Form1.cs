using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.Drawing.Drawing2D;
using System.IO;

namespace WindowsMediaPlayer
{
    public partial class Form1 : Form
    {


List<string> listaCanciones = new List<string>();
    int indiceActual = 0;
    WaveOutEvent outputDevice;
    AudioFileReader audioFile;
    Random rand = new Random();
    bool estaReproduciendo = false;
        private string tipoVisualizacion = "Ecualizador clásico";
        private int[] alturasBarras; 
        private int numBarras = 20;
        enum EstadoReproductor { Reproduciendo, Pausado, Detenido }
        private EstadoReproductor estado = EstadoReproductor.Detenido;
        private float t = 0; 





        private void CargarCanciones()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "Archivos de audio|*.mp3;*.wav";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listaCanciones = openFileDialog1.FileNames.ToList();
                indiceActual = 0;
                ReproducirCancionActual();
            }
        }

        private void ReproducirCancionActual()
        {
            if (outputDevice != null)
            {
                outputDevice.Stop();
                outputDevice.Dispose();
                audioFile.Dispose();
            }

            audioFile = new AudioFileReader(listaCanciones[indiceActual]);
            outputDevice = new WaveOutEvent();
            outputDevice.Init(audioFile);
            outputDevice.Play();

            estaReproduciendo = true;

            // Actualizar el título de la canción con el nombre del archivo (sin la ruta completa)
            lblTitulo.Text = Path.GetFileName(listaCanciones[indiceActual]);
            lblTitulo.Left = this.Width;

            audioFile.Volume = trackVol.Value / 100f;

            timer1.Start();         // ecualizador
            timerTitulo.Start();    // marquesina
            timerProgreso.Start();  // progreso
        }




        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!estaReproduciendo && listaCanciones.Count > 0)
                ReproducirCancionActual();
            else
                outputDevice?.Play();
            estado = EstadoReproductor.Reproduciendo;

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (outputDevice != null && estado == EstadoReproductor.Reproduciendo)
            {
                outputDevice.Pause();
                estaReproduciendo = false;
                estado = EstadoReproductor.Pausado;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (outputDevice != null)
            {
                outputDevice.Stop();
                outputDevice.Dispose();
                outputDevice = null;
            }

            if (audioFile != null)
            {
                audioFile.Dispose();
                audioFile = null;
            }

            estaReproduciendo = false;
            estado = EstadoReproductor.Detenido;

            for (int i = 0; i < numBarras; i++)
                alturasBarras[i] = 0;

            trackProgress.Value = 0;

            timer1.Stop();
            timerTitulo.Stop();
            timerProgreso.Stop();

            panelViz.Invalidate();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (listaCanciones.Count == 0) return;
            indiceActual = (indiceActual + 1) % listaCanciones.Count;
            ReproducirCancionActual();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (listaCanciones.Count == 0) return;
            indiceActual = (indiceActual - 1 + listaCanciones.Count) % listaCanciones.Count;
            ReproducirCancionActual();
        }

        private void trackVol_Scroll(object sender, EventArgs e)
        {
            if (audioFile != null)
                audioFile.Volume = trackVol.Value / 100f;
        }

        private void trackProgress_Scroll(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            t += 0.05f;
            if (estado == EstadoReproductor.Reproduciendo)
            {
                for (int i = 0; i < numBarras; i++)
                {
                    if (tipoVisualizacion == "Frecuencias simuladas")
                    {
                        alturasBarras[i] = (int)((Math.Sin(i + DateTime.Now.Millisecond / 100.0) + 1) * (panelViz.Height / 2));
                    }
                    else
                    {
                        alturasBarras[i] = rand.Next(panelViz.Height / 4, panelViz.Height);
                    }
                }
            }
            panelViz.Invalidate();

        }

        private void timerTitulo_Tick(object sender, EventArgs e)
        {
            lblTitulo.Left -= 2;
            if (lblTitulo.Right < 0)
                lblTitulo.Left = this.Width;
        }

        private void timerProgreso_Tick(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                trackProgress.Maximum = (int)audioFile.TotalTime.TotalSeconds;
                trackProgress.Value = Math.Min((int)audioFile.CurrentTime.TotalSeconds, trackProgress.Maximum);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void trackProgress_MouseDown(object sender, MouseEventArgs e)
        {
            int seconds = (int)((double)e.X / trackProgress.Width * trackProgress.Maximum);
            if (audioFile != null)
                audioFile.CurrentTime = TimeSpan.FromSeconds(seconds);
        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }

        private void panelViz_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.Black);

            if (tipoVisualizacion == "Ecualizador clásico" || tipoVisualizacion == "Frecuencias simuladas" || tipoVisualizacion == "Gradientes dinámicos")
            {
                int anchoBarra = panelViz.Width / numBarras;

                for (int i = 0; i < numBarras; i++)
                {
                    int altura = alturasBarras[i];
                    int x = i * anchoBarra;
                    int y = panelViz.Height - altura;

                    
                    Color color = Color.Red; 


                    if (tipoVisualizacion == "Ecualizador clásico")
                    {
                        color = Color.Lime;
                    }
                    else if (tipoVisualizacion == "Frecuencias simuladas")
                    {
                        color = Color.Cyan;
                    }
                    else if (tipoVisualizacion == "Gradientes dinámicos")
                    {
                        int r = (int)(127 + 127 * Math.Sin(i + DateTime.Now.Millisecond / 100.0));
                        int gC = (int)(127 + 127 * Math.Sin(i + 2 + DateTime.Now.Millisecond / 110.0));
                        int b = (int)(127 + 127 * Math.Sin(i + 4 + DateTime.Now.Millisecond / 120.0));
                        color = Color.FromArgb(r, gC, b);
                    }
                    else { 
                    
                    }


                        Brush brush = new SolidBrush(color);
                    g.FillRectangle(brush, x, y, anchoBarra - 2, altura);
                }
            }
            else if (tipoVisualizacion == "Lissajous")
            {
                int cx = panelViz.Width / 2;
                int cy = panelViz.Height / 2;

                Pen pen = new Pen(Color.Lime, 3);
                int puntos = panelViz.Width;

                PointF[] forma = new PointF[puntos];
                Random rand = new Random();

                for (int x = 0; x < puntos; x++)
                {
                    float frecuencia = 0.01f;             // Menor frecuencia = ondas más anchas
                    float amplitud = panelViz.Height / 3; // Mayor amplitud = ondas más altas

                    float y = cy + (float)Math.Sin((x * frecuencia) + t * 2) * amplitud;

                    float ruido = (float)(rand.NextDouble() - 0.5) * 30f; 

                    forma[x] = new PointF(x, y + ruido);
                }

                g.DrawLines(pen, forma);



            }
            else if (tipoVisualizacion == "Círculos pulsantes")
            {
                int cx = panelViz.Width / 2;
                int cy = panelViz.Height / 2;
                float radioBase = 60 + 20 * (float)Math.Sin(t * 2);
                int puntos = 100;

                PointF[] puntosCirculo = new PointF[puntos];
                float deformacion = 10 + 10 * (float)Math.Sin(t * 3);

                for (int i = 0; i < puntos; i++)
                {
                    float angulo = (float)(i * 2 * Math.PI / puntos);
                    float r = radioBase + (float)Math.Sin(angulo * 5 + t * 5) * deformacion;
                    float x = cx + r * (float)Math.Cos(angulo);
                    float y = cy + r * (float)Math.Sin(angulo);
                    puntosCirculo[i] = new PointF(x, y);
                }

                int rColor = (int)(127 + 127 * Math.Sin(t * 1.3));
                int gColor = (int)(127 + 127 * Math.Sin(t * 1.7));
                int bColor = (int)(127 + 127 * Math.Sin(t * 2.1));
                Color color = Color.FromArgb(rColor, gColor, bColor);

                g.FillPolygon(new SolidBrush(color), puntosCirculo);
            }
            else if (tipoVisualizacion == "Espiral")
            {
                int cx = panelViz.Width / 2;
                int cy = panelViz.Height / 2;

                int figuras = 180;
                double escala = 4 + 2 * Math.Sin(t * 0.6);

                for (int i = 0; i < figuras; i++)
                {
                    double angulo = i * 0.25 + t * 2;
                    double radio = escala * i;

                    float x = (float)(cx + radio * Math.Cos(angulo));
                    float y = (float)(cy + radio * Math.Sin(angulo));

                    float size = 8 + 6 * (float)Math.Abs(Math.Sin(t * 10 + i));

                    int r = (int)(127 + 127 * Math.Sin(i * 0.2 + t * 10));
                    int gC = (int)(127 + 127 * Math.Sin(i * 0.3 + t * 15));
                    int b = (int)(127 + 127 * Math.Sin(i * 0.4 + t * 20));

                    Color color = Color.FromArgb(r, gC, b);
                    Brush brush = new SolidBrush(color);

                    // Alterna entre formas: triángulo, rombo, rectángulo
                    if (i % 3 == 0)
                    {
                        // Triángulo
                        PointF[] tri = new PointF[]
                        {
                new PointF(x, y - size),
                new PointF(x - size, y + size),
                new PointF(x + size, y + size)
                        };
                        g.FillPolygon(brush, tri);
                    }
                    else if (i % 3 == 1)
                    {
                        // Rombo
                        PointF[] rombo = new PointF[]
                        {
                new PointF(x, y - size),
                new PointF(x - size, y),
                new PointF(x, y + size),
                new PointF(x + size, y)
                        };
                        g.FillPolygon(brush, rombo);
                    }
                    else
                    {
                        // Rectángulo rotado
                        float angle = (float)(i * 10 + t * 100);
                        g.TranslateTransform(x, y);
                        g.RotateTransform(angle);
                        g.FillRectangle(brush, -size / 2, -size / 2, size, size);
                        g.ResetTransform();
                    }
                }


            }

        }

        private void btnCargarCanciones_Click(object sender, EventArgs e)
        {
            CargarCanciones();
        }

        private void cmbVisualizaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoVisualizacion = cmbVisualizaciones.SelectedItem.ToString();
            panelViz.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbVisualizaciones.Items.Add("Ecualizador clásico");
            cmbVisualizaciones.Items.Add("Frecuencias simuladas");
            cmbVisualizaciones.Items.Add("Gradientes dinámicos");
            cmbVisualizaciones.Items.Add("Lissajous");
            cmbVisualizaciones.Items.Add("Círculos pulsantes");
            cmbVisualizaciones.Items.Add("Espiral");
            cmbVisualizaciones.SelectedIndex = 0;

            alturasBarras = new int[numBarras];

        }
    }
}
