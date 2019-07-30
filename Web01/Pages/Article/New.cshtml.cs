using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using SRV;
using Web01.Pages.Shared;

namespace Web01.Pages.Article
{
    [BindProperties]
    public class NewModel : _LayoutModel
    {
        public Article Article { get; set; }
        private IArticleService _articleService;
        public NewModel(IArticleService articleService, IRegisterService registerService) : base(registerService)
        {
            _articleService = articleService;

        }

        public override void OnGet()
        {
            base.OnGet();
        }

        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            int id = _articleService.Publish(Article.Title, Article.Body).Id;
            return Redirect("/Article/Single?id=" + id);
        }
    }

    public class Article
    {
        public string Title { get; set; }
        public string Body { get; set; }
    }
}