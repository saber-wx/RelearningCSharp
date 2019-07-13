using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;

namespace Web01.Pages
{
    [BindProperties]
    public class RegisterModel : PageModel
    {
        public Register Register { get; set; }
        public void OnGet()
        {
            ViewData["title"] = "注册";
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            new RegisterService().Register(Register.UserName,Register.Password);
        }

        private void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class Register
    {
        //[YQBRequired]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }
}