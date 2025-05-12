using System;

namespace FigurasTarea
{
    internal class Ccuadrado
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

        public double CalcularArea()
        {
            return lado * lado;
        }

        public double CalcularPerimetro()
        {
            return 4 * lado;
        }
    }
}
