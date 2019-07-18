using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Security.Cryptography;

namespace CSharpStudy
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                Console.WriteLine(GetMd5Hash(md5Hash, "13871398608"));
            }


            //ReflectLearn.Call();
            //Console.WriteLine();
            Console.Read();
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            //1. 将字符串转换成byte[]
            //2. 进行MD5加密运算
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            //StringBuilder提高性能（其实也提高了可读性）
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }



    }
}

