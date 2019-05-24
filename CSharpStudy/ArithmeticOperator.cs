using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    class ArithmeticOperator
    {
        static void call()
        {
            int r = 5;
            double area = 3.14 * r * r;
            double perimeter = 2 * 3.14 * r;
            Console.WriteLine("面积是{0}周长是{1}", area, perimeter);
            Console.WriteLine("--------------------------------");

            int t_shirt = 35;
            int trousers = 120;
            int totalMoney = t_shirt * 3 + trousers * 2;
            Console.WriteLine("3件T恤和2条裤子的总价是{0}", totalMoney);
            double realMoney = totalMoney * 0.88;
            Console.WriteLine("打折后是{0}", realMoney);
            Console.ReadKey();
            Console.WriteLine("--------------------------------");


            /*1.自动类型转换,或称之为隐式转换 
                a.两种兼容的类型(都是数字类型),
                b.目标类型大于源类型
                    格式:
                    小的类型 小的变量名 = 数据;
                    大的类型 大的变量名 = 小的变量名*/
            int i1 = 5;
            double d1 = i1;
            Console.WriteLine(d1);
            Console.ReadKey();
            Console.WriteLine("-----------------");

            int i2 = 10;
            int i3 = 3;
            double d2 = i2 * 1.0 / i3;
            Console.WriteLine(d2);
            Console.ReadKey();
            Console.WriteLine("-----------------");


            /*2.强制类型转换,或称之为显式转换 
                a.两种兼容的类型,
                b.目标类型小于源类型
                格式:
                    大的类型 大的变量名 = 数据;
                    小的类型 小的变量名 = (小的类型)大的变量名;*/
            double d3 = 3.14;
            int i5 = (int)d3;
            Console.WriteLine(i5); //将double类型强制转换为int类型,会丢失精确度
            Console.ReadKey();

        }
    }
}
