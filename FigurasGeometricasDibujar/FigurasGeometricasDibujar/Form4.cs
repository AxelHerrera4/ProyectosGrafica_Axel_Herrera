using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricasDibujar
{
    public partial class Form4 : Form
    {
        public static Form4 instancia;
        private CTrapezoide trapezoideActual = new CTrapezoide();
        public Form4()
        {
            InitializeComponent();
        }
        public static Form4 ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Form4();
            }
            return instancia;
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            float paso = 10f;
            if (trapezoideActual == null) return;

            if (e.KeyCode == Keys.Left)
                trapezoideActual.Mover(-paso, 0, pictureBox1);
            else if (e.KeyCode == Keys.Right)
                trapezoideActual.Mover(paso, 0, pictureBox1);
            else if (e.KeyCode == Keys.Up)
                trapezoideActual.Mover(0, -paso, pictureBox1);
            else if (e.KeyCode == Keys.Down)
                trapezoideActual.Mover(0, paso, pictureBox1);
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                trapezoideActual.Lado1 = Convert.ToDouble(textBox1.Text);  // Base menor
                trapezoideActual.Lado2 = Convert.ToDouble(textBox4.Text);  // Lado oblicuo izq
                trapezoideActual.Lado3 = Convert.ToDouble(textBox5.Text);  // Base mayor
                trapezoideActual.Lado4 = Convert.ToDouble(textBox6.Text);  // Lado oblicuo der
                trapezoideActual.Diagonal = Convert.ToDouble(textBox7.Text);

              
                trapezoideActual.Validar();

                trapezoideActual.DibujarTrapezoide(pictureBox1);

                double area = trapezoideActual.CalcularArea();
                double perimetro = trapezoideActual.CalcularPerimetro();
                textBox2.Text = area.ToString("F2");
                textBox3.Text = perimetro.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa todos los lados y la diagonal correctamente (números válidos).");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error de validación: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            pictureBox1.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (trapezoideActual != null)
            {
                float escala = hScrollBar1.Value / 10.0f;
                trapezoideActual.CambiarEscala(escala, pictureBox1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (trapezoideActual != null)
            {
                trapezoideActual.Rotar(-5, pictureBox1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (trapezoideActual != null)
            {
                trapezoideActual.Rotar(5, pictureBox1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
