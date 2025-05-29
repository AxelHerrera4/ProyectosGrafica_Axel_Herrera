using System;
using System.Windows.Forms;

namespace WindowsMediaPlayer.Services
{
    public class MarqueeManager
    {
        private Label lblTitulo;
        private Form parentForm;
        private Timer timerMarquee;

        public MarqueeManager(Label label, Form form)
        {
            lblTitulo = label;
            parentForm = form;

            timerMarquee = new Timer();
            timerMarquee.Interval = 50;
            timerMarquee.Tick += TimerMarquee_Tick;
        }

        public void IniciarMarquee(string texto)
        {
            lblTitulo.Text = texto;
            lblTitulo.Left = parentForm.Width;
            timerMarquee.Start();
        }

        public void DetenerMarquee()
        {
            timerMarquee.Stop();
        }

        private void TimerMarquee_Tick(object sender, EventArgs e)
        {
            lblTitulo.Left -= 2;
            if (lblTitulo.Right < 0)
                lblTitulo.Left = parentForm.Width;
        }

        public void Dispose()
        {
            timerMarquee?.Dispose();
        }
    }
}