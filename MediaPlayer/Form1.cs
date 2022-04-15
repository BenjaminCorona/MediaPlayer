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
            macTrackBar1.Value = 99;

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

            /*
            if (macTrackBar1.Value > 1)
            {
                BtnSonido.Visible = true;
                BtnSilencio.Visible = true;
            }
            else if (macTrackBar1.Value == 0)
            {
                BtnSilencio.Visible = true;
                BtnSonido.Visible = false;
            }
            */


            //Hacemos responsive los controladores
            macTrackBarMusic.Location = new Point((panel8.Width - macTrackBarMusic.Width) / 2, macTrackBarMusic.Location.Y);
            LblActual.Location = new Point((panel6.Width - LblActual.Width) / 2, LblActual.Location.Y);
            LblTotal.Location = new Point((panel7.Width - LblTotal.Width) / 2, LblTotal.Location.Y);


        }


        private void macTrackBar1_ValueChanged(object sender, decimal value)
        {

            axWindowsMediaPlayer1.settings.volume = macTrackBar1.Value;

            if (macTrackBar1.Value > 1)
            {
                BtnSonido.Visible = true;
                BtnSilencio.Visible = true;
            }
            else if (macTrackBar1.Value == 0)
            {
                BtnSilencio.Visible = true;
                BtnSonido.Visible = false;
            }
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

            macTrackBarMusic.Maximum = Convert.ToInt32(total);

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

            if (actual <= total)
            {
                LblActual.Text = formato + axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                macTrackBarMusic.Value = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
            }
            else
            {
                //macTrackBarMusic.Value = 0;
                LblTotal.Text = "00:00";
                LblActual.Text = "00:00";
                ruta = "";
                BtnPlayOrPause.Enabled = true;
                BtnBack.Enabled = true;
                BtnNext.Enabled = true;
                BtnPause.Enabled = true;
                timer1.Stop();
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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void macTrackBarMusic_MouseDown(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = Convert.ToInt32(macTrackBarMusic.Value);
        }

        private void BtnOnline_Click(object sender, EventArgs e)
        {
            if (LblCancionesOnline.Visible == false)
            {
                LblCancionesOnline.Visible = true;
                ListCancionesOnline.Visible = true;
            }
            else
            {
                LblCancionesOnline.Visible = false;
                ListCancionesOnline.Visible = false;
            }
        }

        private void BtnSonido_Click(object sender, EventArgs e)
        {
            BtnSonido.Visible = false;
            BtnSilencio.Visible = true;
            macTrackBar1.Value = 0;

        }

        private void BtnSilencio_Click(object sender, EventArgs e)
        {
            BtnSilencio.Visible = false;
            BtnSonido.Visible = true;
            macTrackBar1.Value = 100;

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            macTrackBarMusic.Location = new Point((panel8.Width - macTrackBarMusic.Width) / 2, macTrackBarMusic.Location.Y);
            LblActual.Location = new Point((panel6.Width - LblActual.Width) / 2, LblActual.Location.Y);
            LblTotal.Location = new Point((panel7.Width - LblTotal.Width) / 2, LblTotal.Location.Y);

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 10;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition += 10;
        }
    }
}
