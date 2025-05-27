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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pentagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fpentagono = Form1.ObtenerInstancia();
            fpentagono.MdiParent = this;
            fpentagono.Show();
            fpentagono.BringToFront();
        }

        private void romboToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 frombo = Form2.ObtenerInstancia();
            frombo.MdiParent = this;
            frombo.BringToFront();
            frombo.Show();
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fromboide = Form3.ObtenerInstancia();
            fromboide.MdiParent = this;
            fromboide.BringToFront();
            fromboide.Show();
        }

        private void trapezoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 ftrapezoide = Form4.ObtenerInstancia();
            ftrapezoide.MdiParent = this;
            ftrapezoide.BringToFront();
            ftrapezoide.Show();
        }
    }
}
