using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecognitionOfCapillaryNetworks.SingletonClasses
{
    public class HaarClassifierClass
    {
        private static HaarClassifierClass instance;

        private HaarClassifierClass() { }

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
    }
}
