using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using Web01.Pages.Shared;

namespace Web01.Pages.Log
{
    public class OffModel : _LayoutModel
    {
        private ArticleService _articleService;
        public OffModel(ArticleService articleService, IRegisterService registerService) : base(registerService)
        {
            _articleService = articleService;
        }
        public override void OnGet()
        {
            if (Request.Cookies["userId"] != null && Request.Cookies["userAuth"] != null)
            {
                Response.Cookies.Delete("userId");
                Response.Cookies.Delete("userAuth");
            }
        }

        public IActionResult OnPost()
        {
            return RedirectToPage("/index");
        }
    }
}