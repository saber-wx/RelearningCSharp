using System;

namespace VariableExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 40;
            int n2 = 80;

            ////方法1
            //int temp;
            //temp = n1;
            //n1 = n2;
            //n2 = temp;

            //Console.WriteLine(n1+"和"+n2);
            //Console.ReadKey();

            //方法2
            n1 = n1 - n2;  //n1 = -40
            n2 = n1 + n2;  //n2 = 40
            n1 = n2 - n1;  //n1 = 80

            Console.WriteLine(n1 + "和" + n2);
            Console.ReadKey();
        }
    }
}
