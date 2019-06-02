using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    class InterfaceLearn
    {
        //为找到最大值定义一个接口，并在“二分查找”和“暴力查找”中实现
        //用接口实例（不是类的实例）调用“找到最大值”的方法
        //虚拟一个需要使用接口“显式实现”的场景，并实现之

        internal static void call()
        {
            IMySort quick = new Quick();
            quick.sort();

            int[] arr = { 8, 1, 11, 2, 10 };
            GetMax max = new ArrayMax();
            Console.WriteLine(max.arrMax(arr));

            ICat cat = new PetAnimal();
            cat.greet();
            IDog dog = new PetAnimal();
            dog.greet();

        }
    }


    interface IMySort
    {
        void sort();
    }

    public class Bubble : IMySort
    {
        public void sort()
        {
            Console.WriteLine("这是冒泡排序法");
        }
    }

    public class Quick : IMySort
    {
        public void sort()
        {
            Console.WriteLine("这是快速排序法");
        }
    }

    interface GetMax
    {
        int arrMax(int[] arr);
    }

    public class ArrayMax : GetMax
    {
        public int arrMax(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
    }

    interface ICat
    {
        void eat();
        void greet();
    }

    interface IDog
    {
        void eat();
        void greet();
    }

    public class PetAnimal : ICat, IDog
    {

        void ICat.eat()
        {
            Console.WriteLine("猫爱吃鱼");
        }

        void IDog.eat()
        {
            Console.WriteLine("狗爱吃骨头");
        }

        void ICat.greet()
        {
            Console.WriteLine("喵~,o( =•ω•= )m");
        }

        void IDog.greet()
        {
            Console.WriteLine("汪~,ฅ՞•ﻌ•՞ฅ");
        }
    }
}
