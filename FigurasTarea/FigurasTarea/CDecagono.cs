using System;

namespace FigurasTarea
{
    internal class CDecagono
    {
        private double lado;

        public double Lado
        {
            get { return lado; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El lado debe ser un número positivo.");
                lado = value;
            }
        }

        public double CalcularPerimetro()
        {
            return 10 * lado;
        }

        public double CalcularArea()
        {
            return (5 * Math.Pow(lado, 2)) / (2 * Math.Tan(Math.PI / 10));
        }
    }
}
