using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repository
{
    public class SQLContext : DbContext
    {
        public DbSet<User> _users { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Article> Articles { get; set; }
        //public DbSet<Blog> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString =
                @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = 17Help; Integrated Security = True; ";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(options =>
            {
                options.ToTable("Users")
                .Property(x => x.Name)
                .IsRequired();
            });

            modelBuilder.Entity<Blog>(options =>
                {
                    options.Ignore(x => x.Url);
                }
                );
        }

       
    }
}
