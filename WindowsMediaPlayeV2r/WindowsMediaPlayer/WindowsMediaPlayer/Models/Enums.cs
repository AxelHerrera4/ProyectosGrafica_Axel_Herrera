using System;
using System.Collections.Generic;
using System.Drawing;

namespace WindowsMediaPlayer.Models
{
    public enum EstadoReproductor
    {
        Reproduciendo,
        Pausado,
        Detenido
    }

    public enum TipoVisualizacion
    {
        EcualizadorClasico,
        FrecuenciasSimuladas,
        GradientesDinamicos,
        Lissajous,
        CirculosPulsantes,
        Espiral
    }
}