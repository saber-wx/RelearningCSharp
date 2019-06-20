using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace CSharpStudy
{
    class LinqToXML
    {
        public static void Call()
        {
            XDocument document = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), articles());
            document.Save("D:\\17bang\\articles.xml");
        }

        private static XElement articles()
        {
            XElement articles = new XElement("articles",
            new XComment("以下存放所有“源栈”所有文章"),
            new XElement("article", new XAttribute("isDraft", "false"),
            new XElement("id", 1),
            new XElement("title", "C#进阶-7：Linq to XML"),
            new XElement("body", "什么是XML（EXtensible Markup Language）是一种文本文件" +
                         "格式被设计用来传输和存储数据由：标签和属性组成" +
                         "元素（节点），由元素组成“树状结构”必须有" +
                         "而且只能有一个根节点其他："),
            new XElement("authorId", "1"),
            new XElement("publishDate", DateTime.Now.ToString()),
            new XElement("comments",
            new XElement("comment", new XAttribute("recommend", "true"),
            new XElement("id", "12"),
            new XElement("body", "不错,赞!"),
            new XElement("authorId", "2")
            ),
            new XElement("comment",
            new XElement("id", "14"),
            new XElement("body", "作业太难了!"),
            new XElement("authorId", "3")
            )
            )
            ),
            new XElement("article", new XAttribute("isDraft", "true"),
            new XElement("id", 2),
            new XElement("title", "源栈培训：C#进阶-6：异步和并行"),
            new XElement("authorId", "1")
            )
            );
            Console.WriteLine(articles);
            return articles;
        }

        public static void practise()
        {
            XElement season = new XElement(
            "year",
            new XComment("一年有12个月"),
            new XComment("一年有4个季度"),
            new XElement("season", new XAttribute("name", "季节"),
            new XElement("spring", new XAttribute("name", "春季"), new XAttribute("month", "3-5"), new XAttribute("weather", "warm"),
            new XElement("March", "三月"),
            new XElement("April", "四月"),
            new XElement("May", "五月")
            ),
            new XElement("summer", "夏季", new XAttribute("month", "6-8")
            ),
            new XElement("autumn", "秋季", new XAttribute("month", "9-11")
            ),
            new XElement("winter", "冬季", new XAttribute("month", "12-2")
            )
            ));
            Console.WriteLine(season);

            XDocument document = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), season);
            document.Save("D:\\17bang\\season.xml");

        }

        //public static void nn()
        //{

        //    //try
        //    //{
        //    //    IdentifyingCode.Image(200, 100);
        //    //}
        //    //catch (RrongColorException e)
        //    //{
        //    //    File.AppendAllText("D:\\17bang\\wx-验证码-error.log",
        //    //    $"{DateTime.Now}：长度不能超过250,高度不能超过150" + e.ToString() + Environment.NewLine);
        //    //    Console.WriteLine("长度不能超过250,高度不能超过150");

        //    //}
        //    //catch (InvalidCastException e)
        //    //{
        //    //    File.AppendAllText("D:\\17bang\\wx-验证码-error.log",
        //    //    $"{DateTime.Now}：长度不能超过250,高度不能超过150" + e.ToString() + Environment.NewLine);
        //    //    Console.WriteLine("背景颜色不能是黑色");
        //    //}

        //    string str = "LittleBai";
        //    //创建写入字符串
        //    Byte[] bytesToWrite = Encoding.Default.GetBytes(str); ;
        //    //创建文件
        //    using (FileStream fs = new FileStream("test.txt", FileMode.Create))
        //    {
        //        //将字符串写入文件
        //        fs.Write(bytesToWrite, 0, bytesToWrite.Length);
        //    }
        //}


    }
}
