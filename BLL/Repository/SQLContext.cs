using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repository
{
    public class SQLContext: DbContext
    {
        public SQLContext()
        {

        }

        //public static readonly LoggerFactory consoleLoggerFactory
        //    = new LoggerFactory(
        //        new[]
        //        {
        //            new ConsoleLoggerProvider((category,level))
        //        }
        //        )


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

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Name)
                .IsUnique();

            modelBuilder.Entity<Email>()
                .HasOne(e => e.Ower)
                .WithOne(u => u.Email)
                .HasForeignKey<Email>(e => e.OwerId);

            modelBuilder.Entity<Writings>()
                .HasDiscriminator(b => b.DiscriminatorType);

            modelBuilder.Entity<BlogToKeyword>()
                .HasKey(bk => new { bk.BlogId, bk.KeywordId });     //联合主键

            modelBuilder.Entity<BlogToKeyword>()
                .HasOne(bk => bk.Blog)
                .WithMany(b => b.Keywords)
                .HasForeignKey(b => b.BlogId);

            modelBuilder.Entity<BlogToKeyword>()
                .HasOne(bk => bk.Keyword)
                .WithMany(b => b.Blogs)
                .HasForeignKey(b => b.KeywordId);

            //modelBuilder.Entity<Blog>(options =>
            //    {
            //        options.Ignore(x => x.Url);
            //    }
            //    );
        }


    }
}
