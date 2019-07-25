using BLL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.Blogs
{
    internal class NewFactory
    {
    //    public static readonly LoggerFactory consoleloggerFactory
    //        = new LoggerFactory(new[]
    //{
    //            new ConsoleLoggerProvider((category,level)=>
    //            category == DbLoggerCategory.Database.Command.Name&&
    //            level == LogLevel.Information,
    //                true)
    //    //new ConsoleLoggerProvider((_, __) => true, true)
    //});

    //    internal static void Create()
    //    {
    //        string connectionString =
    //         @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = 17Help; Integrated Security = True; ";
    //        DbContextOptionsBuilder<SQLContext> optionsBuilder = new DbContextOptionsBuilder<SQLContext>();
    //        optionsBuilder
    //            .UseLoggerFactory(consoleloggerFactory)
    //            .UseSqlServer(connectionString);

    //        using ( SQLContext context = new SQLContext())
    //        {
    //            for (int i = 0; i < 30; i++)
    //            {
    //                BLL.Blog b = new BLL.Blog
    //                {
    //                    Title = "我是Blog" + i,
    //                    Author = context._users.First()
    //                };
    //                context.Blogs.Add(b);
    //            }
    //            context.SaveChanges();

    //            context.Blogs.Remove(context.Blogs.First<BLL.Blog>());
    //            context.SaveChanges();

    //            BLL.Blog blog = context.Blogs.LastOrDefault();
    //            blog.Title = "saber的Blog";
    //            context.SaveChanges();
    //        }
    //    }
    }
}
