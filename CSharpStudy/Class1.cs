using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Class1
    {
        static void Main(string[] args)
        {
            var count = 0;

            //for (int i = 0; i < 10; i++)
            //{
            //    count = ++count;
            //    Console.WriteLine(count);
            //}
            Console.WriteLine(count+=1);
            Console.WriteLine(count);

            Console.ReadKey();

        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}
    }
}
