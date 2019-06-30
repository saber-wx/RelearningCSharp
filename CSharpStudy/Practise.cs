using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    class Practise
    {

    }

    class LoopPractise
    {
        //public static int SumFrom1ToX(int x)
        //{
        //    if (x == 1)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        int resurt = x + SumFrom1ToX(x - 1);
        //        return resurt;
        //    }
        //}

        public static int SumFrom1ToX(int x)
        {
            return (1 + x) * x / 2;
        }
    }
}
