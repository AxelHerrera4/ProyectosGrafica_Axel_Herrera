using System;
using System.Drawing;
using System.Windows.Forms;

namespace FigurasGeometricasDibujar
{
    internal class CRomboide
    {
        public float Base { get; set; }
        public float Altura { get; set; }
        public float LadoOblicuo { get; set; }

        private float centroX = 150;
        private float centroY = 150;
        private float angulo = 0;
        private float escala = 1;

        public void Validar()
        {
            if (Base <= 0 || Altura <= 0 || LadoOblicuo <= 0)
                throw new Exception("Todos los lados deben ser mayores a cero.");
        }

        public float CalcularArea()
        {
            return Base * Altura;
        }

        public float CalcularPerimetro()
        {
            return 2 * (Base + LadoOblicuo);
        }

        public void DibujarRomboide(PictureBox pb)
        {
            Bitmap bmp = new Bitmap(pb.Width, pb.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            float b = Base * escala;
            float h = Altura * escala;
            float o = LadoOblicuo * escala;

            float desplazamientoX = (float)Math.Sqrt(Math.Pow(o, 2) - Math.Pow(h, 2));

            PointF[] puntos = new PointF[4];
            puntos[0] = RotarPunto(centroX, centroY); 
            puntos[1] = RotarPunto(centroX + b, centroY); 
            puntos[2] = RotarPunto(centroX + b + desplazamientoX, centroY - h); 
            puntos[3] = RotarPunto(centroX + desplazamientoX, centroY - h);

            g.DrawPolygon(Pens.Black, puntos);
            g.FillPolygon(Brushes.LightGreen, puntos);

            pb.Image = bmp;
        }

        public void Mover(float dx, float dy, PictureBox pb)
        {
            centroX += dx;
            centroY += dy;
            DibujarRomboide(pb);
        }

        public void CambiarEscala(float nuevaEscala, PictureBox pb)
        {
            escala = nuevaEscala;
            DibujarRomboide(pb);
        }

        public void Rotar(float grados, PictureBox pb)
        {
            angulo += grados;
            DibujarRomboide(pb);
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
