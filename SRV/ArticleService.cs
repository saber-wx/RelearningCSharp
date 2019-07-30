using AutoMapper;
using BLL;
using BLL.Repository;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SRV
{
    public class ArticleService : BaseService, IArticleService
    {

        private ArticleRepository _articleRepository;

        public ArticleService(IHttpContextAccessor accessor, 
            ArticleRepository articleRepository, 
            UserRepository userRepository):base(accessor,userRepository)
        {
            _articleRepository = articleRepository;
        }

        public DTOArticle Get(int id)
        {
            Article article = _articleRepository.Get(id);

            return new DTOArticle
            {
                Title = article.Title,
                Body = article.Body
            };
            //return mapper.Map<Article, DTOArticle>(article);
        }

        public Article Publish(string title, string body)
        {

            Article article = new Article
            {
                Author = CurrentUser,
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
