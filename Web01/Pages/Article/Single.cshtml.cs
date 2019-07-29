using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using System.Collections.Generic;
using Web01.Pages.Shared;

namespace Web01.Pages.Article
{
    [BindProperties]
    public class SingleModel : _LayoutModel
    {

        private IArticleService _articleService;
        public SingleModel(IArticleService articleService, IRegisterService registerService) : base(registerService)
        {
            _articleService = articleService;
        }

        public DTOArticle article { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public override void OnGet()
        {
            article = _articleService.Get(Id);
            base.OnGet();

        }
    }
}



