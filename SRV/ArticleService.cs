using AutoMapper;
using BLL;
using BLL.Repository;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            return mapper.Map<Article, DTOArticle>(article);
        }

        public Article Publish(DTOArticle dArticle)
        {

            Article article = mapper.Map<DTOArticle, Article>(dArticle);
            article.Author = CurrentUser;
            article.Publish();
            return _articleRepository.Save(article);
        }
    }

    public class DTOArticle
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
    }
}
