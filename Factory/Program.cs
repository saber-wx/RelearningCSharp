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
            db.EnsureDeleted();
            db.Migrate();

            RegisterFactory.Create();
            //Article.NewFactory.Create();
            Console.Read();
        }
    }
}
