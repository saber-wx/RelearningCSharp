using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using System.Collections.Generic;
using Web01.Pages.Shared;
using BLL;

namespace Web01.Pages.Blog
{
    [BindProperties]
    public class SingleModel : _LayoutModel
    {

        private IBlogService _BlogService;
        public SingleModel(IBlogService BlogService, IRegisterService registerService) : base(registerService)
        {
            _BlogService = BlogService;
        }

        public BLL.Blog Blog { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public Post NewPost { get; set; }

        public override void OnGet()

        {
            Blog = _BlogService.Get(Id);
            base.OnGet();
        }

        public void OnPost()
        {
            _BlogService.Comment( Id,NewPost);
            Redirect($"/Blog/single?id={Id}");
        }
    }
}



