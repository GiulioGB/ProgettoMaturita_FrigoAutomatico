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
using System.Windows.Media.Imaging;
using System.Drawing.Imaging;
using System.Windows.Threading;
using System.Threading;

namespace CCamFrigo
{
    public partial class WebCam : UserControl
    {
        private FilterInfoCollection VideoCaptureDevices;
        private VideoCaptureDevice FinalVideo=null;
        //public VideoFileWriter writer = new VideoFileWriter();

        public WebCam()
        {
            InitializeComponent();

            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in VideoCaptureDevices)
            {
                comboBox1.Items.Add(VideoCaptureDevice.Name);
            }
            comboBox1.SelectedIndex = 0;


        }

      

        private void WebCam_Load(object sender, EventArgs e)
        {

        } 
        void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
               Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone(); 
                pictureBox1.Image = bitmap;
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
    }
} 
