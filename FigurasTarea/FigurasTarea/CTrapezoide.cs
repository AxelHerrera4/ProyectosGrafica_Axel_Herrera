using System;

namespace FigurasTarea
{
    internal class CTrapezoide
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }
        public double Lado4 { get; set; }
        public double Diagonal { get; set; }

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
    }
}
