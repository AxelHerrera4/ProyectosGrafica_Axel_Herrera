using System;

namespace FigurasTarea
{
    internal class CRombo
    {
        public double DiagonalMayor { get; set; }
        public double DiagonalMenor { get; set; }

        public void Validar()
        {
            if (DiagonalMayor <= 0 || DiagonalMenor <= 0)
                throw new ArgumentException("Las diagonales deben ser mayores que cero.");
        }

        public double CalcularArea()
        {
            return (DiagonalMayor * DiagonalMenor) / 2;
        }


        public double CalcularPerimetro()
        {
            double lado = Math.Sqrt(Math.Pow(DiagonalMayor / 2, 2) + Math.Pow(DiagonalMenor / 2, 2));
            return 4 * lado;
        }
    }
}
