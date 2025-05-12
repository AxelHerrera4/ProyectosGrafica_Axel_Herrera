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
    public partial class romboide : Form
    {
        public static romboide instancia;
        public romboide()
        {
            InitializeComponent();
        }

        public static romboide ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new romboide();
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
              
                if (!double.TryParse(textBox1.Text, out double baseRomboide) ||
                    !double.TryParse(textBox4.Text, out double altura) ||
                    !double.TryParse(textBox5.Text, out double lado))
                {
                    MessageBox.Show("Por favor ingresa valores numéricos válidos para base, altura y lado.");
                    return;
                }

            
                CRomboide romboide = new CRomboide
                {
                    Base = baseRomboide,
                    Altura = altura,
                    Lado = lado
                };

              
                romboide.Validar();

             
                double area = romboide.CalcularArea();
                double perimetro = romboide.CalcularPerimetro();

          
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
