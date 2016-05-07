using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZXing;

namespace CsCAMLibrary
{
    public class XZingDecode
    {
        static public string decode(Image img)
        {
            string code = "";
            //MessageBox.Show("filename :"+filename);

            IBarcodeReader reader = new BarcodeReader();
            // load a bitmap
            var barcodeBitmap = (Bitmap)img;
            // detect and decode the barcode inside the bitmap
            var result = reader.Decode(barcodeBitmap);
            // do something with the result
            if (result != null)
            {
                //txtDecoderType.Text = result.BarcodeFormat.ToString();
                code = result.Text;
                //MessageBox.Show("code: " + code);
            }
            
            return code;
        }


        static public string decode(string filename)
        {
            string code = "";
            //MessageBox.Show("filename :"+filename);

            IBarcodeReader reader = new BarcodeReader();
            // load a bitmap
            var barcodeBitmap = (Bitmap)Bitmap.FromFile(filename);
            // detect and decode the barcode inside the bitmap
            var result = reader.Decode(barcodeBitmap);
            // do something with the result
            if (result != null)
            {
                //txtDecoderType.Text = result.BarcodeFormat.ToString();
                code = result.Text;
            }
            //MessageBox.Show("code: " + code);
            return code;
        }
    }
}
