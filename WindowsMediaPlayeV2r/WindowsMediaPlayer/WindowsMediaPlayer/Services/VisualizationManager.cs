using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using WindowsMediaPlayer.Models;

namespace WindowsMediaPlayer.Services
{
    public class VisualizationManager
    {
        private TipoVisualizacion tipoActual = TipoVisualizacion.EcualizadorClasico;
        private int[] alturasBarras;
        private int numBarras = 20;
        private float tiempo = 0;
        private Random random = new Random();

        public TipoVisualizacion TipoActual
        {
            get => tipoActual;
            set => tipoActual = value;
        }

        public VisualizationManager()
        {
            alturasBarras = new int[numBarras];
        }

        public void ActualizarVisualizacion(EstadoReproductor estado, Size panelSize)
        {
            tiempo += 0.05f;

            if (estado == EstadoReproductor.Reproduciendo)
            {
                ActualizarDatos(panelSize);
            }
            else if (estado == EstadoReproductor.Detenido)
            {
                LimpiarDatos();
            }
        }

        private void ActualizarDatos(Size panelSize)
        {
            for (int i = 0; i < numBarras; i++)
            {
                switch (tipoActual)
                {
                    case TipoVisualizacion.FrecuenciasSimuladas:
                        alturasBarras[i] = (int)((Math.Sin(i + DateTime.Now.Millisecond / 100.0) + 1) * (panelSize.Height / 2));
                        break;
                    default:
                        alturasBarras[i] = random.Next(panelSize.Height / 4, panelSize.Height);
                        break;
                }
            }
        }

        private void LimpiarDatos()
        {
            for (int i = 0; i < numBarras; i++)
                alturasBarras[i] = 0;
        }

        public void DibujarVisualizacion(Graphics g, Size panelSize)
        {
            g.Clear(Color.Black);

            switch (tipoActual)
            {
                case TipoVisualizacion.EcualizadorClasico:
                case TipoVisualizacion.FrecuenciasSimuladas:
                case TipoVisualizacion.GradientesDinamicos:
                    DibujarBarras(g, panelSize);
                    break;
                case TipoVisualizacion.Lissajous:
                    DibujarLissajous(g, panelSize);
                    break;
                case TipoVisualizacion.CirculosPulsantes:
                    DibujarCirculosPulsantes(g, panelSize);
                    break;
                case TipoVisualizacion.Espiral:
                    DibujarEspiral(g, panelSize);
                    break;
            }
        }

        private void DibujarBarras(Graphics g, Size panelSize)
        {
            int anchoBarra = panelSize.Width / numBarras;

            for (int i = 0; i < numBarras; i++)
            {
                int altura = alturasBarras[i];
                int x = i * anchoBarra;
                int y = panelSize.Height - altura;

                Color color = ObtenerColorBarra(i);
                using (var brush = new SolidBrush(color))
                {
                    g.FillRectangle(brush, x, y, anchoBarra - 2, altura);
                }
            }
        }

        private Color ObtenerColorBarra(int indice)
        {
            if (tipoActual == TipoVisualizacion.EcualizadorClasico)
            {
                return Color.Lime;
            }
            else if (tipoActual == TipoVisualizacion.FrecuenciasSimuladas)
            {
                return Color.Cyan;
            }
            else if (tipoActual == TipoVisualizacion.GradientesDinamicos)
            {
                return Color.FromArgb(
                    (int)(127 + 127 * Math.Sin(indice + DateTime.Now.Millisecond / 100.0)),
                    (int)(127 + 127 * Math.Sin(indice + 2 + DateTime.Now.Millisecond / 110.0)),
                    (int)(127 + 127 * Math.Sin(indice + 4 + DateTime.Now.Millisecond / 120.0))
                );
            }
            else
            {
                return Color.Red;
            }
        }


        private void DibujarLissajous(Graphics g, Size panelSize)
        {
            int cx = panelSize.Width / 2;
            int cy = panelSize.Height / 2;

            using (var pen = new Pen(Color.Lime, 3))
            {
                int puntos = panelSize.Width;
                var forma = new PointF[puntos];

                for (int x = 0; x < puntos; x++)
                {
                    float frecuencia = 0.01f;
                    float amplitud = panelSize.Height / 3;
                    float y = cy + (float)Math.Sin((x * frecuencia) + tiempo * 2) * amplitud;
                    float ruido = (float)(random.NextDouble() - 0.5) * 30f;
                    forma[x] = new PointF(x, y + ruido);
                }

                g.DrawLines(pen, forma);
            }
        }

        private void DibujarCirculosPulsantes(Graphics g, Size panelSize)
        {
            int cx = panelSize.Width / 2;
            int cy = panelSize.Height / 2;
            float radioBase = 60 + 20 * (float)Math.Sin(tiempo * 2);
            int puntos = 100;

            var puntosCirculo = new PointF[puntos];
            float deformacion = 10 + 10 * (float)Math.Sin(tiempo * 3);

            for (int i = 0; i < puntos; i++)
            {
                float angulo = (float)(i * 2 * Math.PI / puntos);
                float r = radioBase + (float)Math.Sin(angulo * 5 + tiempo * 5) * deformacion;
                float x = cx + r * (float)Math.Cos(angulo);
                float y = cy + r * (float)Math.Sin(angulo);
                puntosCirculo[i] = new PointF(x, y);
            }

            Color color = Color.FromArgb(
                (int)(127 + 127 * Math.Sin(tiempo * 1.3)),
                (int)(127 + 127 * Math.Sin(tiempo * 1.7)),
                (int)(127 + 127 * Math.Sin(tiempo * 2.1))
            );

            using (var brush = new SolidBrush(color))
            {
                g.FillPolygon(brush, puntosCirculo);
            }
        }

        private void DibujarEspiral(Graphics g, Size panelSize)
        {
            int cx = panelSize.Width / 2;
            int cy = panelSize.Height / 2;
            int figuras = 180;
            double escala = 4 + 2 * Math.Sin(tiempo * 0.6);

            for (int i = 0; i < figuras; i++)
            {
                double angulo = i * 0.25 + tiempo * 2;
                double radio = escala * i;

                float x = (float)(cx + radio * Math.Cos(angulo));
                float y = (float)(cy + radio * Math.Sin(angulo));
                float size = 8 + 6 * (float)Math.Abs(Math.Sin(tiempo * 10 + i));

                Color color = Color.FromArgb(
                    (int)(127 + 127 * Math.Sin(i * 0.2 + tiempo * 10)),
                    (int)(127 + 127 * Math.Sin(i * 0.3 + tiempo * 15)),
                    (int)(127 + 127 * Math.Sin(i * 0.4 + tiempo * 20))
                );

                using (var brush = new SolidBrush(color))
                {
                    DibujarFormaEspiral(g, brush, x, y, size, i);
                }
            }
        }

        private void DibujarFormaEspiral(Graphics g, Brush brush, float x, float y, float size, int indice)
        {
            if (indice % 3 == 0)
            {
                // Triángulo
                var tri = new PointF[]
                {
                    new PointF(x, y - size),
                    new PointF(x - size, y + size),
                    new PointF(x + size, y + size)
                };
                g.FillPolygon(brush, tri);
            }
            else if (indice % 3 == 1)
            {
                // Rombo
                var rombo = new PointF[]
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
                var transform = g.Transform;
                g.TranslateTransform(x, y);
                g.RotateTransform((float)(indice * 10 + tiempo * 100));
                g.FillRectangle(brush, -size / 2, -size / 2, size, size);
                g.Transform = transform;
            }
        }
    }
}