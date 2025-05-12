using System;

namespace FigurasTarea
{
    internal class CHexagono
    {
        public double Lado { get; set; }

        public void Validar()
        {
            if (Lado <= 0)
                throw new ArgumentException("El lado debe ser mayor que cero.");
        }

        public double CalcularPerimetro()
        {
            return 6 * Lado;
        }

        public double CalcularArea()
        {
            return (3 * Math.Sqrt(3) * Math.Pow(Lado, 2)) / 2;
        }
    }
}
