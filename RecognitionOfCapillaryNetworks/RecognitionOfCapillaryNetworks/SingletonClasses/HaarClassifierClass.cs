﻿using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;

namespace RecognitionOfCapillaryNetworks.SingletonClasses
{
    public class HaarClassifierClass
    {
        private static HaarClassifierClass instance;

        private CascadeClassifier classifier;

        private string classifierPath = @"..\..\..\HaarClassifiers\haarcascade_frontalface_alt_tree.xml";

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
            Image<Gray, byte> grayImage = img.Convert<Gray, byte>();

            var detections = classifier.DetectMultiScale(grayImage, 1.05, 3, new Size(20, 20), new Size(grayImage.Width, grayImage.Height));

            foreach(var detect in detections)
            {
                img.Draw(detect, new Bgr(Color.FromArgb(255, 0, 0)), 5);
                numberOfDetection++;
            }

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
