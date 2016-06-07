using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
//using AForge.Video.FFMPEG;
using System.Drawing.Drawing2D;
//using AForge.Video.VFW;
using System.IO;
//using System.Windows.Media.Imaging;
using System.Drawing.Imaging;
//using System.Windows.Threading;
using System.Threading;
//MIE
using WebCam_Capture;
using CsCAMLibrary;
using MySql.Data.MySqlClient;


namespace Frigo
{
    public partial class WebCamEl : UserControl
    {

        private FilterInfoCollection VideoCaptureDevices;
        private VideoCaptureDevice FinalVideo = null;
        //public VideoFileWriter writer = new VideoFileWriter();

        ConnessioneDB conn = new ConnessioneDB();
        string nomeFrigo;
        public WebCamEl(string nome)
        {
            InitializeComponent();

            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in VideoCaptureDevices)
            {
                comboBox1.Items.Add(VideoCaptureDevice.Name);
            }
            comboBox1.SelectedIndex = 0;

            nomeFrigo = nome;

            conn.ApriConnessione();
        }

        private void WebCamEl_Load(object sender, EventArgs e)
        {
            //clicco in modo automatico il bottone
            start.PerformClick();
            //avvio il timer
            timer1.Interval = 3000;
            timer1.Start();
        }

        void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
                cam.Image = bitmap;
            }
            catch
            {


            }
        }

        private void WebCam_Leave(object sender, EventArgs e)
        {
            if (FinalVideo != null) FinalVideo.Stop();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            //writer.Close();
            FinalVideo.Stop();
            //this.Close();
        }


        // public event EventHandler newBarCode;
        public string barCode;

        private void agg_Click(object sender, EventArgs e)
        {
            //Prodotto prod;

            string code = XZingDecode.decode(cam.Image);

            string[] token = code.Split(';');



            if (code != "" )
            {
                //prod = new Prodotto(token[1], token[0], token[2]);
                bool verifica = conn.aggiornaNeg(token[0], token[1], token[2], token[3], conn.selectID(nomeFrigo).ToString());

                if(verifica == true)
                {
                    //barCode = code;
                    codiceLetto.Text = token[1];
                    Console.Beep();
                }
                else
                {
                    codiceLetto.Text = "not Found";
                }


                //newBarCode(this, e);
                //string q = "DELETE FROM prodotto WHERE Barcode ='"+prod.getCodice()+"'";
                //conn.ExecuteQuery(q);
                //conn.ChiudiConnessione();

            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            //writer.Open(@"d:\\newVid.avi", 640, 480, 25, VideoCodec.MPEG4);

            FinalVideo = new VideoCaptureDevice(VideoCaptureDevices[comboBox1.SelectedIndex].MonikerString);
            FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
            FinalVideo.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Interval = 1000;
            agg.PerformClick(); 
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            stop.PerformClick();
            this.Visible = false;
        }

        private void elimina_Click(object sender, EventArgs e)
        {
            string eliminato = daEliminare.Text;
            daEliminare.Text = "";
            conn.EliminaManuale(eliminato,conn.selectID(nomeFrigo));
            Console.Beep();

        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Posiziona il codice a barre del tuo prodotto davanti alla Webcam, non toglierlo fino al 'beep' che ne indicherà l' avvenuta eliminazione, oppure inserisci il nome del prodotto da eliminare dove indicato", "Info", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
