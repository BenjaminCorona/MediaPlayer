
namespace MediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.BtnPlayOrPause = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LblActual = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblTotal = new System.Windows.Forms.Label();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.macTrackBar1 = new XComponent.SliderBar.MACTrackBar();
            this.BtnPause = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.BtnOnline = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.macTrackBarMusic = new XComponent.SliderBar.MACTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panelPlayer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(934, 561);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // BtnPlayOrPause
            // 
            this.BtnPlayOrPause.BackgroundImage = global::MediaPlayer.Properties.Resources.boton_de_play;
            this.BtnPlayOrPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPlayOrPause.Enabled = false;
            this.BtnPlayOrPause.FlatAppearance.BorderSize = 0;
            this.BtnPlayOrPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnPlayOrPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnPlayOrPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayOrPause.ForeColor = System.Drawing.Color.Silver;
            this.BtnPlayOrPause.Location = new System.Drawing.Point(80, 23);
            this.BtnPlayOrPause.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlayOrPause.Name = "BtnPlayOrPause";
            this.BtnPlayOrPause.Size = new System.Drawing.Size(30, 30);
            this.BtnPlayOrPause.TabIndex = 2;
            this.BtnPlayOrPause.UseVisualStyleBackColor = true;
            this.BtnPlayOrPause.Click += new System.EventHandler(this.BtnPlayOrPause_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackgroundImage = global::MediaPlayer.Properties.Resources.atras;
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBack.Enabled = false;
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.ForeColor = System.Drawing.Color.Silver;
            this.BtnBack.Location = new System.Drawing.Point(31, 23);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(30, 30);
            this.BtnBack.TabIndex = 3;
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // BtnNext
            // 
            this.BtnNext.BackgroundImage = global::MediaPlayer.Properties.Resources.proximo;
            this.BtnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNext.Enabled = false;
            this.BtnNext.FlatAppearance.BorderSize = 0;
            this.BtnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.ForeColor = System.Drawing.Color.Silver;
            this.BtnNext.Location = new System.Drawing.Point(127, 23);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(30, 30);
            this.BtnNext.TabIndex = 4;
            this.BtnNext.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.progressBar1.Location = new System.Drawing.Point(243, 44);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(448, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 5;
            // 
            // LblActual
            // 
            this.LblActual.AutoSize = true;
            this.LblActual.BackColor = System.Drawing.SystemColors.Control;
            this.LblActual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblActual.Location = new System.Drawing.Point(196, 38);
            this.LblActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblActual.Name = "LblActual";
            this.LblActual.Size = new System.Drawing.Size(39, 16);
            this.LblActual.TabIndex = 9;
            this.LblActual.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.LblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblTotal.Location = new System.Drawing.Point(699, 38);
            this.LblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(39, 16);
            this.LblTotal.TabIndex = 10;
            this.LblTotal.Text = "00:00";
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.SystemColors.Control;
            this.panelPlayer.Controls.Add(this.macTrackBarMusic);
            this.panelPlayer.Controls.Add(this.macTrackBar1);
            this.panelPlayer.Controls.Add(this.BtnPause);
            this.panelPlayer.Controls.Add(this.BtnNext);
            this.panelPlayer.Controls.Add(this.BtnBack);
            this.panelPlayer.Controls.Add(this.LblTotal);
            this.panelPlayer.Controls.Add(this.BtnPlayOrPause);
            this.panelPlayer.Controls.Add(this.LblActual);
            this.panelPlayer.Controls.Add(this.progressBar1);
            this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlayer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelPlayer.Location = new System.Drawing.Point(0, 489);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(934, 72);
            this.panelPlayer.TabIndex = 11;
            // 
            // macTrackBar1
            // 
            this.macTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.macTrackBar1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackBar1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.macTrackBar1.IndentHeight = 6;
            this.macTrackBar1.Location = new System.Drawing.Point(795, 27);
            this.macTrackBar1.Maximum = 100;
            this.macTrackBar1.Minimum = 0;
            this.macTrackBar1.Name = "macTrackBar1";
            this.macTrackBar1.Size = new System.Drawing.Size(127, 33);
            this.macTrackBar1.TabIndex = 12;
            this.macTrackBar1.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBar1.TickColor = System.Drawing.Color.Transparent;
            this.macTrackBar1.TickHeight = 4;
            this.macTrackBar1.TrackerColor = System.Drawing.Color.DimGray;
            this.macTrackBar1.TrackerSize = new System.Drawing.Size(16, 16);
            this.macTrackBar1.TrackLineColor = System.Drawing.Color.WhiteSmoke;
            this.macTrackBar1.TrackLineHeight = 3;
            this.macTrackBar1.TrackLineSelectedColor = System.Drawing.Color.Silver;
            this.macTrackBar1.Value = 100;
            this.macTrackBar1.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBar1_ValueChanged);
            // 
            // BtnPause
            // 
            this.BtnPause.BackgroundImage = global::MediaPlayer.Properties.Resources.boton_de_pausa;
            this.BtnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPause.Enabled = false;
            this.BtnPause.FlatAppearance.BorderSize = 0;
            this.BtnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPause.ForeColor = System.Drawing.Color.Silver;
            this.BtnPause.Location = new System.Drawing.Point(80, 23);
            this.BtnPause.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(30, 30);
            this.BtnPause.TabIndex = 11;
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Visible = false;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.BtnInicio);
            this.panel1.Controls.Add(this.BtnOnline);
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.BtnAbrir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 489);
            this.panel1.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(31, 220);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 17;
            // 
            // BtnInicio
            // 
            this.BtnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.BtnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.Color.Silver;
            this.BtnInicio.Location = new System.Drawing.Point(0, 90);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnInicio.Size = new System.Drawing.Size(200, 45);
            this.BtnInicio.TabIndex = 16;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInicio.UseVisualStyleBackColor = true;
            // 
            // BtnOnline
            // 
            this.BtnOnline.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOnline.FlatAppearance.BorderSize = 0;
            this.BtnOnline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.BtnOnline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BtnOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOnline.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOnline.ForeColor = System.Drawing.Color.Silver;
            this.BtnOnline.Location = new System.Drawing.Point(0, 45);
            this.BtnOnline.Name = "BtnOnline";
            this.BtnOnline.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnOnline.Size = new System.Drawing.Size(200, 45);
            this.BtnOnline.TabIndex = 15;
            this.BtnOnline.Text = "Online";
            this.BtnOnline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOnline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOnline.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.Silver;
            this.BtnSalir.Location = new System.Drawing.Point(0, 444);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnSalir.Size = new System.Drawing.Size(200, 45);
            this.BtnSalir.TabIndex = 14;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAbrir.FlatAppearance.BorderSize = 0;
            this.BtnAbrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.BtnAbrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BtnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrir.ForeColor = System.Drawing.Color.Silver;
            this.BtnAbrir.Location = new System.Drawing.Point(0, 0);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAbrir.Size = new System.Drawing.Size(200, 45);
            this.BtnAbrir.TabIndex = 13;
            this.BtnAbrir.Text = "Abrir multimedia";
            this.BtnAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAbrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // macTrackBarMusic
            // 
            this.macTrackBarMusic.BackColor = System.Drawing.Color.Transparent;
            this.macTrackBarMusic.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.macTrackBarMusic.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBarMusic.ForeColor = System.Drawing.Color.Gray;
            this.macTrackBarMusic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.macTrackBarMusic.IndentHeight = 6;
            this.macTrackBarMusic.Location = new System.Drawing.Point(242, 4);
            this.macTrackBarMusic.Maximum = 100;
            this.macTrackBarMusic.Minimum = 0;
            this.macTrackBarMusic.Name = "macTrackBarMusic";
            this.macTrackBarMusic.Size = new System.Drawing.Size(449, 33);
            this.macTrackBarMusic.TabIndex = 13;
            this.macTrackBarMusic.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBarMusic.TickColor = System.Drawing.Color.Transparent;
            this.macTrackBarMusic.TickHeight = 4;
            this.macTrackBarMusic.TrackerColor = System.Drawing.Color.DimGray;
            this.macTrackBarMusic.TrackerSize = new System.Drawing.Size(16, 16);
            this.macTrackBarMusic.TrackLineColor = System.Drawing.Color.WhiteSmoke;
            this.macTrackBarMusic.TrackLineHeight = 3;
            this.macTrackBarMusic.TrackLineSelectedColor = System.Drawing.Color.Silver;
            this.macTrackBarMusic.Value = 0;
            this.macTrackBarMusic.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBarMusic_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panelPlayer.ResumeLayout(false);
            this.panelPlayer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button BtnPlayOrPause;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label LblActual;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Button BtnOnline;
        private XComponent.SliderBar.MACTrackBar macTrackBar1;
        private System.Windows.Forms.ListBox listBox1;
        private XComponent.SliderBar.MACTrackBar macTrackBarMusic;
    }
}

