
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
            this.LblActual = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblTotal = new System.Windows.Forms.Label();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.macTrackBarMusic = new XComponent.SliderBar.MACTrackBar();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnSonido = new System.Windows.Forms.Button();
            this.macTrackBar1 = new XComponent.SliderBar.MACTrackBar();
            this.BtnSilencio = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnPause = new System.Windows.Forms.Button();
            this.BtnPlayOrPause = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblCancionesOnline = new System.Windows.Forms.Label();
            this.ListCancionesOnline = new System.Windows.Forms.ListBox();
            this.BtnOnline = new System.Windows.Forms.Button();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panelPlayer.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(200, 0);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(734, 495);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // LblActual
            // 
            this.LblActual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblActual.AutoSize = true;
            this.LblActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.LblActual.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblActual.ForeColor = System.Drawing.Color.Silver;
            this.LblActual.Location = new System.Drawing.Point(48, 26);
            this.LblActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblActual.Name = "LblActual";
            this.LblActual.Size = new System.Drawing.Size(40, 16);
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
            this.LblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.LblTotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.Silver;
            this.LblTotal.Location = new System.Drawing.Point(53, 26);
            this.LblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(40, 16);
            this.LblTotal.TabIndex = 10;
            this.LblTotal.Text = "00:00";
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panelPlayer.Controls.Add(this.panel5);
            this.panelPlayer.Controls.Add(this.panel4);
            this.panelPlayer.Controls.Add(this.panel3);
            this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlayer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelPlayer.Location = new System.Drawing.Point(0, 495);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(934, 66);
            this.panelPlayer.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(177, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(611, 66);
            this.panel5.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel8.Controls.Add(this.macTrackBarMusic);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(140, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(331, 66);
            this.panel8.TabIndex = 2;
            // 
            // macTrackBarMusic
            // 
            this.macTrackBarMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.macTrackBarMusic.BackColor = System.Drawing.Color.Transparent;
            this.macTrackBarMusic.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.macTrackBarMusic.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBarMusic.ForeColor = System.Drawing.Color.Gray;
            this.macTrackBarMusic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.macTrackBarMusic.IndentHeight = 6;
            this.macTrackBarMusic.Location = new System.Drawing.Point(6, 20);
            this.macTrackBarMusic.Maximum = 100;
            this.macTrackBarMusic.Minimum = 0;
            this.macTrackBarMusic.Name = "macTrackBarMusic";
            this.macTrackBarMusic.Size = new System.Drawing.Size(319, 33);
            this.macTrackBarMusic.TabIndex = 13;
            this.macTrackBarMusic.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBarMusic.TickColor = System.Drawing.Color.Transparent;
            this.macTrackBarMusic.TickHeight = 4;
            this.macTrackBarMusic.TrackerColor = System.Drawing.Color.Transparent;
            this.macTrackBarMusic.TrackerSize = new System.Drawing.Size(16, 16);
            this.macTrackBarMusic.TrackLineColor = System.Drawing.Color.WhiteSmoke;
            this.macTrackBarMusic.TrackLineHeight = 3;
            this.macTrackBarMusic.TrackLineSelectedColor = System.Drawing.Color.Silver;
            this.macTrackBarMusic.Value = 0;
            this.macTrackBarMusic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.macTrackBarMusic_MouseDown);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel7.Controls.Add(this.LblTotal);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(471, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(140, 66);
            this.panel7.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel6.Controls.Add(this.LblActual);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(140, 66);
            this.panel6.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnSonido);
            this.panel4.Controls.Add(this.macTrackBar1);
            this.panel4.Controls.Add(this.BtnSilencio);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(788, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(146, 66);
            this.panel4.TabIndex = 2;
            // 
            // BtnSonido
            // 
            this.BtnSonido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSonido.BackgroundImage = global::MediaPlayer.Properties.Resources.icons8_sound_64;
            this.BtnSonido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSonido.FlatAppearance.BorderSize = 0;
            this.BtnSonido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSonido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSonido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSonido.ForeColor = System.Drawing.Color.Silver;
            this.BtnSonido.Location = new System.Drawing.Point(8, 24);
            this.BtnSonido.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSonido.Name = "BtnSonido";
            this.BtnSonido.Size = new System.Drawing.Size(23, 23);
            this.BtnSonido.TabIndex = 12;
            this.BtnSonido.UseVisualStyleBackColor = true;
            this.BtnSonido.Click += new System.EventHandler(this.BtnSonido_Click);
            // 
            // macTrackBar1
            // 
            this.macTrackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.macTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.macTrackBar1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackBar1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.macTrackBar1.IndentHeight = 6;
            this.macTrackBar1.Location = new System.Drawing.Point(38, 20);
            this.macTrackBar1.Maximum = 100;
            this.macTrackBar1.Minimum = 0;
            this.macTrackBar1.Name = "macTrackBar1";
            this.macTrackBar1.Size = new System.Drawing.Size(96, 33);
            this.macTrackBar1.TabIndex = 12;
            this.macTrackBar1.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBar1.TickColor = System.Drawing.Color.Transparent;
            this.macTrackBar1.TickHeight = 4;
            this.macTrackBar1.TrackerColor = System.Drawing.Color.White;
            this.macTrackBar1.TrackerSize = new System.Drawing.Size(16, 16);
            this.macTrackBar1.TrackLineColor = System.Drawing.Color.WhiteSmoke;
            this.macTrackBar1.TrackLineHeight = 3;
            this.macTrackBar1.TrackLineSelectedColor = System.Drawing.Color.Silver;
            this.macTrackBar1.Value = 100;
            this.macTrackBar1.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBar1_ValueChanged);
            // 
            // BtnSilencio
            // 
            this.BtnSilencio.BackgroundImage = global::MediaPlayer.Properties.Resources.icons8_sound_64__1_;
            this.BtnSilencio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSilencio.FlatAppearance.BorderSize = 0;
            this.BtnSilencio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSilencio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSilencio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSilencio.ForeColor = System.Drawing.Color.Silver;
            this.BtnSilencio.Location = new System.Drawing.Point(8, 24);
            this.BtnSilencio.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSilencio.Name = "BtnSilencio";
            this.BtnSilencio.Size = new System.Drawing.Size(23, 23);
            this.BtnSilencio.TabIndex = 13;
            this.BtnSilencio.UseVisualStyleBackColor = true;
            this.BtnSilencio.Visible = false;
            this.BtnSilencio.Click += new System.EventHandler(this.BtnSilencio_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnPause);
            this.panel3.Controls.Add(this.BtnPlayOrPause);
            this.panel3.Controls.Add(this.BtnBack);
            this.panel3.Controls.Add(this.BtnNext);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(177, 66);
            this.panel3.TabIndex = 14;
            // 
            // BtnPause
            // 
            this.BtnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPause.BackgroundImage = global::MediaPlayer.Properties.Resources.icons8_pausa_en_círculo_24;
            this.BtnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPause.Enabled = false;
            this.BtnPause.FlatAppearance.BorderSize = 0;
            this.BtnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPause.ForeColor = System.Drawing.Color.Silver;
            this.BtnPause.Location = new System.Drawing.Point(77, 24);
            this.BtnPause.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(23, 23);
            this.BtnPause.TabIndex = 11;
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Visible = false;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // BtnPlayOrPause
            // 
            this.BtnPlayOrPause.BackgroundImage = global::MediaPlayer.Properties.Resources.icons8_reproducir_en_círculo_24;
            this.BtnPlayOrPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPlayOrPause.Enabled = false;
            this.BtnPlayOrPause.FlatAppearance.BorderSize = 0;
            this.BtnPlayOrPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnPlayOrPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnPlayOrPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayOrPause.ForeColor = System.Drawing.Color.Silver;
            this.BtnPlayOrPause.Location = new System.Drawing.Point(77, 24);
            this.BtnPlayOrPause.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlayOrPause.Name = "BtnPlayOrPause";
            this.BtnPlayOrPause.Size = new System.Drawing.Size(23, 23);
            this.BtnPlayOrPause.TabIndex = 2;
            this.BtnPlayOrPause.UseVisualStyleBackColor = true;
            this.BtnPlayOrPause.Click += new System.EventHandler(this.BtnPlayOrPause_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBack.BackgroundImage = global::MediaPlayer.Properties.Resources.icons8_reproducir_10_24;
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.ForeColor = System.Drawing.Color.Silver;
            this.BtnBack.Location = new System.Drawing.Point(28, 24);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(23, 23);
            this.BtnBack.TabIndex = 3;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNext.BackgroundImage = global::MediaPlayer.Properties.Resources.icons8_adelante_10_24;
            this.BtnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNext.FlatAppearance.BorderSize = 0;
            this.BtnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.ForeColor = System.Drawing.Color.Silver;
            this.BtnNext.Location = new System.Drawing.Point(124, 24);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(23, 23);
            this.BtnNext.TabIndex = 4;
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.LblCancionesOnline);
            this.panel1.Controls.Add(this.ListCancionesOnline);
            this.panel1.Controls.Add(this.BtnOnline);
            this.panel1.Controls.Add(this.BtnAbrir);
            this.panel1.Controls.Add(this.BtnInicio);
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 495);
            this.panel1.TabIndex = 12;
            // 
            // LblCancionesOnline
            // 
            this.LblCancionesOnline.AutoSize = true;
            this.LblCancionesOnline.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCancionesOnline.ForeColor = System.Drawing.SystemColors.Control;
            this.LblCancionesOnline.Location = new System.Drawing.Point(12, 131);
            this.LblCancionesOnline.Name = "LblCancionesOnline";
            this.LblCancionesOnline.Size = new System.Drawing.Size(120, 16);
            this.LblCancionesOnline.TabIndex = 18;
            this.LblCancionesOnline.Text = "Canciones Online";
            this.LblCancionesOnline.Visible = false;
            // 
            // ListCancionesOnline
            // 
            this.ListCancionesOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.ListCancionesOnline.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListCancionesOnline.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListCancionesOnline.ForeColor = System.Drawing.Color.Silver;
            this.ListCancionesOnline.FormattingEnabled = true;
            this.ListCancionesOnline.ItemHeight = 16;
            this.ListCancionesOnline.Location = new System.Drawing.Point(12, 150);
            this.ListCancionesOnline.Name = "ListCancionesOnline";
            this.ListCancionesOnline.Size = new System.Drawing.Size(168, 288);
            this.ListCancionesOnline.TabIndex = 17;
            this.ListCancionesOnline.Visible = false;
            // 
            // BtnOnline
            // 
            this.BtnOnline.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOnline.FlatAppearance.BorderSize = 0;
            this.BtnOnline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.BtnOnline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.BtnOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOnline.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOnline.ForeColor = System.Drawing.Color.Silver;
            this.BtnOnline.Location = new System.Drawing.Point(0, 90);
            this.BtnOnline.Name = "BtnOnline";
            this.BtnOnline.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnOnline.Size = new System.Drawing.Size(200, 45);
            this.BtnOnline.TabIndex = 15;
            this.BtnOnline.Text = "Online";
            this.BtnOnline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOnline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOnline.UseVisualStyleBackColor = true;
            this.BtnOnline.Click += new System.EventHandler(this.BtnOnline_Click);
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAbrir.FlatAppearance.BorderSize = 0;
            this.BtnAbrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.BtnAbrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.BtnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrir.ForeColor = System.Drawing.Color.Silver;
            this.BtnAbrir.Location = new System.Drawing.Point(0, 45);
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
            // BtnInicio
            // 
            this.BtnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.BtnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.Color.Silver;
            this.BtnInicio.Location = new System.Drawing.Point(0, 0);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnInicio.Size = new System.Drawing.Size(200, 45);
            this.BtnInicio.TabIndex = 16;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInicio.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.Silver;
            this.BtnSalir.Location = new System.Drawing.Point(0, 450);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPlayer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panelPlayer.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button BtnPlayOrPause;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnNext;
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
        private System.Windows.Forms.ListBox ListCancionesOnline;
        private XComponent.SliderBar.MACTrackBar macTrackBarMusic;
        private System.Windows.Forms.Label LblCancionesOnline;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button BtnSilencio;
        private System.Windows.Forms.Button BtnSonido;
    }
}

