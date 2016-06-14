using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace RecognitionOfCapillaryNetworks.SingletonClasses
{
    public class HaarClassifierClass
    {
        private static HaarClassifierClass instance;

        private CascadeClassifier classifier;

        private string classifierPath = @"..\..\..\HaarClassifiers\cascade.xml";

        private List<String> paths = new List<String>();

        private HaarClassifierClass()
        {
            var p = Directory.GetFiles(@".\HaarClassifiers", "*.xml");
            paths.AddRange(p);
            classifier = new CascadeClassifier(classifierPath);
        }

        /// <summary>
        /// Wykrywa obiekty na podanym zdjęciu, na podstawie wczesniej zdefiniowanego klasyfikatora
        /// </summary>
        /// <param name="imageToProcess">Zdjecie na ktorym maja byc znalezione obiekty</param>
        /// <param name="numberOfDetection">Liczba wykrytych obiektów</param>
        /// <returns>Zdjęcie z zaznaczonymi wykrytymi obiektami</returns>
        public Image<Bgr, Byte> DetectUsingCurrendClassifier(Bitmap imageToProcess, int scaleFactor, int minNeighbors, int maxNeighbors, int maxSize, bool noiseFiltere, out int numberOfDetection, out Image resultImage)
        {
            numberOfDetection = 0;
            Image<Bgr, Byte> img = new Image<Bgr, Byte>(imageToProcess);
            Image<Gray, byte> grayImage = img[1];

            var a = grayImage.Clone();
            Image<Gray, Byte> c = a.Convert<Byte>(delegate (Byte b) { return (Byte)(0); });

            for(int i = 0; i < paths.Count; i++ )
            {
                grayImage = img[1];
                grayImage.ROI = Rectangle.Empty;
                ClassifierPath = paths[i];


            var detections = classifier.DetectMultiScale(grayImage, 1.05, 1, new Size(12, 12), new Size(240, 240));

            foreach (var detect in detections)
            {
                grayImage.ROI = detect;
                var roi = grayImage.Clone();
                //img.Draw(detect, new Bgr(Color.FromArgb(255, 0, 0)), 5);
                numberOfDetection++;
                c.ROI = detect;
                roi = roi.Not();
                roi = roi.ThresholdAdaptive(new Gray(255), Emgu.CV.CvEnum.AdaptiveThresholdType.MeanC, Emgu.CV.CvEnum.ThresholdType.Binary, 21, new Gray(-1));
               
                //if filter
                roi._Erode(1);
                roi._Dilate(1);
                roi = roi.SmoothMedian(3);

                roi.CopyTo(c);
            }


            }
            c.ROI = Rectangle.Empty;
            resultImage = c.ToBitmap();
            img[0] = c;
            
            
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
                ChangeCurrentClassifier();
            }
        }
    }
}
