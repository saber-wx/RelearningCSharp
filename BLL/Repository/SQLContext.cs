using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repository
{
    public class SQLContext : DbContext
    {
        public DbSet<User> _users { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17Help;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);


        }
    }
}
