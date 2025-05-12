using System;

namespace FigurasTarea
{
    internal class COctagono
    {
        public double Lado { get; set; }

        public void Validar()
        {
            if (Lado <= 0)
                throw new ArgumentException("El lado debe ser mayor que cero.");
        }

        public double CalcularPerimetro()
        {
            return 8 * Lado;
        }

        public double CalcularArea()
        {
            return 2 * (1 + Math.Sqrt(2)) * Math.Pow(Lado, 2);
        }
    }
}
