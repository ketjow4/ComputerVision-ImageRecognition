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
        public static QualityResult ComputeQualityOfImages(Image<Bgr, Byte> patternImage, Image<Bgr, Byte> computedImage)
        {
            var result = new QualityResult();

            return result;
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
