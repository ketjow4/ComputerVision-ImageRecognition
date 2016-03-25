using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using RecognitionOfCapillaryNetworks.Forms;

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
            Application.Run(new GalleryViewer());

            //Mat img =  CvInvoke.Imread("lena.jpg", Emgu.CV.CvEnum.LoadImageType.AnyColor);
            //CvInvoke.Imshow("Window", img);
            //CvInvoke.WaitKey(0);  //Wait for the key pressing event
        }
    }
}
