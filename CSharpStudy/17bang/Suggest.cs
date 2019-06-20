using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy._17bang
{
     class Suggest : Publishs, IPublishs
    {
        //建议类
        public Suggest(User author, string title, string body, DateTime Date) : base(author, title, body, Date)
        {
        }
        public List<Comment> Comment { get; set; }
        public List<Agree> agree { get; set; }
        public List<Agree> Disagree { get; set; }
        public void Publish()
        {
            Console.WriteLine("发布一个建议");
        }

    }
}
