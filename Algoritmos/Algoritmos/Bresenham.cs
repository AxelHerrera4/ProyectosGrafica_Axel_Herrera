using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos
{
    public class Bresenham
    {
        private PictureBox pictureBox;
        private Pen pen;
        private TextBox txtCoordenadas;

        public Bresenham(PictureBox pb, TextBox coordenadasTextBox, Pen customPen = null)
        {
            pictureBox = pb;
            txtCoordenadas = coordenadasTextBox;
            if (customPen != null)
            {
                pen = customPen;
            }
            else
            {
                pen = new Pen(Color.DarkBlue);
            }

        }

        private Point TransformToCenter(int x, int y)
        {
            int centerX = pictureBox.Width / 2;
            int centerY = pictureBox.Height / 2;
            return new Point(centerX + x, centerY - y);
        }

        public async Task DrawLineAsync(int x0, int y0, int x1, int y1, int delay = 10)
        {
            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);
            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;
            int err = dx - dy;

            while (true)
            {
                Point p = TransformToCenter(x0, y0);

                pictureBox.Invoke((MethodInvoker)(() =>
                {
                    using (Graphics g = pictureBox.CreateGraphics())
                    {
                        g.FillRectangle(pen.Brush, p.X, p.Y, 1, 1);
                    }
                }));

                txtCoordenadas.Invoke((MethodInvoker)(() =>
                {
                    txtCoordenadas.AppendText($"({x0}, {y0})\r\n");
                }));

                await Task.Delay(delay);

                if (x0 == x1 && y0 == y1) break;

                int e2 = 2 * err;
                if (e2 > -dy) { err -= dy; x0 += sx; }
                if (e2 < dx) { err += dx; y0 += sy; }
            }
        }
    }
}
