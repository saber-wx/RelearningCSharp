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
            UserRepository userRepository = new UserRepository();
            userRepository.SetEntities(_articleRepository.CurrentContext);
            Article article = new Article
            {
                Author = userRepository.GetById(authorId),
                Body = body,
                Title = title
            };
            article.Publish();
            return _articleRepository.Save(article);
        }
    }
}
