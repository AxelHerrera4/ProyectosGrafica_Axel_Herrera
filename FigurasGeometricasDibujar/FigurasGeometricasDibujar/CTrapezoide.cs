using System;
using System.Drawing;
using System.Windows.Forms;

namespace FigurasGeometricasDibujar
{
    internal class CTrapezoide
    {
        public double Lado1 { get; set; } // Base menor (abajo)
        public double Lado2 { get; set; } // Lado oblicuo izquierdo
        public double Lado3 { get; set; } // Base mayor (arriba)
        public double Lado4 { get; set; } // Lado oblicuo derecho
        public double Diagonal { get; set; }

        private float centroX = 150;
        private float centroY = 150;
        private float angulo = 0;
        private float escala = 1;

        public void Validar()
        {
            if (Lado1 <= 0 || Lado2 <= 0 || Lado3 <= 0 || Lado4 <= 0 || Diagonal <= 0)
                throw new ArgumentException("Todos los lados y la diagonal deben ser mayores a cero.");

            if (!(Lado1 + Lado2 > Diagonal &&
                  Lado1 + Diagonal > Lado2 &&
                  Lado2 + Diagonal > Lado1))
                throw new ArgumentException("La diagonal no forma un triángulo válido con Lado1 y Lado2.");

            if (!(Lado3 + Lado4 > Diagonal &&
                  Lado3 + Diagonal > Lado4 &&
                  Lado4 + Diagonal > Lado3))
                throw new ArgumentException("La diagonal no forma un triángulo válido con Lado3 y Lado4.");
        }

        private double CalcularAreaTriangulo(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double area = s * (s - a) * (s - b) * (s - c);
            return area > 0 ? Math.Sqrt(area) : 0;
        }

        public double CalcularArea()
        {
            double area1 = CalcularAreaTriangulo(Lado1, Lado2, Diagonal);
            double area2 = CalcularAreaTriangulo(Lado3, Lado4, Diagonal);
            return area1 + area2;
        }

        public double CalcularPerimetro()
        {
            return Lado1 + Lado2 + Lado3 + Lado4;
        }

        public void DibujarTrapezoide(PictureBox pb)
        {
            Bitmap bmp = new Bitmap(pb.Width, pb.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            float escalaLocal = escala;

            float b = (float)(Lado1 * escalaLocal); 
            float B = (float)(Lado3 * escalaLocal); 
            float a = (float)(Lado2 * escalaLocal); 
            float c = (float)(Lado4 * escalaLocal); 

            float diff = B - b;

            float x = 0;
            float h = 0;

            if (Math.Abs(diff) > 0.0001f)
            {
                x = (diff * diff + a * a - c * c) / (2 * diff);
                h = (float)Math.Sqrt(Math.Max(0, a * a - x * x));
            }
            else
            {
                h = a; 
            }

            PointF p0 = new PointF(centroX, centroY);           
            PointF p1 = new PointF(centroX + b, centroY);       
            PointF p2 = new PointF(centroX + b + x - diff, centroY - h); 
            PointF p3 = new PointF(centroX - diff + x, centroY - h);     

            PointF[] puntos = new PointF[4];
            puntos[0] = RotarPunto(p0.X, p0.Y);
            puntos[1] = RotarPunto(p1.X, p1.Y);
            puntos[2] = RotarPunto(p2.X, p2.Y);
            puntos[3] = RotarPunto(p3.X, p3.Y);

            g.DrawPolygon(Pens.Black, puntos);
            g.FillPolygon(Brushes.LightSalmon, puntos);

            pb.Image = bmp;
        }


        public void Mover(float dx, float dy, PictureBox pb)
        {
            centroX += dx;
            centroY += dy;
            DibujarTrapezoide(pb);
        }

        public void CambiarEscala(float nuevaEscala, PictureBox pb)
        {
            escala = nuevaEscala;
            DibujarTrapezoide(pb);
        }

        public void Rotar(float grados, PictureBox pb)
        {
            angulo += grados;
            DibujarTrapezoide(pb);
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
