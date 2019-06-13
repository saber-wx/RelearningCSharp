using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frameworkLearn
{
    class Program
    {
        public static void Main(string[] args)
        {
            Bitmap image = new Bitmap(200, 100);
            Graphics g = Graphics.FromImage(image);
            g.Clear(Color.AliceBlue);

            Random ran = new Random();
            //创建100内随机数
            int a = ran.Next(0, 100);
            int b = ran.Next(0, 100);

            g.DrawString(($"{a}+{b}"), new Font("黑体",50), new SolidBrush(Color.DarkBlue), new PointF(5, 5));

            for (int i = 0; i < 10; i++)
            {
                int x1 = ran.Next(0, 200);
                int x2 = ran.Next(0, 100);
                int y1 = ran.Next(0, 200);
                int y2 = ran.Next(0, 100);
                g.DrawLine(new Pen(Color.Blue), new Point(x1, x2), new Point(y1, y2));
            }
            for (int i = 0; i < 1000; i++)
            {
                int z1 = ran.Next(0, 200);
                int z2 = ran.Next(0, 100);
                image.SetPixel(z1, z2, Color.Red);
            }

            image.Save(@"D:\17bang\hello.jpeg", ImageFormat.Jpeg);

        }

    }
}
