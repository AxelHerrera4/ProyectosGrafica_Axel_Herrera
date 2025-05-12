using System;

namespace FigurasTarea
{
    internal class CRectangulo
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }

        public void Validar()
        {
            if (Largo <= 0 || Ancho <= 0)
                throw new ArgumentException("El largo y el ancho deben ser mayores que cero.");
        }

        public double CalcularArea()
        {
            return Largo * Ancho;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Largo + Ancho);
        }
    }
}
