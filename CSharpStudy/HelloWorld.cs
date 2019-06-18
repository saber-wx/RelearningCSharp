using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace CSharpStudy
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            //LinqToXML.Call();
            XElement element = XElement.Load("D:\\17bang\\articles.xml");
            //创建一个新节点
            XElement insertNode = new XElement("article", new XAttribute("isDraft", "true"),
            new XElement("id", 5),
            new XElement("title", "源栈培训：C#进阶-5：IO和文件操作 "),
            new XElement("authorId", "3")
            );
            //插入此新节点
            element.Add(insertNode);
            Console.WriteLine(element);
            //获取id = 12的评论
            var commentId12 = from x in element.Element("comment").Elements()
                              where x.Element("id").Value == "12"
                              select x;
            //commentId12.Remove();
            Console.WriteLine(commentId12);




            //XElement element = XElement.Load("D:\\17bang\\season.xml");
            //Console.WriteLine(element);
            //Console.WriteLine(element.FirstAttribute);
            //Console.WriteLine(element.FirstNode);
            //Console.WriteLine(element.NextNode);
            //Console.WriteLine(element.Value);
            //Console.WriteLine(element.Element("spring"));
            Console.Read();
        }

    }

}
