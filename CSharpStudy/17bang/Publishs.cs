using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy._17bang
{
    //发布类
     class Publishs
    {
        public User Author { get; }
        public string Title { get; }
        public string Body { get; }
        public DateTime Date { get; }
        public Publishs(User author, string title, string body, DateTime Date)
        {
            this.Author = author;
            this.Title = title;
            this.Body = body;
            this.Date = Date;
        }
    }
}
