using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace frameworkLearn.CAPTCHA
{
    class Captcha
    {
        public static void Call()
        {
            try
            {
                Captcha image = new Captcha(200, 100);
                image.Get().Save(CaptchaPath, ImageFormat.Jpeg);
            }
            catch (ExceedWidthOrHeightException e)
            {

                File.AppendAllText("D:\\17bang\\wx-WidthOrHeight-error.log",
                    $"{DateTime.Now}：长度不能超过250,高度不能超过150" + e.ToString() + Environment.NewLine);
            }
            catch (BackgroundCodeColorCoveredException e)
            {

                File.AppendAllText("D:\\17bang\\wx-BackgroundCodeColor-error.log",
                    $"{DateTime.Now}：背景颜色被覆盖" + e.ToString() + Environment.NewLine);
            }
        }

        const string CaptchaPath = @"D:\17bang\Captcha-wx.jpeg";

        //生成随机数对象
        private static Random _ran = new Random();

        //位图属性
        private Bitmap _image;

        //图片长
        public int Width { get; }

        //图片高
        public int Height { get; }

        //生成随机颜色对象字段
        private RandomColor _color = new RandomColor();

        //数学验证码
        private RandomArithmetic _numberContent = new RandomArithmetic();

        //生成图片构造方法
        public Captcha(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            this._image = new Bitmap(width, height);
        }

        //获得验证码图片
        private Bitmap Get()
        {
            if (_image.Width > 250 || _image.Height > 150)
            {
                throw new ExceedWidthOrHeightException();
            }
            else
            {
                if (_color.CodeColor != _color.BackgroundColor)
                {
                    BackgroundColor();
                    //Content();
                    //DrawLine();
                    //SpeckPoint();
                    Thread current = Thread.CurrentThread;
                    Console.WriteLine($"current:{current.ManagedThreadId }");
                    Thread currentWorker = new Thread(new ThreadStart(Content));
                    Console.WriteLine($"ContentCurrentWorkerThreadId:{currentWorker.ManagedThreadId}");
                    Task t1 = new Task(DrawLine);
                    Console.WriteLine($"DrawLineTaskT1:{t1.Id}");
                    Task t2 = new Task(SpeckPoint);
                    Console.WriteLine($"DrawLineTaskT1:{t2.Id}");
                    return _image;
                }
                else
                {
                    throw new BackgroundCodeColorCoveredException();
                }
            }
        }

        //画点
        private void SpeckPoint()
        {
            for (int i = 0; i < 1000; i++)
            {
                int red = _ran.Next(0, 255);
                int green = _ran.Next(0, 255);
                int blue = _ran.Next(0, 255);
                int XAxis = _ran.Next(0, _image.Width);
                int YAxis = _ran.Next(0, _image.Height);
                _image.SetPixel(XAxis, YAxis, Color.FromArgb(red, green, blue));
            }
        }

        //画线
        private void DrawLine()
        {
            Graphics g = Graphics.FromImage(_image);
            for (int i = 0; i < 20; i++)
            {
                int red = _ran.Next(0, 255);
                int green = _ran.Next(0, 255);
                int blue = _ran.Next(0, 255);
                int XAxis1 = _ran.Next(0, _image.Width);
                int XAxis2 = _ran.Next(0, _image.Width);
                int YAxis1 = _ran.Next(0, _image.Height);
                int YAxis2 = _ran.Next(0, _image.Height);
                g.DrawLine(new Pen(Color.FromArgb(red, green, blue)), new Point(XAxis1, YAxis1), new Point(XAxis2, YAxis2));
            }
        }

        //生成验证码内容
        private void Content()
        {
            //创建
            Graphics g = Graphics.FromImage(_image);
            SolidBrush solidBrush = new SolidBrush(_color.CodeColor);
            g.DrawString(_numberContent.Content, new Font("黑体", 40), solidBrush, new PointF(5, 5));
        }

        //给背景上色
        private void BackgroundColor()
        {
            Graphics g = Graphics.FromImage(_image);
            g.Clear(_color.BackgroundColor);
        }

        //随机颜色类
        class RandomColor
        {
            public Color BackgroundColor { get; }
            public Color CodeColor { get; }
            public RandomColor()
            {
                BackgroundColor = Color.FromArgb(_ran.Next(0, 255), _ran.Next(0, 255), _ran.Next(0, 255));
                CodeColor = Color.FromArgb(_ran.Next(0, 255), _ran.Next(0, 255), _ran.Next(0, 255));
            }

        }

        //数学验证码内容类
        class RandomArithmetic
        {
            //生成两个加数
            public int Number1 { get; }
            public int Number2 { get; }
            public string Content { get; }

            public RandomArithmetic()
            {
                Number1 = _ran.Next(50, 100);
                Number2 = _ran.Next(0, 100 - Number1);
                int oper = _ran.Next(1, 3);
                if (oper == 1)
                {
                    Content = $"{Number1}-{Number2}=";
                }
                else
                {
                    Content = $"{Number1}+{Number2}=";
                }
            }
        }

        ////验证
        //public void Confirmation()
        //{
        //    Console.WriteLine("请输入验证码结果:(输入\"刷新\"刷新验证码)");
        //    string input = Console.ReadLine();
        //    string sum = "";
        //    if (NumberContent.Content.Contains("+"))
        //    {
        //         sum = (NumberContent.Number1 + NumberContent.Number2).ToString();
        //    }
        //    else
        //    {
        //        sum = (NumberContent.Number1 - NumberContent.Number2).ToString();
        //    }

        //    while (true)
        //    {
        //        if (sum == input)
        //        {
        //            Console.WriteLine("验证通过!");
        //            break;
        //        }
        //        else if (input == "刷新")
        //        {
        //            Get();
        //            Confirmation();
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

}





