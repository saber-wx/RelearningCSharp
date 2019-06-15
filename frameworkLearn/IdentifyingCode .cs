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
    class IdentifyingCode
    {

        //private string[] arrChar = new string[] { "0", "1", "2", "3", "4", "5", "6", "7",
        //    "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N",
        //    "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" ,"a","a","b","c","d","e",
        //    "f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
        //生成随机数
        private static Random ran = new Random();
        //创建100内随机数
        private static int a = ran.Next(0, 100);
        private static int b = ran.Next(0, 100);
        //取得数组下标
        //private static int arrCharIndex = ran.Next(0, 62);



        //生成一张位图
        public static Bitmap BuildImage(int width, int height)
        {
            if (width > 250 || height > 150)
            {
                throw new Exception("长度不能超过250,高度不能超过150");
            }
            else
            {
                Bitmap image = new Bitmap(width, height);
                return image;
            }

        }

        //给位图背景上色
        public static Bitmap BackgroundColor(int width, int height)
        {
            try
            {
                //生成红绿蓝三原色随机RGB值
                int a = ran.Next(0, 255);
                int b = ran.Next(0, 255);
                int c = ran.Next(0, 255);
                Bitmap image = BuildImage(width, height);
                Graphics g = Graphics.FromImage(image);
                Color background = Color.FromArgb(a, b, c);
                if (background == Color.Black)
                {
                    throw new RrongColorException("背景颜色不能是黑色");
                }
                else
                {
                    g.Clear(background);
                    return image;
                }
            }
            catch (Exception e)
            {
                File.AppendAllText("D:\\17bang\\wx-验证码-error.log",
                    $"{DateTime.Now}：长度不能超过250,高度不能超过150" + e.ToString()+ Environment.NewLine);
                throw new InvalidCastException($"背景颜色不能是黑色", e);
            }
        }

        //给图片写加法表达式
        public static Bitmap Addition(int width, int height)
        {
            try
            {
                Bitmap image = BackgroundColor(width, height);
                Graphics g = Graphics.FromImage(image);
                //字体三原色
                int w1 = ran.Next(0, 255);
                int w2 = ran.Next(0, 255);
                int w3 = ran.Next(0, 255);
                SolidBrush solidBrush = new SolidBrush(Color.FromArgb(w1, w2, w3));
                g.DrawString(($"{a}+{b}="), new Font("黑体", 40), solidBrush, new PointF(5, 5));
                return image;
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        //给图片画线
        public static Bitmap DrawLine(int width, int height)
        {
            try
            {
                Bitmap image = Addition(width, height);
                Graphics g = Graphics.FromImage(image);
                for (int i = 0; i < 20; i++)
                {
                    int x1 = ran.Next(0, image.Width);
                    int x2 = ran.Next(0, image.Height);
                    int y1 = ran.Next(0, image.Width);
                    int y2 = ran.Next(0, image.Width);
                    int c1 = ran.Next(0, 255);
                    int c2 = ran.Next(0, 255);
                    int c3 = ran.Next(0, 255);
                    g.DrawLine(new Pen(Color.FromArgb(c1, c2, c3)), new Point(x1, x2), new Point(y1, y2));
                }

                return image;
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        //给图片加点
        public static Bitmap SpeckPoint(int width, int height)
        {
            try
            {
                Bitmap image = DrawLine(width, height);
                for (int i = 0; i < 1000; i++)
                {
                    int z1 = ran.Next(0, image.Width);
                    int z2 = ran.Next(0, image.Height);
                    int c1 = ran.Next(0, 255);
                    int c2 = ran.Next(0, 255);
                    int c3 = ran.Next(0, 255);
                    image.SetPixel(z1, z2, Color.FromArgb(c1, c2, c3));
                }

                return image;
            }
            catch (Exception e)
            {

                throw e;
            }
            
        }

        //将生成的图片保存
        public static Bitmap Image(int width, int height)
        {
            try
            {
                Bitmap image = SpeckPoint(width, height);
                image.Save(@"D:\17bang\IdentifyingCode.jpeg", ImageFormat.Jpeg);
                验证();
                return image;

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public static void 验证()
        {
            Console.WriteLine("请输入验证码结果");
            string input = Console.ReadLine();

            string sum = (a + b).ToString();
            while (true)
            {
                if (sum == input)
                {
                    Console.WriteLine("验证通过!");
                    break;
                }
                else
                {
                    Console.WriteLine("结果错误,请重新输入结果");
                    input = Console.ReadLine();
                }
            }
        }

        //public static void getIdentifyingCode()
        //{
        //    Bitmap image = new Bitmap(200, 100);
        //    Graphics g = Graphics.FromImage(image);
        //    g.Clear(Color.Black);

        //    Random ran = new Random();
        //    //创建100内随机数
        //    int a = ran.Next(0, 100);
        //    int b = ran.Next(0, 100);
        //    int w1 = ran.Next(0, 255);
        //    int w2 = ran.Next(0, 255);
        //    int w3 = ran.Next(0, 255);

        //    g.DrawString(($"{a}+{b}="), new Font("黑体", 40), new SolidBrush(Color.FromArgb(w1, w2, w3)), new PointF(5, 5));

        //    for (int i = 0; i < 20; i++)
        //    {
        //        int x1 = ran.Next(0, 200);
        //        int x2 = ran.Next(0, 100);
        //        int y1 = ran.Next(0, 200);
        //        int y2 = ran.Next(0, 100);
        //        int c1 = ran.Next(0, 255);
        //        int c2 = ran.Next(0, 255);
        //        int c3 = ran.Next(0, 255);
        //        g.DrawLine(new Pen(Color.FromArgb(c1, c2, c3)), new Point(x1, x2), new Point(y1, y2));
        //    }
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        int z1 = ran.Next(0, 200);
        //        int z2 = ran.Next(0, 100);
        //        int c1 = ran.Next(0, 255);
        //        int c2 = ran.Next(0, 255);
        //        int c3 = ran.Next(0, 255);
        //        image.SetPixel(z1, z2, Color.FromArgb(c1, c2, c3));
        //    }

        //    image.Save(@"D:\17bang\hello.jpeg", ImageFormat.Jpeg);

        //    Console.WriteLine("请输入验证码结果");
        //    string input = Console.ReadLine();

        //    string sum = (a + b).ToString();
        //    while (true)
        //    {
        //        if (sum == input)
        //        {
        //            Console.WriteLine("验证通过!");
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("结果错误,请重新输入结果");
        //            input = Console.ReadLine();
        //        }

        //    }
        //}
    }

    class RrongColorException : Exception
    {
        private string 提示;
        public RrongColorException(string 提示)
        {
            this.提示 = 提示;
        }
    }
}
