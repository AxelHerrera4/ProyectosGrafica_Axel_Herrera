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
    public partial class Form3 : Form
    {
        public static Form3 instancia;
        private CRomboide romboideActual= new CRomboide();
        public Form3()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public static Form3 ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Form3();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float baseRomboide = float.Parse(textBox1.Text);
                float altura = float.Parse(textBox4.Text);
                float ladoOblicuo = float.Parse(textBox5.Text);

                romboideActual = new CRomboide
                {
                    Base = baseRomboide,
                    Altura = altura,
                    LadoOblicuo = ladoOblicuo
                };

                romboideActual.Validar();

                textBox2.Text = romboideActual.CalcularArea().ToString("0.00");
                textBox3.Text = romboideActual.CalcularPerimetro().ToString("0.00");

                DibujarRomboide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Verifica los valores numéricos ingresados.\n" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox2.Clear();
            textBox3.Clear();
            pictureBox1.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (romboideActual != null)
            {
                float escala = hScrollBar1.Value / 10.0f;
                romboideActual.CambiarEscala(escala, pictureBox1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (romboideActual != null)
            {
                romboideActual.Rotar(-5, pictureBox1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (romboideActual != null)
            {
                romboideActual.Rotar(5, pictureBox1);
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            float paso = 10f;
            if (romboideActual == null) return;

            if (e.KeyCode == Keys.Left)
                romboideActual.Mover(-paso, 0, pictureBox1);
            else if (e.KeyCode == Keys.Right)
                romboideActual.Mover(paso, 0, pictureBox1);
            else if (e.KeyCode == Keys.Up)
                romboideActual.Mover(0, -paso, pictureBox1);
            else if (e.KeyCode == Keys.Down)
                romboideActual.Mover(0, paso, pictureBox1);
        }
        private void DibujarRomboide()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                romboideActual.DibujarRomboide(pictureBox1);
            }
            pictureBox1.Image = bmp;
        }
    }
}
