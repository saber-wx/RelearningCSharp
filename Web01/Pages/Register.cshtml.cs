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
        private RegisterService _registerService;
         
        public RegisterModel()
        {

                _registerService = new RegisterService();

           
        }

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

            if (_registerService.HasExist(Register.UserName))
            {
                ModelState.AddModelError("Register.UserName", "*用户名重复");
                return;
            }
            _registerService.Register(Register.UserName,Register.Password);
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