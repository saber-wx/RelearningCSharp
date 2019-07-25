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
        private ArticleService _articleService;

        public NewModel()
        {
            _articleService = new ArticleService();
        }

        public string Title { get; set; }
        public string Body { get; set; }
        public override void OnGet()
        {
            base.OnGet();
        }

        public void OnPost()
        {
           
            if (!ModelState.IsValid)
            {
                return;
            }
            _articleService.Publish(Title, Body, CurrentUserId.Value);
        }
    }
}