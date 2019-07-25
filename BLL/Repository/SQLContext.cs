using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repository
{
    public class SQLContext : DbContext
    {
        public SQLContext()
        {

        }

        public SQLContext(DbContextOptions<SQLContext> options) : base(options) { }

        public DbSet<User> _users { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Writings> Writings { get; set; }

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
