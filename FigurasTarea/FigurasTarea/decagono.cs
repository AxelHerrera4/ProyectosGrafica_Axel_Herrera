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
    public partial class decagono : Form
    {
        public static decagono instancia;
        public decagono()
        {
            InitializeComponent();
        }

        public static decagono ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new decagono();
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
                    MessageBox.Show("Por favor ingrese el lado del decágono.");
                    return;
                }

                double lado;
                if (!double.TryParse(textBox1.Text, out lado) || lado <= 0)
                {
                    MessageBox.Show("Ingrese un valor numérico válido y positivo para el lado.");
                    return;
                }

                CDecagono decagono = new CDecagono();
                decagono.Lado = lado;

                textBox2.Text = decagono.CalcularArea().ToString("F2");
                textBox3.Text = decagono.CalcularPerimetro().ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
