using BLL;
using BLL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRV
{
    public class ArticleService
    {
        private ArticleRepository _articleRepository;
        public ArticleService()
        {
            _articleRepository = new ArticleRepository();
        }

        public Article Publish(string title, string body, int authorId)
        {
            Article article = new Article
            {
                //Author = new UserRepository().GetById(authorId),
                Body = body,
                Title = title
            };
            article.Publish();
            return _articleRepository.Save(article);
        }
    }
}
