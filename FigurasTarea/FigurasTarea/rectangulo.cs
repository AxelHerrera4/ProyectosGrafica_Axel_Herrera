using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasTarea
{
    public partial class rectangulo : Form
    {
        public static rectangulo instancia;
        public rectangulo()
        {
            InitializeComponent();
        }
        public static rectangulo ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new rectangulo();
            }
            return instancia;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(textBox1.Text, out double largo) || !double.TryParse(textBox4.Text, out double ancho))
                {
                    MessageBox.Show("Por favor ingresa valores numéricos válidos para el largo y el ancho.");
                    return;
                }

                CRectangulo rectangulo = new CRectangulo
                {
                    Largo = largo,
                    Ancho = ancho
                };

                rectangulo.Validar();

                double area = rectangulo.CalcularArea();
                double perimetro = rectangulo.CalcularPerimetro();

                textBox2.Text = area.ToString("F2");     
                textBox3.Text = perimetro.ToString("F2"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox4.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
