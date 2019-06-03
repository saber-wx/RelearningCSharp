using CSharpStudy;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{

    class GenericityLearn
    {
        public static void call()
        {

        }

    }

    class Publishs
    {
        private List<Comment> _comment;
        private User _author;
        public string _title;
        public string _body;

        public Publishs(List<Comment> comment, User author, string title, string body)
        {
            this._comment = comment;
            this._author = author;
            this._title = title;
            this._body = body;
        }

        public virtual void Publish()
        {
        }

        public virtual void Agree()
        {
        }

        public virtual void Disagree()
        {
        }
    }

    class User
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    internal class Problem : Publishs
    {
        public Problem(List<Comment> comment, User author, string title, string body):base(comment, author, title, body)
        {
        }

        public override void Publish()
        {
            Console.WriteLine("发布一个问题");
        }

        public override void Agree()
        {
            Console.WriteLine("问题被点赞");
        }

        public override void Disagree()
        {
            Console.WriteLine("问题被踩");
        }

    }

    class Suggest : Publishs
    {
        public Suggest(List<Comment> comment, User author, string title, string body) : base(comment, author, title, body)
        {
        }

    }

    class Article : Publishs
    {
        public Article(List<Comment> comment, User author, string title, string body) : base(comment, author, title, body)
        {
        }
        private List<Comment> Commit { get; set; }
        private Appraise Appraise { get; set; }
        private List<KeyWord> KeyWord { get; set; }
    }

    class Comment
    {
        private Article Article { get; set; }
        private Appraise Appraise { get; set; }
    }

    class Appraise
    {
        private string appraises;

        public string Appraises { get; set; }
    }

    class KeyWord
    {
        private List<Article> Article { get; set; }
    }



}


