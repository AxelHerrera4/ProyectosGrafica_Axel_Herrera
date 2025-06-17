using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void bresenhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 formBresenham = Form4.ObtenerInstancia();
            formBresenham.Show();
            formBresenham.BringToFront();
        }

        private void dDACToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 formDDA = new Form3();
            formDDA.Show();
            formDDA.BringToFront();
        }

        private void midPointCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formMidPoint = new Form1();
            formMidPoint.Show();
            formMidPoint.BringToFront();
        }

        private void fLooFillerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formFloodFiller = new Form1();
            formFloodFiller.Show();
            formFloodFiller.BringToFront();
        }
    }
}
