using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;

namespace CSharpStudy
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            //    //XName a = new XName();
            //    //LinqToXML.Call();
            //    XElement element = XElement.Load("D:\\17bang\\articles.xml");
            //    //创建一个新节点
            //    XElement insertNode = new XElement("article", new XAttribute("isDraft", "true"),
            //    new XElement("id", 5),
            //    new XElement("title", "源栈培训：C#进阶-5：IO和文件操作 "),
            //    new XElement("authorId", "3")
            //    );
            //    //插入此新节点
            //    element.Add(insertNode);

            //    //获取id = 12的评论
            //    var commentId12 = from x in element.Descendants().Elements().ToList()
            //                      where (string)x.Element("id") == "12"
            //                      select x;
            //    //删除id=12的评论
            //    commentId12.Nodes().Remove();
            //    foreach (var item in commentId12)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    //找到id=2的文章
            //    var articleId2 = from x in element.Descendants().ToList()
            //                     where (string)x.Element("id") == "2"
            //                     select x;
            //    //修改属性和title
            //    foreach (var item in articleId2)
            //    {
            //        item.SetAttributeValue("isDraft", "false");
            //        item.Element("title").Value = "C#进阶-8：异步和并行 ";
            //        Console.WriteLine(item);
            //    }

            //    Console.WriteLine(element);
            TaskLearn.Call();
            Console.Read();
            
        }

    }

}
