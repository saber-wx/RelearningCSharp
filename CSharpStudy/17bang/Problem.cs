using System;
using System.Collections.Generic;
using System.Text;
using static CSharpStudy.GenericityLearn;

namespace CSharpStudy._17bang
{
    //求助类
     class Problem : Publishs, IPublishs
    {
        public Problem(User author, string title, string body, DateTime Date) : base(author, title, body, Date)
        {
        }
        public List<Comment> Comment { get; set; }
        public List<Agree> agree { get; set; }
        public List<Agree> Disagree { get; set; }
        public void Publish()
        {
            Console.WriteLine($"用户\"{Author.Name}\"在{Date}发布问题:");
            Console.WriteLine($"标题:{Title}");
            Console.WriteLine($"问题:{Body}");
            Console.WriteLine("==========================================");
        }

    }
}
