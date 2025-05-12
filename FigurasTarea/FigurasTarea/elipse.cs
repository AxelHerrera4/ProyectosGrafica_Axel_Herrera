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
    public partial class elipse : Form
    {
        public static elipse instancia;
        public elipse()
        {
            InitializeComponent();
        }
        public static elipse ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new elipse();
            }
            return instancia;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show("Por favor, ingrese ambos valores de los semiejes.");
                    return;
                }

                if (!double.TryParse(textBox1.Text, out double a) || !double.TryParse(textBox4.Text, out double b))
                {
                    MessageBox.Show("Los semiejes deben ser valores numéricos válidos.");
                    return;
                }

                CElipse elipse = new CElipse
                {
                    SemiejeMayor = a,
                    SemiejeMenor = b
                };

                elipse.Validar();

                textBox2.Text = elipse.CalcularArea().ToString("F2");
                textBox3.Text = elipse.CalcularPerimetro().ToString("F2");
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
