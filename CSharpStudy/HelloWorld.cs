using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace CSharpStudy
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            //LinqToXML.Call();
            XElement element = XElement.Load("D:\\17bang\\season.xml");
            Console.WriteLine(element);
            Console.WriteLine(element.BaseUri);
            Console.WriteLine(element.Document);
            Console.WriteLine(element.FirstAttribute);
            Console.WriteLine(element.FirstNode);
            Console.WriteLine(element.NextNode);
            Console.WriteLine(element.Value);
            Console.WriteLine(element.Element("spring"));
            Console.Read();
        }

    }

}
