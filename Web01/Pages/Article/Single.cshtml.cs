using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using Web01.Pages.Shared;

namespace Web01.Pages.Article
{
    [BindProperties]
    public class SingleModel : _LayoutModel
    {
        private ArticleService _articleService;
        //public SingleModel(ArticleService articleService, IRegisterService registerService) : base(registerService)
        //{
        //    _articleService = articleService;
        //    id = Request.Query["id"];
        //}
        public string Title { get; set; }
        public string Body { get; set; }
        public string id;
        public new void OnGet()
        {
            ViewData["id"] = id;
            base.OnGet();
            
        }


    }
}