using System;

namespace FigurasTarea
{
    internal class CDeltoide
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double DiagonalMayor { get; set; }
        public double DiagonalMenor { get; set; }

        public void Validar()
        {
            if (Lado1 <= 0 || Lado2 <= 0 || DiagonalMayor <= 0 || DiagonalMenor <= 0)
                throw new ArgumentException("Todos los valores deben ser positivos.");
        }

        public double CalcularArea()
        {
            return (DiagonalMayor * DiagonalMenor) / 2;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Lado1 + Lado2);
        }
    }
}
