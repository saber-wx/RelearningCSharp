using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy._17bang
{
    class ArticleRepository : IArticleRepository
    {
        private static IList<Article> Trepository;
        IList<Article> Get()
        {
            return Trepository;
        }
        void Add(Article article)
        {
            if (Trepository == null)
            {
                Trepository = new List<Article>();
            }
            else
            {
                Trepository.Add(article);
            }
        }
        
        Article GetByAuthor(string Author)
        {
            return null;
        }

        List<Article> IRepository<Article>.Get()
        {
            return null;
        }
    }
}
