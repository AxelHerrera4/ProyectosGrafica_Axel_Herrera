using System;

namespace FigurasTarea
{
    internal class CCirculo
    {
        private double radio;

        public double Radio
        {
            get { return radio; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El radio debe ser un número positivo.");
                radio = value;
            }
        }

        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }
}
