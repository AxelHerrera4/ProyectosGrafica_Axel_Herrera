using System;

namespace FigurasTarea
{
    internal class CTrapecioIso
    {
        public double BaseMayor { get; set; }
        public double BaseMenor { get; set; }
        public double Altura { get; set; }

        public void Validar()
        {
            if (BaseMayor <= 0 || BaseMenor <= 0 || Altura <= 0)
                throw new ArgumentException("Las bases y la altura deben ser mayores que cero.");

            if (BaseMenor >= BaseMayor)
                throw new ArgumentException("La base menor debe ser menor que la base mayor.");
        }

        public double CalcularArea()
        {
            return (BaseMayor + BaseMenor) / 2 * Altura;
        }

        public double CalcularPerimetro()
        {
            double ladoInclinado = Math.Sqrt(Math.Pow((BaseMayor - BaseMenor) / 2, 2) + Math.Pow(Altura, 2));
            return BaseMayor + BaseMenor + 2 * ladoInclinado;
        }
    }
}
