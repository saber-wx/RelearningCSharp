using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using System.Collections.Generic;
using Web01.Pages.Shared;

namespace Web01.Pages.Blog
{
    [BindProperties]
    public class IndexModel : _LayoutModel
    {

        private IBlogService _BlogService;
        public IndexModel(IBlogService BlogService, IRegisterService registerService) : base(registerService)
        {
            _BlogService = BlogService;
        }

  

        public IList<BLL.Blog> Blogs { get; set; }


        public override void OnGet()
        {
            Blogs = _BlogService.Get();
            base.OnGet();
        }
    }
}



