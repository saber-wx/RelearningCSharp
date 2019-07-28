using BLL;
using BLL.Repository;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SRV
{
    public class ArticleService
    {

        private ArticleRepository _articleRepository;
        private IHttpContextAccessor _accessor;

        public ArticleService()
        {

        }
        public ArticleService(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
            _articleRepository = new ArticleRepository();
        }

        public Article Publish(string title, string body, int authorId)
        {
            string CurrentUser = _accessor.HttpContext.Request.Cookies[""];
            UserRepository userRepository = new UserRepository();
            userRepository.SetEntities(_articleRepository._dbContext);
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
