using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    class boxAndUnbox
    {
        //构造一个能装任何数据的数组，并完成数据的读写
        //使用object改造数据结构栈（Stack），并在出栈时获得出栈元素

        public static void call()
        {
            object[] arr = new object[10];
            arr[0] = 1;
            arr[2] = false;
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[2]);

        }
    }
}
