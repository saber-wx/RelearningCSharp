using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy._17bang
{
     class Comment
    {
        //评论类
        public User Author { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
        public Publishs Publishs { get; set; }
        public Appraise Appraise { get; set; }
        public Comment(User author, string body, DateTime date, Publishs Publish)
        {
            this.Author = author;
            this.Body = body;
            this.Date = Date;
            this.Publishs = Publish;
        }
        public void Publish()
        {
            Console.WriteLine($"用户\"{Author.Name}\"{Date}在:");
            Console.WriteLine($"\"{Publishs.Author.Name}\"的<{Publishs.Title}>问题下发表了评论:");
            Console.WriteLine($"{Body}");
            Console.WriteLine("==========================================");
        }
    }
}
