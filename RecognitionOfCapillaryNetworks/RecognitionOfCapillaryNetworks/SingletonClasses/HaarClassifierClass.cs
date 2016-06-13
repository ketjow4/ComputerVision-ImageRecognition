using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;

namespace RecognitionOfCapillaryNetworks.SingletonClasses
{
    public class HaarClassifierClass
    {
        private static HaarClassifierClass instance;

        private CascadeClassifier classifier;

        private string classifierPath = @"..\..\..\HaarClassifiers\NauczoneDoTestu.xml";

        private HaarClassifierClass()
        {
            classifier = new CascadeClassifier(classifierPath);
        }

        /// <summary>
        /// Wykrywa obiekty na podanym zdjęciu, na podstawie wczesniej zdefiniowanego klasyfikatora
        /// </summary>
        /// <param name="imageToProcess">Zdjecie na ktorym maja byc znalezione obiekty</param>
        /// <param name="numberOfDetection">Liczba wykrytych obiektów</param>
        /// <returns>Zdjęcie z zaznaczonymi wykrytymi obiektami</returns>
        public Image<Bgr, Byte> DetectUsingCurrendClassifier(Bitmap imageToProcess, out int numberOfDetection)
        {
            numberOfDetection = 0;
            Image<Bgr, Byte> img = new Image<Bgr, Byte>(imageToProcess);
            Image<Gray, byte> grayImage = img[1];

            
            var a = grayImage.Clone();
            Image<Gray, Byte> c = a.Convert<Byte>(delegate (Byte b) { return (Byte)(0); });

            //var detections = classifier.DetectMultiScale(grayImage, 1.05, 3, new Size(5, 5), new Size(grayImage.Width, grayImage.Height));
            var detections = classifier.DetectMultiScale(grayImage, 1.05, 1, new Size(12, 12), new Size(240, 240));

            foreach (var detect in detections)
            {
                grayImage.ROI = detect;
                var roi = grayImage.Clone();
                //roi.ThresholdBinaryInv(new Gray(100), new Gray(255));        TODO: FIX THIS
                img.Draw(detect, new Bgr(Color.FromArgb(255, 0, 0)), 5);
                numberOfDetection++;
                c.ROI = detect;
                roi.CopyTo(c);
            }
     
            c.ROI = Rectangle.Empty;
        #if DEBUG
            Emgu.CV.CvInvoke.Imshow("dsadsa", c);      
            CvInvoke.WaitKey(2);
        #endif
            return img;
        }

        /// <summary>
        /// Zmienia aktualny klasyfikator na ten, który podany jest w propercji 'ClassifierPath'
        /// </summary>
        public void ChangeCurrentClassifier()
        {
            classifier = new CascadeClassifier(classifierPath);
        }

        public static HaarClassifierClass Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new HaarClassifierClass();
                }
                return instance;
            }
        }

        public string ClassifierPath
        {
            get
            {
                return classifierPath;
            }

            set
            {
                classifierPath = value;
            }
        }
    }
}
