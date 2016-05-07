using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WebCam_Capture;

namespace CsCAMLibrary
{
    public partial class testControl : UserControl
    {
        WebCam webcam = new WebCam();

        public testControl()
        {
            InitializeComponent();
        }


        private void testControl_Load(object sender, EventArgs e)
        { 
            //WebCam  webcam = new WebCam();
            //passing Image Control Element
            webcam.InitializeWebCam(ref imgVideo);
        
            //start webcam video playing
            webcam.Start();
                        
            //webcam.Stop();//stop or pause video playing
                       
            //webcam.continue();//continue playing after stop state

            timer1.Interval = 200;
            timer1.Start();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            webcam.ResolutionSetting();
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            webcam.AdvanceSetting();
        }

        public event EventHandler newBarCode;
        public string barCode; 

        private void timer1_Tick(object sender, EventArgs e)
        {
            string code = XZingDecode.decode(imgVideo.Image);

            if (code != "" && code != textBox1.Text)
            {
                barCode = code;
                textBox1.Text = code;
                Console.Beep();
                newBarCode(this, e);
            }
                
        }


        public event EventHandler ButtonClick;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Test...OK!";
            ButtonClick(this, e);
        }

    }
}
