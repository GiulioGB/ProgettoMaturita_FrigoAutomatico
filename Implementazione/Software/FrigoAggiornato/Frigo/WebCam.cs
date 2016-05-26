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
    public partial class WebCam : UserControl
    {
        private FilterInfoCollection VideoCaptureDevices;
        private VideoCaptureDevice FinalVideo=null;
        //public VideoFileWriter writer = new VideoFileWriter();

        ConnessioneDB conn = new ConnessioneDB();
        string nomeFrigo;
        public WebCam(string nome)
        {
            InitializeComponent();

            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in VideoCaptureDevices)
            {
                comboBox1.Items.Add(VideoCaptureDevice.Name);
            }
            comboBox1.SelectedIndex = 0;

            conn.ApriConnessione();

            nomeFrigo = nome;
            
        }  

        private void WebCam_Load(object sender, EventArgs e)
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

        private void start_Click(object sender, EventArgs e)
        {
            //writer.Open(@"d:\\newVid.avi", 640, 480, 25, VideoCodec.MPEG4);

            FinalVideo = new VideoCaptureDevice(VideoCaptureDevices[comboBox1.SelectedIndex].MonikerString);
            FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
            FinalVideo.Start();
            

        }

        private void stop_Click(object sender, EventArgs e)
        {
            //writer.Close();
            FinalVideo.Stop();
            //this.Close();
        }

        private void WebCam_Leave(object sender, EventArgs e)
        {
            if (FinalVideo != null) FinalVideo.Stop();
        }

        

       // public event EventHandler newBarCode;
        public string barCode;
      

        private void agg_Click(object sender, EventArgs e)
        {
            Prodotto prod;
            
            string code = XZingDecode.decode(cam.Image);

            string[] token = code.Split(';');

            
            if (code != "")
            {
                conn.VerificaAlimento(token[1]);
                conn.aggiornaPos(token[0], token[1], token[2],token[3],conn.selectID(nomeFrigo).ToString());
                                
                //prod = new Prodotto(token[1], token[0], token[2]);
                barCode = code;
                codiceLetto.Text = code;
                Console.Beep();
                //newBarCode(this, e);
                //string q = "INSERT INTO prodotto (EAN,NomeAlimento,dataScadenza,luogoProduzione,Quantita,IDFrigo) values('" + token[0] + "','" + token[1] + "','" + token[2]+ "','" + token[3] + "','"+1+"','"+conn.selectID(nomeFrigo)+"');";
                //conn.ExecuteQuery(q);
                
                //conn.ChiudiConnessione();
            }
            

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Interval = 3000;
            agg.PerformClick(); 
                   
        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Posiziona il codice a barre del tuo prodotto davanti alla Webcam, non toglierlo fino al 'beep' che ne indicherà l' avvenuta lettura, oppure inserisci il nome del prodotto da aggiungere dove indicato", "Info", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            stop.PerformClick();
            this.Visible = false;
            
        }

        private void aggiungi_Click(object sender, EventArgs e)
        {
            string prod = daAggiungere.Text;
            daAggiungere.Text = "";
            conn.AggiuntaManuale(prod,conn.selectID(nomeFrigo));
            Console.Beep();
        }
    
        
    }
} 
