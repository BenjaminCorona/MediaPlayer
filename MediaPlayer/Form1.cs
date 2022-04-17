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

        //arrelgos para cargar archivos
        string[] ArchivosMp3;
        string[] rutasArchivosMP3;


        public Form1()
        {
            InitializeComponent();

            //Cargamos las canciones online
            Canciones ReturnCanciones = new Canciones();
            int n = 0;
            for (n = 0; n <= 7; n++)
            {
                ListCancionesOnline.Items.Add(ReturnCanciones.Songs(n));
            }

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

            //Hacemos responsive los controladores
            macTrackBarMusic.Location = new Point((panel8.Width - macTrackBarMusic.Width) / 2, macTrackBarMusic.Location.Y);
            LblActual.Location = new Point((panel6.Width - LblActual.Width) / 2, LblActual.Location.Y);
            LblTotal.Location = new Point((panel7.Width - LblTotal.Width) / 2, LblTotal.Location.Y);


        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
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

        private void macTrackBarMusic_MouseDown(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = Convert.ToInt32(macTrackBarMusic.Value);
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            if (LblCancionesLocales.Visible == false)
            {
                LblCancionesLocales.Visible = true;
                ListBLocal.Visible = true;
            }
            else
            {
                LblCancionesLocales.Visible = false;
                ListBLocal.Visible = false;
            }

            /*-------------------------------------FUNCION PARA CARGAR UNA CARPETA COMPLETA---------------------------------------*/
            OpenFileDialog OpenFiles = new OpenFileDialog();
            OpenFiles.Multiselect = true;
            if (OpenFiles.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ArchivosMp3 = OpenFiles.SafeFileNames;
                rutasArchivosMP3 = OpenFiles.FileNames;

                foreach (var ArchMP3 in ArchivosMp3)
                {
                    ListBLocal.Items.Add(ArchMP3);
                }
                axWindowsMediaPlayer1.URL = rutasArchivosMP3[0];
                ListBLocal.SelectedIndex = 0;
            }

            /*
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
            catch { }*/

        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 10;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition += 10;
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

        private void ListCancionesOnline_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedI = ListCancionesOnline.SelectedIndex;

            Canciones SongLink = new Canciones();
            ruta = SongLink.LinkSongs(selectedI);

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

        private void ListBLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = rutasArchivosMP3[ListBLocal.SelectedIndex];
            ruta = rutasArchivosMP3[ListBLocal.SelectedIndex];
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
    }
}
