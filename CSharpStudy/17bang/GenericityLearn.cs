using CSharpStudy;
using CSharpStudy._17bang;
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
        }

        
  
        // 发布接口
        interface IPublishs<out T>
        {
            void Publish();
        }


       
        
    }
}


