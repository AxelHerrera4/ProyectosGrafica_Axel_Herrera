using System;

namespace FigurasTarea
{
    internal class CPentagono
    {
        public double Lado { get; set; }

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
    }
}
