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
    public partial class trapecio : Form
    {
        public static trapecio instancia;
        public trapecio()
        {
            InitializeComponent();
        }

        public static trapecio ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new trapecio();
            }
            return instancia;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { } 
        private void textBox4_TextChanged(object sender, EventArgs e) { } 
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { } 
        private void textBox2_TextChanged(object sender, EventArgs e) { } 
        private void textBox3_TextChanged(object sender, EventArgs e) { } 

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (!double.TryParse(textBox1.Text, out double baseMayor) ||
                    !double.TryParse(textBox4.Text, out double baseMenor) ||
                    !double.TryParse(textBox5.Text, out double ladoIzquierdo) ||
                    !double.TryParse(textBox6.Text, out double ladoDerecho) ||
                    !double.TryParse(textBox7.Text, out double altura))
                {
                    MessageBox.Show("Por favor ingresa valores numéricos válidos para todos los lados y la altura.");
                    return;
                }

          
                CTrapecio trapecio = new CTrapecio
                {
                    BaseMayor = baseMayor,
                    BaseMenor = baseMenor,
                    Altura = altura,
                    LadoIzquierdo = ladoIzquierdo,
                    LadoDerecho = ladoDerecho
                };

                trapecio.Validar();

        
                double area = trapecio.CalcularArea();
                double perimetro = trapecio.CalcularPerimetro();

              
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
            textBox2.Clear(); 
            textBox3.Clear(); 
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
