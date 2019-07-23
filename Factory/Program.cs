using BLL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;


namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseFacade db = new SQLContext().Database;
            db.EnsureDeleted();     //如果存在数据库，就删除之
            db.EnsureCreated();     

            ////new SQLContext().Database.Migrate();

            RegisterFactory.Create();
            //Article.NewFactory.Create();
            //Console.Read();
        }
    }
}
