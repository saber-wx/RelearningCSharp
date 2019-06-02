using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{

    class GenericityLearn
    {
        public static void call()
        {
            Publishs a = new Problem();
            a.Publish();
            a.Disagree();
            a.Agree();
        }

    }


    class Publishs
    {
        private string author;
        private string title;
        private string body;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Body
        {
            get { return body; }
            set { body = value; }
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

        public virtual void BeCommented()
        {

        }
    }

    class Problem : Publishs 
    {
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

        public override void BeCommented()
        {
            Console.WriteLine("问题被评论");
        }

    }

    class Suggest : Publishs
    {

    }

    class Article : Publishs
    {
        private List<Comment> commit { get; set; }
        private Appraise appraise { get; set; }
        private List<KeyWord> keyWord { get; set; }
    }



    class Comment
    {
        private Article article { get; set; }
        private Appraise appraise { get; set; }
    }

    class Appraise
    {

    }

    class KeyWord
    {
        private List<Article> article { get; set; }
    }



}


