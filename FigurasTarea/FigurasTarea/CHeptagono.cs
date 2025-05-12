using System;

namespace FigurasTarea
{
    internal class CHeptagono
    {
        public double Lado { get; set; }

        // Validación de que el lado sea positivo
        public void Validar()
        {
            if (Lado <= 0)
                throw new ArgumentException("El lado debe ser mayor que cero.");
        }

        // Cálculo del perímetro
        public double CalcularPerimetro()
        {
            return 7 * Lado;
        }

        // Cálculo del área
        public double CalcularArea()
        {
            return (7 * Math.Pow(Lado, 2)) / (4 * Math.Tan(Math.PI / 7));
        }
    }
}
