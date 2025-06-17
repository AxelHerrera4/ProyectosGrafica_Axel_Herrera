using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos
{
    public partial class Form1 : Form
    {
        private Bitmap bmp;
        private Graphics g;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);

            if (int.TryParse(textBox1.Text, out int radio))
            {
                Pen pen = new Pen(Color.Black, 2);
                int centroX = pictureBox1.Width / 2;
                int centroY = pictureBox1.Height / 2;

                g.DrawEllipse(pen, centroX - radio, centroY - radio, radio * 2, radio * 2);
                pictureBox1.Refresh();
            }
            else
            {
                MessageBox.Show("Ingresa un número válido para el radio.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            int x = me.X;
            int y = me.Y;

            if (x < 0 || x >= bmp.Width || y < 0 || y >= bmp.Height)
                return;

            Color targetColor = bmp.GetPixel(x, y);
            Color fillColor = Color.Blue;

            txtConsola.Clear(); // Limpiar coordenadas anteriores
            FloodFiller.FloodFill(bmp, pictureBox1, x, y, targetColor, fillColor, txtConsola);
        }

    }
}
