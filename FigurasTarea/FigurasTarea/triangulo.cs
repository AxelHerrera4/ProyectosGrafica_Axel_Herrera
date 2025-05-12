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
    public partial class triangulo : Form
    {
        public static triangulo instancia;
        public triangulo()
        {
            InitializeComponent();
        }

        public static triangulo ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new triangulo();
            }
            return instancia;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CTriangulo t = new CTriangulo
                {
                    LadoIgual = double.Parse(textBox1.Text),
                    Base = double.Parse(textBox4.Text)
                };

                t.Validar();

                textBox2.Text = t.CalcularArea().ToString("F2");
                textBox3.Text = t.CalcularPerimetro().ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingresa solo números válidos.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
