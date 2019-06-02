using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    class ReadInput
    {
        public static void call()
        {
            Console.WriteLine("请输入您的姓名");

            string name = Console.ReadLine();

            //输入姓名性别年龄,按下某个键后在屏幕上显示:您好:您的年龄是**是个*生

            Console.WriteLine("你是男还是女?");
            string Gender = Console.ReadLine();
            Console.WriteLine("你的年龄是?");
            string age = Console.ReadLine();
            Console.WriteLine("您好,您的姓名是{0},今年{1}岁了,是个{2}生", name, age, Gender);

            Console.WriteLine("你喜欢吃啥水果?");

            string fruit = Console.ReadLine();
            Console.WriteLine("好巧,我也喜欢吃{0}", fruit);
            Console.ReadKey();
        }

    }
}
