using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using Web01.Pages.Shared;

namespace Web01.Pages.Problem
{
    [BindProperties]
    public class NewModel : _LayoutModel
    {
        private ArticleService _articleService;
        public NewModel(ArticleService articleService, IRegisterService registerService) : base(registerService)
        {
            _articleService = articleService;
        }

        public  string Title { get; set; }
        public  string Body { get; set; }

        public override void OnGet()
        {
            base.OnGet();
        }
    }
}