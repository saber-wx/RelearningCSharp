using System.Collections.Generic;

namespace CSharpStudy
{
    internal class arr
    {
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
    }
}