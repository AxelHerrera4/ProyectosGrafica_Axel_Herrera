using System;
using System.Drawing;
using System.Windows.Forms;

namespace FigurasTarea
{
    internal class CPentagono
    {
        public double Lado { get; set; }
        public float PosX { get; set; } = 0;
        public float PosY { get; set; } = 0;
        public float Escala { get; set; } = 1.0f;
        public float RotacionGrados { get; set; } = 0f;

        public void Validar()
        {
            if (Lado <= 0)
                throw new ArgumentException("El lado debe ser mayor que cero.");
        }

        public double CalcularArea()
        {
            return (5 * Math.Pow(Lado, 2)) / (4 * Math.Tan(Math.PI / 5));
        }

        public double CalcularPerimetro()
        {
            return 5 * Lado;
        }

        public void DibujarPentagono(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            g.Clear(pictureBox.BackColor);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int cx = pictureBox.Width / 2 + (int)PosX;
            int cy = pictureBox.Height / 2 + (int)PosY;
            double radio = Lado * Escala / (2 * Math.Sin(Math.PI / 5));

            PointF[] puntos = new PointF[5];
            double anguloInicial = (Math.PI / 2) + (RotacionGrados * Math.PI / 180);

            for (int i = 0; i < 5; i++)
            {
                double angulo = anguloInicial + (i * 2 * Math.PI / 5);
                float x = cx + (float)(radio * Math.Cos(angulo));
                float y = cy - (float)(radio * Math.Sin(angulo));
                puntos[i] = new PointF(x, y);
            }

            using (Pen lapiz = new Pen(Color.Blue, 2))
            {
                g.DrawPolygon(lapiz, puntos);
            }

            g.Dispose();
        }

        public void Mover(float dx, float dy, PictureBox pictureBox)
        {
            PosX += dx;
            PosY += dy;
            DibujarPentagono(pictureBox);
        }

        public void Rotar(float grados, PictureBox pictureBox)
        {
            RotacionGrados += grados;
            DibujarPentagono(pictureBox);
        }

        public void CambiarEscala(float nuevaEscala, PictureBox pictureBox)
        {
            Escala = nuevaEscala;
            DibujarPentagono(pictureBox);
        }
    }
}
