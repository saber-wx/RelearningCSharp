using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            int a = 1;
            int b = 2;
            int c = 3;
            //占位符的使用
            Console.WriteLine("第一个数字是{2},第二个数字是{0},第三个数字是{1}", a, b, c);
            Console.ReadKey();
            int d = GetMax(a, b);
            Console.WriteLine("较大的一个值是"+d);
            Print();
            Console.ReadKey();

        }
        #region  这些代码获取两个变量最大值
        public static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }
        #endregion

        public static void Print()
        {
            string name = "蔡徐坤";
            string address = "火影村";
            int age = 10;
            decimal salary = 5000m;
            string email = "kakaxi@qq.com";
            Console.WriteLine("我叫" + name + ",我住在" + address + ",我今年" + age + "岁了,我的邮箱是" + email + ",我的工资" + salary + "块");
            Console.ReadKey();
        }
    }
}
