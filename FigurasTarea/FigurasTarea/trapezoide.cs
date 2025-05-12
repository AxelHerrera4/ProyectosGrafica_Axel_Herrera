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
    public partial class trapezoide : Form
    {
        public static trapezoide instancia;
        public trapezoide()
        {
            InitializeComponent();
        }
        public static trapezoide  ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new trapezoide();
            }
            return instancia;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (!double.TryParse(textBox1.Text, out double lado1) ||
                    !double.TryParse(textBox4.Text, out double lado2) ||
                    !double.TryParse(textBox5.Text, out double lado3) ||
                    !double.TryParse(textBox6.Text, out double lado4) ||
                    !double.TryParse(textBox7.Text, out double diagonal))
                {
                    MessageBox.Show("Por favor, ingresa valores numéricos válidos.");
                    return;
                }


                CTrapezoide trap = new CTrapezoide
                {
                    Lado1 = lado1,
                    Lado2 = lado2,
                    Lado3 = lado3,
                    Lado4 = lado4,
                    Diagonal = diagonal
                };

                trap.Validar();


                double area = trap.CalcularArea();
                double perimetro = trap.CalcularPerimetro();

             
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
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
