using frameworkLearn.CAPTCHA;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frameworkLearn
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Map a = new Map(200,100) ;
            IdentifyingCode.Image(200, 100);
            IdentifyingCode.验证();
            Console.Read();
        }
    }


}
