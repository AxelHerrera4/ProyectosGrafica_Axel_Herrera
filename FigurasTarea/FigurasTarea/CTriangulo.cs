using System;

namespace FigurasTarea
{
    internal class CTriangulo
    {
        public double LadoIgual { get; set; }  
        public double Base { get; set; }   

        public void Validar()
        {
            if (LadoIgual <= 0 || Base <= 0)
                throw new ArgumentException("Los lados deben ser mayores a cero.");

            if (Base >= 2 * LadoIgual)
                throw new ArgumentException("Los valores no forman un triángulo isósceles válido.");
        }

        public double CalcularPerimetro()
        {
            return 2 * LadoIgual + Base;
        }

        public double CalcularArea()
        {
            double altura = Math.Sqrt(Math.Pow(LadoIgual, 2) - Math.Pow(Base / 2, 2));
            return (Base * altura) / 2;
        }
    }
}
