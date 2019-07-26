using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL.Repository;

namespace BLL.Repository
{
    public class ArticleRepository:Repositorys
    {
        
        public Article Save(Article article)
        {
            CurrentContext.Articles.Add(article);
            CurrentContext.SaveChanges();
            return article;
        }

    }
}
