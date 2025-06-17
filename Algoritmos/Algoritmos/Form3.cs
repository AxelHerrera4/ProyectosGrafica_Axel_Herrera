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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int xI = int.Parse(txtXi.Text);
                int yI = int.Parse(txtYi.Text);
                int xF = int.Parse(txtXf.Text);
                int yF = int.Parse(txtYf.Text);

                Bitmap bmp = new Bitmap(picGrafico.Width, picGrafico.Height);
                Pen lapiz = new Pen(Color.Blue);

                DDAC.dibujarLinea(bmp, lapiz, xI, yI, xF, yF, picGrafico, txtCoordenadas);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtXi.Clear();
            txtYi.Clear();
            txtXf.Clear();
            txtYf.Clear();
            picGrafico.Image = null;
        }

        private void picGrafico_Click(object sender, EventArgs e)
        {

        }
    }
}
