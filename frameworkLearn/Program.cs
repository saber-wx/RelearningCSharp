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
            try
            {
                IdentifyingCode.Image(200, 100);
            }
            catch (RrongColorException e)
            {
                File.AppendAllText("D:\\17bang\\wx-验证码-error.log",
                $"{DateTime.Now}：长度不能超过250,高度不能超过150" + e.ToString() + Environment.NewLine);
                Console.WriteLine("长度不能超过250,高度不能超过150");

            }
            catch (InvalidCastException e)
            {
                File.AppendAllText("D:\\17bang\\wx-验证码-error.log",
                $"{DateTime.Now}：长度不能超过250,高度不能超过150" + e.ToString() + Environment.NewLine);
                Console.WriteLine("背景颜色不能是黑色");
            }
           
            Console.Read();
        }
    }


}
