using FigurasTarea;
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
    public partial class Form1 : Form
    {
        public static Form1 instancia;
        private CPentagono pentagonoActual = new CPentagono();

        public Form1()
        {
            InitializeComponent();
        }
        public static Form1 ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Form1();
            }
            return instancia;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar y convertir el texto ingresado
            if (float.TryParse(textBox1.Text, out float lado))
            {
                // Crear el objeto pentágono
                pentagonoActual = new CPentagono { Lado = lado };
                pentagonoActual.Validar();

                // Calcular y mostrar
                textBox2.Text = pentagonoActual.CalcularArea().ToString("F2");
                textBox3.Text = pentagonoActual.CalcularPerimetro().ToString("F2");

                // Dibujar
                pentagonoActual.DibujarPentagono(pictureBox1);
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido para el lado.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            pictureBox1.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            float paso = 10f;
            if (pentagonoActual == null) return;

            if (e.KeyCode == Keys.Left)
                pentagonoActual.Mover(-paso, 0, pictureBox1);
            else if (e.KeyCode == Keys.Right)
                pentagonoActual.Mover(paso, 0, pictureBox1);
            else if (e.KeyCode == Keys.Up)
                pentagonoActual.Mover(0, -paso, pictureBox1);
            else if (e.KeyCode == Keys.Down)
                pentagonoActual.Mover(0, paso, pictureBox1);
        }


        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            float nuevaEscala = hScrollBar1.Value / 5.0f; // escala entre 0.2 y 2
            pentagonoActual.CambiarEscala(nuevaEscala, pictureBox1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pentagonoActual.Rotar(-5, pictureBox1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pentagonoActual.Rotar(5, pictureBox1);
        }
    }
}
