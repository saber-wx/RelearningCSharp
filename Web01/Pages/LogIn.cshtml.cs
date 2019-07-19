﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using SRV;

namespace Web01.Pages
{
    [BindProperties]
    public class LogInModel : PageModel
    {
        private const string _userId = "userId";
        public string Greet = "Hello,一起帮欢迎您！";

        private RegisterService _registerService;
        public LogInModel()
        {
            _registerService = new RegisterService();
        }

        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            UserModel model = _registerService.GetUser(UserName);

            if (model == null)
            {
                ModelState.AddModelError("UserName", "* 用户名不存在");
                return Page();
            }

            if (!_registerService.PasswordCorrect(Password, model.MD5Password))
            {
                ModelState.AddModelError("Password", "* 用户名或密码错误");
                return Page();
            }
            
            Response.Cookies.Append(_userId, model.Id.ToString(),new CookieOptions { IsEssential = true });
            Response.Cookies.Append(_userId, model.MD5Password);

            return Page();

        }
    }
}