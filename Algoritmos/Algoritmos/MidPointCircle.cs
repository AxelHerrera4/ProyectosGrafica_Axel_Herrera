using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Algoritmos
{
    internal class MidPointCircle
    {
        public int Xc { get; set; }
        public int Yc { get; set; }
        public int R { get; set; }

        public List<Point> CalcularPuntos()
        {
            List<Point> puntos = new List<Point>();

            int x = 0;
            int y = R;
            int p = 1 - R;

            AgregarSimetria(puntos, x, y);

            while (x < y)
            {
                x++;
                if (p < 0)
                {
                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }

                AgregarSimetria(puntos, x, y);
            }

            return puntos.Select(pt => new Point(pt.X + Xc, pt.Y + Yc)).ToList();
        }


        private void AgregarSimetria(List<Point> puntos, int x, int y)
        {
            puntos.Add(new Point(x, y));
            puntos.Add(new Point(-x, y));
            puntos.Add(new Point(x, -y));
            puntos.Add(new Point(-x, -y));
            puntos.Add(new Point(y, x));
            puntos.Add(new Point(-y, x));
            puntos.Add(new Point(y, -x));
            puntos.Add(new Point(-y, -x));
        }
    }
}
