using System;

namespace FigurasTarea
{
    internal class CEneagono
    {
        public double Lado { get; set; }

        public void Validar()
        {
            if (Lado <= 0)
                throw new ArgumentException("El lado debe ser mayor que cero.");
        }

        public double CalcularArea()
        {
            return (9 * Math.Pow(Lado, 2)) / (4 * Math.Tan(Math.PI / 9));
        }

        public double CalcularPerimetro()
        {
            return 9 * Lado;
        }
    }
}
