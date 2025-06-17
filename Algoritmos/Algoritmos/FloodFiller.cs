using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Algoritmos
{
    internal class FloodFiller
    {
        public static void FloodFill(Bitmap bmp, PictureBox pictureBox, int x, int y, Color targetColor, Color fillColor, TextBox consola)
        {
            if (targetColor.ToArgb() == fillColor.ToArgb())
                return;

            Queue<Point> pixels = new Queue<Point>();
            pixels.Enqueue(new Point(x, y));

            while (pixels.Count > 0)
            {
                Point p = pixels.Dequeue();

                if (p.X < 0 || p.X >= bmp.Width || p.Y < 0 || p.Y >= bmp.Height)
                    continue;

                if (bmp.GetPixel(p.X, p.Y).ToArgb() != targetColor.ToArgb())
                    continue;

                bmp.SetPixel(p.X, p.Y, fillColor);

                consola.AppendText($"({p.X}, {p.Y})\r\n");

                pictureBox.Refresh();
                Application.DoEvents();
                Thread.Sleep(1);

                pixels.Enqueue(new Point(p.X + 1, p.Y));
                pixels.Enqueue(new Point(p.X - 1, p.Y));
                pixels.Enqueue(new Point(p.X, p.Y + 1));
                pixels.Enqueue(new Point(p.X, p.Y - 1));
            }
        }
    }
}
