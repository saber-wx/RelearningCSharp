using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    class Convert
    {
        internal static void call()
        {
            /*类型如果兼容的两个变量,可以使用自动类型转换或强制类型转换,
             * 但是,如果两个类型的变量不兼容,比如string与int或string与double,
             * 这时需要用Convert的转换方式进行转换,
             * 注意:使用Convert进行类型转换,需要满足一个条件:
                面上必须过得去
             */

            string s = "123";
            double d = Convert.ToDouble(s);
            int n = Convert.ToInt32(s);
            Console.WriteLine(d);
            Console.WriteLine(n);
            Console.ReadKey();
            Console.WriteLine("--------------------");

            //输入姓名 语文 数学 英语 三门课的成绩,然后显示:XX,你的总成绩是XX分,平均分是XX分,
            Console.WriteLine("请输入姓名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入语文成绩");
            string strChinese = Console.ReadLine();
            Console.WriteLine("请输入数学成绩");
            string strMath = Console.ReadLine();
            Console.WriteLine("请输入英语成绩");
            string strEnglish = Console.ReadLine();

            int chinese = Convert.ToInt32(strChinese);
            int math = Convert.ToInt32(strMath);
            int english = Convert.ToInt32(strEnglish);

            

            int sum = chinese + math + english;
            double avg = sum / 3;

            Console.WriteLine("{0}你的总成绩是{1}分,平均分是{2}分", name, sum, avg);
            Console.ReadKey();
        }

        private static int ToInt32(string strChinese)
        {
            throw new NotImplementedException();
        }

        private static double ToDouble(string s)
        {
            throw new NotImplementedException();
        }
    }
}
