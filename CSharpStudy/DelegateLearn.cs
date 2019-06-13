using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    public delegate void SayHi(string name);

    class DelegateLearn
    {
        public static void Call()
        {
            SayHi del = EnglishSayHi;
            del("李四");
            Test("张三", chineseSayHi);
        }

        static void Test(string name, SayHi del)
        {
            del(name);
        }


   

        static void chineseSayHi(string name)
        {
            Console.WriteLine($"吃了么?{name}");
        }

        static void EnglishSayHi(string name)
        {
            Console.WriteLine($"good morning?{name}");
        }

    }


}
