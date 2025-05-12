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
    public partial class rombo : Form
    {
        public static rombo instancia;
        public rombo()
        {
            InitializeComponent();
        }
        public static rombo ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new rombo();
            }
            return instancia;
        }

        private void label5_Click(object sender, EventArgs e)
        {

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
                if (!double.TryParse(textBox4.Text, out double diagonalMayor) ||
                    !double.TryParse(textBox5.Text, out double diagonalMenor))
                {
                    MessageBox.Show("Por favor ingresa valores numéricos válidos para las diagonales.");
                    return;
                }

               
                CRombo rombo = new CRombo
                {
                    DiagonalMayor = diagonalMayor,
                    DiagonalMenor = diagonalMenor
                };

                rombo.Validar();

                double area = rombo.CalcularArea();
                double perimetro = rombo.CalcularPerimetro();

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
            textBox4.Clear();
            textBox5.Clear();
            textBox2.Clear();
            textBox3.Clear();
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
    }
}
