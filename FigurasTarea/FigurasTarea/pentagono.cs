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
    public partial class pentagono : Form
    {
        public static pentagono instancia;
        public pentagono()
        {
            InitializeComponent();
        }
        public static pentagono ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new pentagono();
            }
            return instancia;
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
                if (!double.TryParse(textBox1.Text, out double lado))
                {
                    MessageBox.Show("Por favor ingresa un valor numérico válido para el lado.");
                    return;
                }

                CPentagono pentagono = new CPentagono
                {
                    Lado = lado
                };

                pentagono.Validar();

                double area = pentagono.CalcularArea();
                double perimetro = pentagono.CalcularPerimetro();

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
