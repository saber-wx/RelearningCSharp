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
            new UserRepository().Database.Migrate();
            RegisterFactory.Create();
            Console.WriteLine("hello world !");
        }
    }
}
