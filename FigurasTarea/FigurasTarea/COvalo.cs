using System;

namespace FigurasTarea
{
    internal class COvalo
    {
        public double Radio { get; set; }
        public double Longitud { get; set; } 

        public void Validar()
        {
            if (Radio <= 0 || Longitud <= 0)
                throw new ArgumentException("Los valores deben ser mayores que cero.");
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2) + 2 * Radio * Longitud;
        }

        public double CalcularPerimetro()
        {
            return 2 * Longitud + 2 * Math.PI * Radio;
        }
    }
}
