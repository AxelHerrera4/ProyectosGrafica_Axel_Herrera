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
    public partial class deltoide : Form
    {
        public static deltoide instancia;
        public deltoide()
        {
            InitializeComponent();
        }
        public static deltoide ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new deltoide();
            }
            return instancia;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text) ||
                    string.IsNullOrWhiteSpace(textBox5.Text) ||
                    string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    MessageBox.Show("Por favor ingrese todos los valores requeridos.");
                    return;
                }

                if (!double.TryParse(textBox1.Text, out double lado1) ||
                    !double.TryParse(textBox4.Text, out double lado2) ||
                    !double.TryParse(textBox5.Text, out double diagMayor) ||
                    !double.TryParse(textBox6.Text, out double diagMenor))
                {
                    MessageBox.Show("Todos los valores deben ser numéricos válidos.");
                    return;
                }

                CDeltoide deltoide = new CDeltoide
                {
                    Lado1 = lado1,
                    Lado2 = lado2,
                    DiagonalMayor = diagMayor,
                    DiagonalMenor = diagMenor
                };

                deltoide.Validar();

                textBox2.Text = deltoide.CalcularArea().ToString("F2");
                textBox3.Text = deltoide.CalcularPerimetro().ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
