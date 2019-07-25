using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repository
{
    public class ArticleRepository
    {
        private SQLContext _sqlcontext;

 

        public ArticleRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<SQLContext>();
            string connectionString =
                 @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = 17Help; Integrated Security = True; ";
            optionsBuilder.UseSqlServer(connectionString);
            using(var context = new SQLContext(optionsBuilder.Options))
            {

            }
            _sqlcontext = new SQLContext(new DbContextOptions<SQLContext>());
            
        }

        public Article Save(Article article,int authorId)
        {
            article.Author = _sqlcontext._users
                .Where(u => u.Id == authorId)
                .SingleOrDefault();
            _sqlcontext.Articles.Add(article);
            _sqlcontext.SaveChanges();
            return article;
        }

    }
}
