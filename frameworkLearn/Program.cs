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
            //Random ran = new Random();
            //while (true) {
            //    int oper = ran.Next(1, 3);
            //    Console.WriteLine(oper);
            //}

            Captcha a = new Captcha(200, 100);
            a.Get();
            //a.Confirmation();
            Console.Read();
        }
    }


}
