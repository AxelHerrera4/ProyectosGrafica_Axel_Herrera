using System;

namespace FigurasTarea
{
    internal class CRomboide
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Lado { get; set; }

        public void Validar()
        {
            if (Base <= 0 || Altura <= 0 || Lado <= 0)
                throw new ArgumentException("La base, la altura y el lado deben ser mayores que cero.");
        }

        public double CalcularArea()
        {
            return Base * Altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Base + Lado);
        }
    }
}
