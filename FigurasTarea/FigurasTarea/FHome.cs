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
    public partial class FHome : Form
    {
        public FHome()
        {
            InitializeComponent();
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circulo fcirculo = circulo.ObtenerInstancia();
            fcirculo.MdiParent = this;
            fcirculo.Show();
            fcirculo.BringToFront();
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuadrado fcirculo = cuadrado.ObtenerInstancia();
            fcirculo.MdiParent = this;
            fcirculo.Show();
            fcirculo.BringToFront();

        }

        private void decagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decagono fdecagono = decagono.ObtenerInstancia();
            fdecagono.MdiParent = this;
            fdecagono.Show();
            fdecagono.BringToFront();
        }

        private void deltoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deltoide fdeltoide = deltoide.ObtenerInstancia();
            fdeltoide.MdiParent = this;
            fdeltoide.Show();
            fdeltoide.BringToFront();
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            elipse felipse = elipse.ObtenerInstancia();
            felipse.MdiParent = this;
            felipse.Show();
            felipse.BringToFront();
        }

        private void eneagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eneagono feneagono = eneagono.ObtenerInstancia();
            feneagono.MdiParent = this;
            feneagono.Show();
            feneagono.BringToFront();
        }

        private void heptagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            heptagono fheptagono = heptagono.ObtenerInstancia();
            fheptagono.MdiParent = this;
            fheptagono.Show();
            fheptagono.BringToFront();
        }

        private void hexagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hexagono fhexagono = hexagono.ObtenerInstancia();
            fhexagono.MdiParent = this;
            fhexagono.Show();
            fhexagono.BringToFront();

        }

        private void octagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            octagono foctagono = octagono.ObtenerInstancia();
            foctagono.MdiParent = this;
            foctagono.Show();
            foctagono.BringToFront();

        }

        private void ovaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ovalo fovalo = ovalo.ObtenerInstancia();
            fovalo.MdiParent = this;
            fovalo.Show();
            fovalo.BringToFront();
        }

        private void pentagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pentagono fpentagono = pentagono.ObtenerInstancia();
            fpentagono.MdiParent = this;
            fpentagono.Show();
            fpentagono.BringToFront();

        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rectangulo frectangulo = rectangulo.ObtenerInstancia();
            frectangulo.MdiParent = this;
            frectangulo.Show();
            frectangulo.BringToFront();
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rombo frombo = rombo.ObtenerInstancia();
            frombo.MdiParent = this;
            frombo.Show();
            frombo.BringToFront();
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            romboide fromboide = romboide.ObtenerInstancia();
            fromboide.MdiParent = this;
            fromboide.Show();
            fromboide.BringToFront();
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trapecio ftrapecio = trapecio.ObtenerInstancia();
            ftrapecio.MdiParent = this;
            ftrapecio.Show();
            ftrapecio.BringToFront();
        }

        private void trapecioIsoselesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trapecioIso ftrapecioIso = trapecioIso.ObtenerInstancia();
            ftrapecioIso.MdiParent = this;
            ftrapecioIso.Show();
            ftrapecioIso.BringToFront();
        }

        private void trapezoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trapezoide ftrapezoide = trapezoide.ObtenerInstancia();
            ftrapezoide.MdiParent = this;
            ftrapezoide.Show();
            ftrapezoide.BringToFront();
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            triangulo ftriangulo = triangulo.ObtenerInstancia();
            ftriangulo.MdiParent = this;
            ftriangulo.Show();
            ftriangulo.BringToFront();
        }
    }
}
