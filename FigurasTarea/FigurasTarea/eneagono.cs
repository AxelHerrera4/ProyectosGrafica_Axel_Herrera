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
    public partial class eneagono : Form
    {
        public static eneagono instancia;
        public eneagono()
        {
            InitializeComponent();
        }
        public static eneagono ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new eneagono();
            }
            return instancia;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void textBox3_TextChanged(object sender, EventArgs e) { }

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

                CEneagono eneagono = new CEneagono
                {
                    Lado = lado
                };

                eneagono.Validar();

                textBox2.Text = eneagono.CalcularArea().ToString("F2");
                textBox3.Text = eneagono.CalcularPerimetro().ToString("F2");
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
