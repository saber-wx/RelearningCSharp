using BLL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Factory.Blogs
{
    internal class NewFactory
    {
        public static readonly LoggerFactory consoleloggerFactory
            = new LoggerFactory(new[]
    {
                new ConsoleLoggerProvider((category,level)=>
                category == DbLoggerCategory.Database.Command.Name&&
                level == LogLevel.Information,
                    true)
        //new ConsoleLoggerProvider((_, __) => true, true)
    });

        internal static void Create()
        {
            //using (SQLContext context = new SQLContext())
            //{
            //    for (int i = 0; i < 30; i++)
            //    {
            //        BLL.Blog b = new BLL.Blog
            //        {
            //            Title = "我是Blog" + i,
            //            Author = context._users.First()
            //        };
            //        context.Blogs.Add(b);
            //    }
            //    context.SaveChanges();

            //    context.Blogs.Remove(context.Blogs.First<BLL.Blog>());
            //    context.SaveChanges();

            //    BLL.Blog blog = context.Blogs.LastOrDefault();
            //    blog.Title = "saber的Blog";
            //    context.SaveChanges();
            //}

            //string path = Environment.CurrentDirectory;

            string folderPath = "..\\..\\..\\Blogs\\contents";
            string[] filenames = Directory.GetFiles(folderPath);

            for (int i = 0; i < filenames.Length; i++)
            {
                string path = filenames[i];
                string body = File.ReadAllText(path, Encoding.UTF8);
                BLL.User author = null;
                if (i % 4 == 0)
                {
                    author = RegisterFactory.Saber;
                }
                else
                {
                    author = RegisterFactory.Lancer;
                }
                publish(Path.GetFileName(path), body, author);
            }


        }

        private static BLL.Blog publish(string title, string body, BLL.User author)
        {
            BlogRepository repository = new BlogRepository(Helper.context);

            BLL.Blog blog = new BLL.Blog
            {
                Title = title,
                Body = body,
                Author = author
            };

            repository.Save(blog);
            //blog.Publish();
            return blog;
        }


    }
}
