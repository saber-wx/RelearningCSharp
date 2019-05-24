using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    class EscapeCharacter
    {
        static void call(string[] args)
        {
            /*
             转义符指的是一个'\' 加 一个特殊的字符,组成一个具有特殊意义的字符
             \n:表示换行  用在控制台中
             \":表示一个英文半角的双引号
             \t:表示一个Tab键的空格
             \b:表示一个退格键,放到字符串的两头会无效
             \\:表示一个\
             \r\n:windows系统不认识\n,只认\r\n  
             @符号
             1.取消\在字符串中的转义作用
             2.将字符串按照原格式输出
             */

            Console.WriteLine("Hello\nWorld!");

            Console.WriteLine("Hello\"World!");

            Console.WriteLine("Hello\tWorld!");

            Console.WriteLine("Hello\bWorld!");

            Console.WriteLine("Hello\\World!");

            Console.WriteLine(@"Hello\\World!");
            Console.WriteLine(@"Hello
            World!");
            Console.ReadKey();
        }
    }
}
