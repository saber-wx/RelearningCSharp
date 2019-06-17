using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frameworkLearn.CAPTCHA
{
    class Map
    {
        //生成随机数对象
        private static Random ran = new Random();
        
        public Bitmap image { get; }

        //生成图片构造方法
        public Map(int width, int height)
        {
            image = new Bitmap(width, height);
        }

        //获得验证码图片
        public Bitmap Get()
        {
            BackgroundColor();
            Content();
            DrawLine();
            SpeckPoint();
            return image;
        }

        //保存验证码方法
        private void SaveImage()
        {
            image.Save(@"D:\17bang\IdentifyingCode.jpeg", ImageFormat.Jpeg);
        }

        //画点
        private void SpeckPoint()
        {
            RandomColor a = new RandomColor();

        }

        //画线
        private void DrawLine()
        {
            RandomColor BackgroundColor = new RandomColor();
            Color LineColor = BackgroundColor.BackgroundColor;

        }

        //生成验证码内容
        private void Content()
        {
            throw new NotImplementedException();
        }

        //给背景上色
        private void BackgroundColor()
        {
            RandomColor BackgroundColor = new RandomColor();
            Graphics g = Graphics.FromImage(image);
            Color background = BackgroundColor.BackgroundColor;
            g.Clear(background);
        }

        //随机颜色类
        class RandomColor
        {
            public Color BackgroundColor { get; }
            public Color CodeColor { get; }
            public Color PointColor { get; }
            public Color LineColor { get; }
            public RandomColor()
            {
                BackgroundColor = Color.FromArgb(ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255));
                CodeColor = Color.FromArgb(ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255));
                PointColor = Color.FromArgb(ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255));
                LineColor = Color.FromArgb(ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255));
            }

        }

        //验证码内容类
        class RandomEmbody
        {
            private string[] arrChar = new string[] { "0", "1", "2", "3", "4", "5", "6", "7",
         "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N",
          "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" ,"a","a","b","c","d","e",
        "f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
            public int a = ran.Next(0, 80);
            public int b = ran.Next(0, 20);
            public string CodeForChar { get; }
            public string CodeForAddtion { get; }

            public  RandomEmbody()
            {
                CodeForChar = $"{a}+{b}=";
                CodeForAddtion = $"{a}+{b}=";
            }


        }




    }
}





