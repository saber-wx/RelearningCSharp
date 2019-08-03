using BLL;
using BLL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Options;
using System;


namespace Factory
{
    class Program
    {
        //public static readonly LoggerFactory consoleloggerFactory
        //    = new LoggerFactory(new[]
        //    {
        //        //new ConsoleLoggerProvider((category,level)=>
        //        //category == DbLoggerCategory.Database.Command.Name&&
        //        //level == LogLevel.Information,
        //        //    true);
        //        new ConsoleLoggerProvider((_, __) => true, true)
        //    });



        static void Main(string[] args)
        {
            //string connectionString =
            // @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = 17Help; Integrated Security = True; ";
            //DbContextOptionsBuilder<SQLContext> optionsBuilder = new DbContextOptionsBuilder<SQLContext>();
            //optionsBuilder
            //    //.UseLoggerFactory(consoleloggerFactory)
            //    .UseSqlServer(connectionString);

            DatabaseFacade db = Helper.context.Database;
            db.EnsureDeleted();     //如果存在数据库，就删除之
            db.EnsureCreated();


            ////new SQLContext().Database.Migrate();

            RegisterFactory.Create();
            ////Article.NewFactory.Create();
            Blogs.NewFactory.Create();
            Blogs.SingleFactory.Create();

            Helper.context.Dispose();

        }
    }
}
