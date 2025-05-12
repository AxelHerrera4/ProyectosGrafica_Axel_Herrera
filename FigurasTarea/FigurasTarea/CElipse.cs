using System;

namespace FigurasTarea
{
    internal class CElipse
    {
        public double SemiejeMayor { get; set; }
        public double SemiejeMenor { get; set; }

        public void Validar()
        {
            if (SemiejeMayor <= 0 || SemiejeMenor <= 0)
                throw new ArgumentException("Ambos ejes deben ser valores positivos.");
        }

        public double CalcularArea()
        {
            return Math.PI * SemiejeMayor * SemiejeMenor;
        }

        public double CalcularPerimetro()
        {
            // Fórmula de Ramanujan (aproximación)
            double a = SemiejeMayor;
            double b = SemiejeMenor;
            return Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b)));
        }
    }
}
