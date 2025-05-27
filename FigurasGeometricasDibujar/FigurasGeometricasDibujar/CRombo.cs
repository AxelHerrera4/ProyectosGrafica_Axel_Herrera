using System;
using System.Drawing;
using System.Windows.Forms;

namespace FigurasGeometricasDibujar
{
    internal class CRombo
    {
        public float D1 { get; set; }
        public float D2 { get; set; }

        private float centroX = 150;
        private float centroY = 150;
        private float angulo = 0;
        private float escala = 1;

        public void Validar()
        {
            if (D1 <= 0 || D2 <= 0)
                throw new Exception("Las diagonales deben ser mayores a cero.");
        }

        public float CalcularArea()
        {
            return (D1 * D2) / 2f;
        }

        public float CalcularPerimetro()
        {
            float lado = (float)Math.Sqrt(Math.Pow(D1 / 2, 2) + Math.Pow(D2 / 2, 2));
            return lado * 4;
        }

        public void DibujarRombo(PictureBox pb)
        {
            Bitmap bmp = new Bitmap(pb.Width, pb.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            PointF[] puntos = new PointF[4];

            float d1 = D1 * escala;
            float d2 = D2 * escala;

            puntos[0] = RotarPunto(centroX, centroY - d2 / 2); 
            puntos[1] = RotarPunto(centroX + d1 / 2, centroY); 
            puntos[2] = RotarPunto(centroX, centroY + d2 / 2);
            puntos[3] = RotarPunto(centroX - d1 / 2, centroY);

            g.DrawPolygon(Pens.Black, puntos);
            g.FillPolygon(Brushes.LightBlue, puntos);

            pb.Image = bmp;
        }

        public void Mover(float dx, float dy, PictureBox pb)
        {
            centroX += dx;
            centroY += dy;
            DibujarRombo(pb);
        }

        public void CambiarEscala(float nuevaEscala, PictureBox pb)
        {
            escala = nuevaEscala;
            DibujarRombo(pb);
        }

        public void Rotar(float grados, PictureBox pb)
        {
            angulo += grados;
            DibujarRombo(pb);
        }

        private PointF RotarPunto(float x, float y)
        {
            float rad = angulo * (float)Math.PI / 180f;
            float cos = (float)Math.Cos(rad);
            float sin = (float)Math.Sin(rad);

            float dx = x - centroX;
            float dy = y - centroY;

            float xr = dx * cos - dy * sin + centroX;
            float yr = dx * sin + dy * cos + centroY;

            return new PointF(xr, yr);
        }
    }
}
