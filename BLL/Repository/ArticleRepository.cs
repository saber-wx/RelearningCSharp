using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repository
{
    public class ArticleRepository
    {
        private SQLContext _sqlcontext;

        public ArticleRepository()
        {
            _sqlcontext = new SQLContext();
        }

        public Article Save(Article article)
        {
            //_sqlcontext.Articles.Add(article);
            //_sqlcontext.SaveChanges();
            return article;
        }

    }
}
