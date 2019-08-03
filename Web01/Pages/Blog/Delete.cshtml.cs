using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;

namespace Web01.Pages.Blog
{
    public class DeleteModel : PageModel
    {
        private IBlogService _blogService;
        public DeleteModel(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public void OnGet()
        {
            _blogService.Delete(Id);
        }
    }
}