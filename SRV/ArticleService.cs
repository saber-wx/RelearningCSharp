using BLL;
using BLL.Repository;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SRV
{
    public class ArticleService : IArticleService
    {

        private ArticleRepository _articleRepository;
        private IHttpContextAccessor _accessor;
        private UserRepository _userRepository;

        public ArticleService(IHttpContextAccessor accessor, ArticleRepository articleRepository, UserRepository userRepository)
        {
            _accessor = accessor;
            _articleRepository = articleRepository;
            _userRepository = userRepository;
        }

        public DTOArticle Get(int id)
        {
            Article article = _articleRepository.Get(id);
            return new DTOArticle
            {
                Title = article.Title,
                Body = article.Body
            };
        }

        public Article Publish(string title, string body, int authorId)
        {
            string CurrentUser = _accessor.HttpContext.Request.Cookies[""];
            Article article = new Article
            {
                Author = _userRepository.GetById(authorId),
                Body = body,
                Title = title
            };
            article.Publish();
            return _articleRepository.Save(article);
        }
    }

    public class DTOArticle
    {
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
