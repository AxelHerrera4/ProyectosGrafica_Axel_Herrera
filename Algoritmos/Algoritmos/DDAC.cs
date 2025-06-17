using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Algoritmos
{
    internal class DDAC
    {
        public static void dibujarLinea(Bitmap bmp, Pen lapiz, int xI, int yI, int xF, int yF, PictureBox pictureBox, TextBox txtCoordenadas)
        {
            Graphics g = Graphics.FromImage(bmp);
            int centroX = pictureBox.Width / 2;
            int centroY = pictureBox.Height / 2;

            int Deltax = xF - xI;
            int Deltay = yF - yI;

            float m;
            if (Deltax == 0)
            {
                m = float.MaxValue;
            }
            else
            {
                m = (float)Deltay / Deltax;
            }

            int k = Math.Max(Math.Abs(Deltax), Math.Abs(Deltay));

            float x = xI;
            float y = yI;

            txtCoordenadas.Clear(); 

            if (Math.Abs(m) <= 1)
            {
                float incrementoY = m;
                float incrementoX = Math.Sign(Deltax);

                for (int i = 0; i <= k; i++)
                {
                    bmp.SetPixel((int)Math.Round(centroX + x), (int)Math.Round(centroY - y), lapiz.Color);
                    pictureBox.Image = (Bitmap)bmp.Clone();
                    txtCoordenadas.AppendText($"({(int)Math.Round(x)}, {(int)Math.Round(y)}){Environment.NewLine}");
                    Application.DoEvents();
                    Thread.Sleep(30);
                    x += incrementoX;
                    y += incrementoY;
                }
            }
            else
            {
                float incrementoX = (Deltay == 0) ? 0 : 1 / m;
                float incrementoY = Math.Sign(Deltay);

                for (int i = 0; i <= k; i++)
                {
                    bmp.SetPixel((int)Math.Round(centroX + x), (int)Math.Round(centroY - y), lapiz.Color);
                    pictureBox.Image = (Bitmap)bmp.Clone();
                    txtCoordenadas.AppendText($"({(int)Math.Round(x)}, {(int)Math.Round(y)}){Environment.NewLine}");
                    Application.DoEvents();
                    Thread.Sleep(30);
                    x += incrementoX * Math.Sign(Deltax);
                    y += incrementoY;
                }
            }
        }
    }
}
