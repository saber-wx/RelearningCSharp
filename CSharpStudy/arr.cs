using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    internal class Arr
    {

        //StringBuilder
        public static void call()
        {
            int[] a = new int[20];
            //统计 welcome to luckystack 中每个字符出现的次数
            string str = "WElcome to luckystack";
            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    continue;
                }

                if (dic.ContainsKey(str[i]))
                {
                    dic[str[i]]++;
                }
                else
                {
                    dic[str[i]] = 1;
                }
            }
            foreach (KeyValuePair<char, int> kv in dic)
            {
                System.Console.WriteLine("字母{0} 出现了{1}次", kv.Key, kv.Value);
            }
        }

        //求数组最大值
        public static void ArrMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            System.Console.WriteLine($"此数组最大值是{max}");
        }

        //冒泡排序
        public static void BubbleSort(int[] arr)
        {

            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-1-i; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }

                }
                
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }

        //反转数组元素
        public static void ArrReverse(string[] arr)
        {
            string temp;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }

    }
}