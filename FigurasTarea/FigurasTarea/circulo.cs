using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FigurasTarea
{
    public partial class circulo : Form
    {

        public static circulo instancia;
        public circulo()
        {
            InitializeComponent();
        }

        public static circulo ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new circulo();
            }
            return instancia;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Radio
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Área (solo lectura)
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Perímetro (solo lectura)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Por favor ingrese el radio del círculo.");
                    return;
                }

                double radio;
                if (!double.TryParse(textBox1.Text, out radio) || radio <= 0)
                {
                    MessageBox.Show("Ingrese un valor numérico válido y positivo para el radio.");
                    return;
                }

                CCirculo circulo = new CCirculo();
                circulo.Radio = radio;

                textBox2.Text = circulo.CalcularArea().ToString("F2"); // Formateado a 2 decimales
                textBox3.Text = circulo.CalcularPerimetro().ToString("F2");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
