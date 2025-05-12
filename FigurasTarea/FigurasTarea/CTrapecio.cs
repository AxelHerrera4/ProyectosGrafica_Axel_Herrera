using System;

namespace FigurasTarea
{
    internal class CTrapecio
    {
        public double BaseMayor { get; set; }
        public double BaseMenor { get; set; }
        public double Altura { get; set; }
        public double LadoIzquierdo { get; set; }
        public double LadoDerecho { get; set; }

        public void Validar()
        {
            if (BaseMayor <= 0 || BaseMenor <= 0 || Altura <= 0 || LadoIzquierdo <= 0 || LadoDerecho <= 0)
                throw new ArgumentException("Todos los lados y la altura deben ser mayores que cero.");

            if (BaseMenor >= BaseMayor)
                throw new ArgumentException("La base menor debe ser realmente menor que la base mayor.");

            if (LadoIzquierdo <= Altura || LadoDerecho <= Altura)
                throw new ArgumentException("Los lados no paralelos (izquierdo y derecho) deben ser mayores que la altura.");
        }


        public double CalcularArea()
        {
            return ((BaseMayor + BaseMenor) * Altura) / 2;
        }

        public double CalcularPerimetro()
        {
            return BaseMayor + BaseMenor + LadoIzquierdo + LadoDerecho;
        }
    }
}
