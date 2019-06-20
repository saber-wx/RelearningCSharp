using System;
using System.Collections.Generic;
using System.Text;
using static CSharpStudy.GenericityLearn;

namespace CSharpStudy._17bang
{
    //文章类
     class Article : Publishs, IPublishs
    {
         public Article(User author, string title, string body, DateTime Date) : base(author, title, body, Date)
        {
        }
        public List<Comment> Comment { get; set; }
        public List<Agree> agree { get; set; }
        public List<Agree> Disagree { get; set; }
        public Appraise Appraise { get; set; }
        public List<KeyWords> KeyWord { get; set; }
        public void Publish()
        {
            Console.WriteLine($"用户\"{Author.Name}\"在{Date}发布文章:");
            Console.WriteLine($"标题:{Title}");
            Console.WriteLine($"文章:{Body}");
            Console.WriteLine($"关键字:{KeyWord.ToArray().Length}个");
            Console.WriteLine("==========================================");
        }

    }
}
