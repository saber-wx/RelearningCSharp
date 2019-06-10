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
            User fg = new User() { Name = "飞哥", Id = 1 };
            User xy = new User() { Name = "小鱼", Id = 2 };
            User xl = new User() { Name = "小龙", Id = 3 };
            User lc = new User() { Name = "老程", Id = 4 };
            User wx = new User() { Name = "文轩", Id = 5 };

            KeyWords Csharp = new KeyWords() { Name = "C#"};
            KeyWords SQL = new KeyWords() { Name = "SQL" };
            KeyWords UI = new KeyWords() { Name = "UI" };
            KeyWords Net = new KeyWords() { Name = ".Net"};
            KeyWords Arts = new KeyWords() { Name = "Arts" };

            //Problem whoIsSmart = new Problem(fg, "谁最帅?", "请如实回答", new DateTime(2018, 12, 15, 12, 12, 12)) { };
            //whoIsSmart.Publish();
            //Problem ASP = new Problem(xl, "ASP 网站迁移 ?", "在服务器上把原先的asp网站整体迁移出来，在新的服务器上重新布置…… ", new DateTime(2018, 12, 16, 12, 12, 12)) { };
            //ASP.Publish();
            //Problem SQL = new Problem(lc, "SQL Server多表查询,中间表有字段可能为空 ?", "如图,表B中的D,E,F可能会是空,SQL怎么写,才能保证数据的一致性;…… ", new DateTime(2018, 12, 17, 12, 12, 12)) { };
            //SQL.Publish();
            //Problem python = new Problem(wx, "python爬虫不能够得到网址 ?", "我去爬了智能招聘的网站，但是用下面那个代码爬到10面的时候，", new DateTime(2018, 12, 18, 12, 12, 12)) { };
            //python.Publish();

            //Comment whoIsSmartComment1 = new Comment(xl, "必须是飞哥", new DateTime(2018, 12, 15, 12, 12, 12), whoIsSmart) { };
            //whoIsSmartComment1.Publish();
            //Comment whoIsSmartComment2 = new Comment(lc, "附议", new DateTime(2018, 12, 15, 12, 12, 12), whoIsSmart) { };
            //whoIsSmartComment2.Publish();
            //Comment whoIsSmartComment3 = new Comment(wx, "附议", new DateTime(2018, 12, 15, 12, 12, 12), whoIsSmart) { };
            //whoIsSmartComment3.Publish();

            Article article_1 = new Article(fg, "C#进阶1:(泛型)集合",
                "为什么要使用集合？数组不够强大，^_^List<T>初窥//所有泛型集合都在该命名空间下" +
                "using System.Collections.Generic;初始化方法List<string> student = new List<string>()",
                new DateTime(2019, 06, 15, 09, 00, 00))
            { };
            article_1.KeyWord = new List<KeyWords> { Csharp, SQL };
            article_1.Publish();


            Article article_2 = new Article(fg, "C#进阶2:Linq", "集合的增删改查中，最有技术含量的就是：查。在过去很长一段时间里，" +
                "我们只能在for / foreach循环中进行遍历和筛选，直到出现了Linq,",
             new DateTime(2019, 06, 16, 09, 00, 00))
            { };
            article_2.KeyWord = new List<KeyWords> { Net, SQL };
            article_2.Publish();


            Article article_3 = new Article(xy, "UI进阶1:美术1", "美术好处都有啥,谁说对了就教给他",new DateTime(2019, 06, 16, 09, 00, 00))
            { };
            article_3.KeyWord = new List<KeyWords> { Csharp, UI, Arts };
            article_3.Publish();


            Article article_4 = new Article(xy, "UI进阶2:美术2", "美术好处都有啥,谁说对了就教给他", new DateTime(2019, 06, 17, 09, 00, 00))
            { };
            article_4.KeyWord = new List<KeyWords> { Net, UI, Arts };
            article_4.Publish();


            IList<Article> Article = new List<Article>{ article_1, article_2, article_3, article_4 };

            var excellent = from s in Article
                            where s.
                            //select s;



        }

        //发布类
        public class Publishs
        {
            public User Author { get; set; }
            public string Title { get; set; }
            public string Body { get; set; }
            public DateTime Date { get; set; }
            public Publishs(User author, string title, string body, DateTime Date)
            {
                this.Author = author;
                this.Title = title;
                this.Body = body;
                this.Date = Date;
            }
        }
        // 发布接口
        interface IPublishs<out T>
        {
            void Publish();
        }

        //用户类
        public class User
        {
            public string Name { get; set; }
            public int Id { get; set; }
        }

        //求助类
        public class Problem : Publishs, IPublishs
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

        //建议类
        public class Suggest : Publishs, IPublishs
        {
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

        //文章类
        public class Article : Publishs, IPublishs
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


        //评论类
        public class Comment
        {
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

        //点赞类
        public class Agree
        {
            public IPublishs Publishs { get; set; }
        }

        //踩类
        public class Disagree
        {
            public IPublishs Publishs { get; set; }
        }



        //评价类
        public class Appraise
        {
            public Article Article { get; set; }
            public Comment Comment { get; set; }
            public string Appraises { get; set; }
        }

        //关键字类
        public class KeyWords
        {
            public List<Article> Article { get; set; }
            public String Name { get; set; }
        }



    }
}


