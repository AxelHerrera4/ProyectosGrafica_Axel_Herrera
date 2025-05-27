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
    public partial class Form2 : Form
    {
        public static Form2 instancia;
        private CRombo romboActual = new CRombo();

        public Form2()
        {
            InitializeComponent();
        }
        public static Form2 ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Form2();
            }
            return instancia;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            float paso = 10f;
            if (romboActual == null) return;

            if (e.KeyCode == Keys.Left)
                romboActual.Mover(-paso, 0, pictureBox1);
            else if (e.KeyCode == Keys.Right)
                romboActual.Mover(paso, 0, pictureBox1);
            else if (e.KeyCode == Keys.Up)
                romboActual.Mover(0, -paso, pictureBox1);
            else if (e.KeyCode == Keys.Down)
                romboActual.Mover(0, paso, pictureBox1);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                romboActual = new CRombo
                {
                    D1 = float.Parse(textBox4.Text),
                    D2 = float.Parse(textBox5.Text)
                };

                romboActual.Validar();

                textBox2.Text = romboActual.CalcularArea().ToString("F2");
                textBox3.Text = romboActual.CalcularPerimetro().ToString("F2");

                romboActual.DibujarRombo(pictureBox1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox2.Clear();
            textBox3.Clear();
            pictureBox1.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            float nuevaEscala = hScrollBar1.Value / 5.0f;
            romboActual.CambiarEscala(nuevaEscala, pictureBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            romboActual.Rotar(-5, pictureBox1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            romboActual.Rotar(5, pictureBox1);
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
