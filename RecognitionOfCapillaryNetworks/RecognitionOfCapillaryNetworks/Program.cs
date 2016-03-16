using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace RecognitionOfCapillaryNetworks
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Mat img =  CvInvoke.Imread("lena.jpg", Emgu.CV.CvEnum.LoadImageType.AnyColor);
            CvInvoke.Imshow("Window", img);
            CvInvoke.WaitKey(0);  //Wait for the key pressing event
        }
    }
}
