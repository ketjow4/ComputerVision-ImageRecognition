using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecognitionOfCapillaryNetworks.Managers
{
    /// <summary>
    /// Klasa odpowiadająca za wyliczanie parametrów jakościowych klasyfikowanego obrazu
    /// </summary>
    public class QualityManager
    {
        public static QualityResult ComputeQualityOfImages(Image<Gray, Byte> patternImageGray, Image<Gray, Byte> computedImageGray,decimal threshold)
        {
            var result = new QualityResult();
            if (patternImageGray.Size != computedImageGray.Size)
                throw new Exception("Różne rozmiary obrazów");
            var patternImage = ConvertToBW(patternImageGray, threshold);
            var computedImage = ConvertToBW(computedImageGray, threshold);
            for (int i = 0; i < patternImage.Size.Width; i++)
                for (int j = 0; j < patternImage.Size.Height; j++)
                {
                    var patternColor = patternImage.Data[j, i, 0];
                    var computedColor = computedImage.Data[j, i, 0];
                    if (computedColor == 255) //wykryto
                    {
                        if (patternColor == 255)//true positive
                            result.TruePositives++;
                        else//false positive
                            result.FalsePositives++;
                    }
                    else//nie wykryto
                    {
                        if (patternColor == 255)//false negative
                            result.FalseNegatives++;
                        else//true negatives
                            result.TrueNegatives++;
                    }                  
                }

            return result;
        }

        public static Image<Gray, Byte> ConvertToBW(Image<Gray, Byte> img, decimal threshold)
        {
            Image<Gray, Byte> newImg = new Image<Gray, byte>(img.Size);
            for (int i = 0; i < img.Size.Width; i++)
                for (int j = 0; j < img.Size.Height; j++)
                {
                    var color = img.Data[j, i, 0];
                    if (color < threshold) 
                    {
                        newImg.Data[j, i, 0] = 0;
                    }
                    else//nie wykryto
                    {
                        newImg.Data[j, i, 0] = 255;
                    }
                }
            return newImg;
        }
    }

    public class QualityResult
    {
        public int TruePositives { get; set; }

        public int TrueNegatives { get; set; }

        public int FalsePositives { get; set; }

        public int FalseNegatives { get; set; }

        public double Sensivity
        {
            get
            {
                return TruePositives / (double)(TruePositives + FalseNegatives);
            }
        }

        public double Specificity
        {
            get
            {
                return TrueNegatives / (double)(TrueNegatives + FalsePositives);
            }
        }
    }
}
