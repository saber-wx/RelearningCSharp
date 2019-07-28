using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using Web01.Pages.Shared;

namespace Web01.Pages.Task.History
{
    public class MonthModel : _LayoutModel
    {
        private ArticleService _articleService;
        public MonthModel(ArticleService articleService, IRegisterService registerService) : base(registerService)
        {
            _articleService = articleService;
        }

        public override void OnGet()
        {
            base.OnGet();
        }
    }
}