namespace WindowsMediaPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPlay = new System.Windows.Forms.Button();
            this.Controles = new System.Windows.Forms.GroupBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.trackVol = new System.Windows.Forms.TrackBar();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbVisualizaciones = new System.Windows.Forms.ComboBox();
            this.btnCargarCanciones = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerTitulo = new System.Windows.Forms.Timer(this.components);
            this.trackProgress = new System.Windows.Forms.TrackBar();
            this.timerProgreso = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelViz = new System.Windows.Forms.Panel();
            this.Controles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVol)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPlay.Location = new System.Drawing.Point(24, 31);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(48, 37);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Controles
            // 
            this.Controles.Controls.Add(this.btnPrevious);
            this.Controles.Controls.Add(this.btnNext);
            this.Controles.Controls.Add(this.trackVol);
            this.Controles.Controls.Add(this.btnPause);
            this.Controles.Controls.Add(this.btnStop);
            this.Controles.Controls.Add(this.btnPlay);
            this.Controles.Location = new System.Drawing.Point(9, 437);
            this.Controles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Controles.Name = "Controles";
            this.Controles.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Controles.Size = new System.Drawing.Size(582, 81);
            this.Controles.TabIndex = 1;
            this.Controles.TabStop = false;
            this.Controles.Text = "Controles";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.LightBlue;
            this.btnPrevious.Location = new System.Drawing.Point(277, 31);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(56, 27);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNext.Location = new System.Drawing.Point(217, 30);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(56, 28);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // trackVol
            // 
            this.trackVol.Location = new System.Drawing.Point(367, 31);
            this.trackVol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackVol.Maximum = 100;
            this.trackVol.Name = "trackVol";
            this.trackVol.Size = new System.Drawing.Size(211, 45);
            this.trackVol.TabIndex = 4;
            this.trackVol.Scroll += new System.EventHandler(this.trackVol_Scroll);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPause.Location = new System.Drawing.Point(76, 30);
            this.btnPause.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(66, 37);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStop.Location = new System.Drawing.Point(146, 31);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(46, 37);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(247, 15);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(100, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Titulo de la cancion";
            this.lblTitulo.Click += new System.EventHandler(this.lbltitulo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbVisualizaciones);
            this.groupBox2.Controls.Add(this.btnCargarCanciones);
            this.groupBox2.Controls.Add(this.lblTitulo);
            this.groupBox2.Location = new System.Drawing.Point(9, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(582, 90);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reproduciendo:";
            // 
            // cmbVisualizaciones
            // 
            this.cmbVisualizaciones.FormattingEnabled = true;
            this.cmbVisualizaciones.Location = new System.Drawing.Point(441, 62);
            this.cmbVisualizaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbVisualizaciones.Name = "cmbVisualizaciones";
            this.cmbVisualizaciones.Size = new System.Drawing.Size(137, 21);
            this.cmbVisualizaciones.TabIndex = 4;
            this.cmbVisualizaciones.SelectedIndexChanged += new System.EventHandler(this.cmbVisualizaciones_SelectedIndexChanged);
            // 
            // btnCargarCanciones
            // 
            this.btnCargarCanciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCargarCanciones.Location = new System.Drawing.Point(36, 57);
            this.btnCargarCanciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCargarCanciones.Name = "btnCargarCanciones";
            this.btnCargarCanciones.Size = new System.Drawing.Size(104, 28);
            this.btnCargarCanciones.TabIndex = 3;
            this.btnCargarCanciones.Text = "cargar canciones";
            this.btnCargarCanciones.UseVisualStyleBackColor = false;
            this.btnCargarCanciones.Click += new System.EventHandler(this.btnCargarCanciones_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timerTitulo
            // 
            this.timerTitulo.Interval = 50;
            this.timerTitulo.Tick += new System.EventHandler(this.timerTitulo_Tick);
            // 
            // trackProgress
            // 
            this.trackProgress.Location = new System.Drawing.Point(9, 387);
            this.trackProgress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackProgress.Maximum = 100;
            this.trackProgress.Name = "trackProgress";
            this.trackProgress.Size = new System.Drawing.Size(582, 45);
            this.trackProgress.TabIndex = 5;
            this.trackProgress.Scroll += new System.EventHandler(this.trackProgress_Scroll);
            this.trackProgress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackProgress_MouseDown);
            // 
            // timerProgreso
            // 
            this.timerProgreso.Interval = 1000;
            this.timerProgreso.Tick += new System.EventHandler(this.timerProgreso_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "*.mp3;*.wav\nArchivos MP3 (*.mp3)|*.mp3\nArchivos WAV (*.wav)|*.wav\nTodos los archi" +
    "vos (*.*)|*.*";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panelViz
            // 
            this.panelViz.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelViz.Location = new System.Drawing.Point(9, 98);
            this.panelViz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelViz.Name = "panelViz";
            this.panelViz.Size = new System.Drawing.Size(586, 284);
            this.panelViz.TabIndex = 7;
            this.panelViz.Paint += new System.Windows.Forms.PaintEventHandler(this.panelViz_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 528);
            this.Controls.Add(this.panelViz);
            this.Controls.Add(this.trackProgress);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Controles);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controles.ResumeLayout(false);
            this.Controles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVol)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox Controles;
        private System.Windows.Forms.TrackBar trackVol;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerTitulo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TrackBar trackProgress;
        private System.Windows.Forms.Timer timerProgreso;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelViz;
        private System.Windows.Forms.Button btnCargarCanciones;
        private System.Windows.Forms.ComboBox cmbVisualizaciones;
    }
}

