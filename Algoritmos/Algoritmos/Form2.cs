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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtCentroX_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCentroY_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRadio_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnDibujar_Click(object sender, EventArgs e)
        {
            int centroUsuarioX = int.Parse(txtCentroX.Text);
            int centroUsuarioY = int.Parse(txtCentroY.Text);
            int radio = int.Parse(txtRadio.Text);

            MidPointCircle circulo = new MidPointCircle();
            circulo.Xc = centroUsuarioX;
            circulo.Yc = centroUsuarioY;
            circulo.R = radio;

            List<Point> puntos = circulo.CalcularPuntos();

            Graphics g = picLienzo.CreateGraphics();
            g.Clear(Color.White); // Limpia antes de dibujar

            int Xc = picLienzo.Width / 2;
            int Yc = picLienzo.Height / 2;

            foreach (Point punto in puntos)
            {
                int pantallaX = Xc + punto.X;
                int pantallaY = Yc - punto.Y;

                if (pantallaX >= 0 && pantallaX < picLienzo.Width && pantallaY >= 0 && pantallaY < picLienzo.Height)
                {
                    g.FillRectangle(Brushes.Red, pantallaX, pantallaY, 1, 1);
                    txtCoordenadas.AppendText($"({punto.X}, {punto.Y})\r\n");
                    await Task.Delay(10); // Espera entre puntos
                }
            }

        }

        private void picLienzo_Click(object sender, EventArgs e)
        {

        }
    }
}
