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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private static Form4 instancia;
        public static Form4 ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Form4();
            }
            return instancia;
        }

        private async void btnBresenham_Click(object sender, EventArgs e)
        {
            try
            {
                string[] puntoInicial = txtPuntoInicial.Text.Split(',');
                string[] puntoFinal = txtPuntoFinal.Text.Split(',');

                int x0 = int.Parse(puntoInicial[0]);
                int y0 = int.Parse(puntoInicial[1]);
                int x1 = int.Parse(puntoFinal[0]);
                int y1 = int.Parse(puntoFinal[1]);

                txtCoordenadas.Clear(); // Limpia el TextBox antes de iniciar

                Bresenham bresenham = new Bresenham(pictureBox1, txtCoordenadas);
                await bresenham.DrawLineAsync(x0, y0, x1, y1, 30); // 30ms por pixel
            }
            catch
            {
                MessageBox.Show("Verifica que los puntos estén en formato correcto: x,y", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
            txtPuntoInicial.Clear();
            txtPuntoFinal.Clear();
            txtCoordenadas.Clear();
        }
    }
}
