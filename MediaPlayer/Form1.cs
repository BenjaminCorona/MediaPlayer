using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        private string ruta = "";
        private double total = 0;
        private double actual = 0;
        private string formato = "";

        public Form1()
        {
            InitializeComponent();
            //Para regresar a lo normal, modificar Application.EnableVisualStyles();

            //progressBar1.ForeColor = Color.Black;
            axWindowsMediaPlayer1.uiMode = "None";
            trackBar1.Value = 100;

            if (BtnPlayOrPause.Visible == true)
            {
                BtnPlayOrPause.Visible = false;//Cambio el imagen
                BtnPause.Visible = true;//Cambio el imagen

            }
            else //Es Pausa
            {
                BtnPlayOrPause.Visible = true;//Cambio el imagen
                BtnPause.Visible = false;//Cambio el imagen
            }


        }


        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
            axWindowsMediaPlayer1.settings.defaultFrame = "https://www.themoviedb.org/t/p/original/41yaWnIT8AjIHiULHtTbKNzZTjc.jpg";

        }

        private void BtnPlayOrPause_Click(object sender, EventArgs e)
        {

            if (BtnPlayOrPause.Visible == true)
            {
                timer1.Start();
                axWindowsMediaPlayer1.Ctlcontrols.play();
                BtnPlayOrPause.Visible = false;//Cambio el imagen
                BtnPause.Visible = true;//Cambio el imagen
            }
            else //Es Pausa
            {
                timer1.Stop();
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                BtnPlayOrPause.Visible = true;//Cambio el imagen
                BtnPause.Visible = false;//Cambio el imagen
            }
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            if (BtnPlayOrPause.Visible == true)
            {
                timer1.Start();
                axWindowsMediaPlayer1.Ctlcontrols.play();
                BtnPlayOrPause.Visible = false;//Cambio el imagen
                BtnPause.Visible = true;//Cambio el imagen
            }
            else //Es Pausa
            {
                timer1.Stop();
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                BtnPlayOrPause.Visible = true;//Cambio el imagen
                BtnPause.Visible = false;//Cambio el imagen
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                total = axWindowsMediaPlayer1.currentMedia.duration;
            }
            catch
            {
            }

            progressBar1.Maximum = Convert.ToInt32(total);

            if (total < 3600)
            {
                //formato = "00:";
            }

            LblTotal.Text = formato + axWindowsMediaPlayer1.currentMedia.durationString;
            actual = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

            if (actual < 3600)
            {
                //formato = "00:";
            }

            if (actual < total)
            {
                LblActual.Text = formato + axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                progressBar1.Value = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
            }

        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog cargar = new OpenFileDialog();

            cargar.InitialDirectory = "c:\\";
            cargar.Title = "Abrir archivo";
            cargar.DefaultExt = "jpg";
            cargar.Filter = "WAV (*.wav)|*.wav|MP4 (*.mp4)|*.mp4|MP3 (*.mp3)|*.mp3";
            cargar.FilterIndex = 4;
            cargar.RestoreDirectory = true;
            cargar.ShowDialog();
            //ruta = "https://file-examples.com/storage/fe31d99e526255e059c5846/2017/04/file_example_MP4_480_1_5MG.mp4";
            ruta = cargar.FileName;
            try
            {
                if (!(ruta == ""))
                {
                    axWindowsMediaPlayer1.URL = ruta;
                    BtnPlayOrPause.Enabled = true;
                    BtnBack.Enabled = true;
                    BtnNext.Enabled = true;
                    BtnPause.Enabled = true;
                    BtnPause.Visible = true;
                    BtnPlayOrPause.Visible = false;

                    timer1.Start();
                }
            }
            catch { }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
