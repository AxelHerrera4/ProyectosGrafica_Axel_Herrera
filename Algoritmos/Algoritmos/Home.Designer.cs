namespace Algoritmos
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bresenhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dDACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.midPointCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fLooFillerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bresenhamToolStripMenuItem,
            this.dDACToolStripMenuItem,
            this.midPointCircleToolStripMenuItem,
            this.fLooFillerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bresenhamToolStripMenuItem
            // 
            this.bresenhamToolStripMenuItem.Name = "bresenhamToolStripMenuItem";
            this.bresenhamToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.bresenhamToolStripMenuItem.Text = "Bresenham";
            this.bresenhamToolStripMenuItem.Click += new System.EventHandler(this.bresenhamToolStripMenuItem_Click);
            // 
            // dDACToolStripMenuItem
            // 
            this.dDACToolStripMenuItem.Name = "dDACToolStripMenuItem";
            this.dDACToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dDACToolStripMenuItem.Text = "DDAC";
            this.dDACToolStripMenuItem.Click += new System.EventHandler(this.dDACToolStripMenuItem_Click);
            // 
            // midPointCircleToolStripMenuItem
            // 
            this.midPointCircleToolStripMenuItem.Name = "midPointCircleToolStripMenuItem";
            this.midPointCircleToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.midPointCircleToolStripMenuItem.Text = "MidPointCircle";
            this.midPointCircleToolStripMenuItem.Click += new System.EventHandler(this.midPointCircleToolStripMenuItem_Click);
            // 
            // fLooFillerToolStripMenuItem
            // 
            this.fLooFillerToolStripMenuItem.Name = "fLooFillerToolStripMenuItem";
            this.fLooFillerToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.fLooFillerToolStripMenuItem.Text = "FLooFiller";
            this.fLooFillerToolStripMenuItem.Click += new System.EventHandler(this.fLooFillerToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bresenhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dDACToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem midPointCircleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fLooFillerToolStripMenuItem;
    }
}