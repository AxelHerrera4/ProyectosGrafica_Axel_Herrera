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
    public partial class ovalo : Form
    {
        public static ovalo instancia;
        public ovalo()
        {
            InitializeComponent();
        }
        public static ovalo ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new ovalo();
            }
            return instancia;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(textBox1.Text, out double radio) ||
                    !double.TryParse(textBox4.Text, out double longitud))
                {
                    MessageBox.Show("Ingresa valores numéricos válidos para el radio y la longitud.");
                    return;
                }

                COvalo ovalo = new COvalo
                {
                    Radio = radio,
                    Longitud = longitud
                };

                ovalo.Validar();

                double area = ovalo.CalcularArea();
                double perimetro = ovalo.CalcularPerimetro();

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
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
