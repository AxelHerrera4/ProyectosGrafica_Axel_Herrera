namespace FigurasGeometricasDibujar
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
            this.romboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pentagonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romboToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.romboideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trapezoideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.romboToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // romboToolStripMenuItem
            // 
            this.romboToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pentagonoToolStripMenuItem,
            this.romboToolStripMenuItem1,
            this.romboideToolStripMenuItem,
            this.trapezoideToolStripMenuItem});
            this.romboToolStripMenuItem.Name = "romboToolStripMenuItem";
            this.romboToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.romboToolStripMenuItem.Text = "Figuras";
            // 
            // pentagonoToolStripMenuItem
            // 
            this.pentagonoToolStripMenuItem.Name = "pentagonoToolStripMenuItem";
            this.pentagonoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pentagonoToolStripMenuItem.Text = "Pentagono";
            this.pentagonoToolStripMenuItem.Click += new System.EventHandler(this.pentagonoToolStripMenuItem_Click);
            // 
            // romboToolStripMenuItem1
            // 
            this.romboToolStripMenuItem1.Name = "romboToolStripMenuItem1";
            this.romboToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.romboToolStripMenuItem1.Text = "Rombo";
            this.romboToolStripMenuItem1.Click += new System.EventHandler(this.romboToolStripMenuItem1_Click);
            // 
            // romboideToolStripMenuItem
            // 
            this.romboideToolStripMenuItem.Name = "romboideToolStripMenuItem";
            this.romboideToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.romboideToolStripMenuItem.Text = "Romboide";
            this.romboideToolStripMenuItem.Click += new System.EventHandler(this.romboideToolStripMenuItem_Click);
            // 
            // trapezoideToolStripMenuItem
            // 
            this.trapezoideToolStripMenuItem.Name = "trapezoideToolStripMenuItem";
            this.trapezoideToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.trapezoideToolStripMenuItem.Text = "Trapezoide";
            this.trapezoideToolStripMenuItem.Click += new System.EventHandler(this.trapezoideToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
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
        private System.Windows.Forms.ToolStripMenuItem romboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pentagonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romboToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem romboideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trapezoideToolStripMenuItem;
    }
}