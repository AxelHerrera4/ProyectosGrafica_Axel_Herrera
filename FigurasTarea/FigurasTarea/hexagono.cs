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
    public partial class hexagono : Form
    {
        public static hexagono instancia;

        public hexagono()
        {
            InitializeComponent();
        }
        public static hexagono ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new hexagono();
            }
            return instancia;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Por favor, ingresa el valor del lado.");
                    return;
                }

                if (!double.TryParse(textBox1.Text, out double lado))
                {
                    MessageBox.Show("Ingresa un valor numérico válido.");
                    return;
                }

                CHexagono hexagono = new CHexagono
                {
                    Lado = lado
                };

                hexagono.Validar();

                textBox2.Text = hexagono.CalcularArea().ToString("F2");
                textBox3.Text = hexagono.CalcularPerimetro().ToString("F2");
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
    }
}
