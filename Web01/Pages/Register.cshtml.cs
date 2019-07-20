using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using Web01.Pages.Shared;

namespace Web01.Pages
{

    [BindProperties]
    public class RegisterModel : _LayoutModel
    {
        private RegisterService _registerService;

        public RegisterModel()
        {
            _registerService = new RegisterService();
        }

        public Register Register { get; set; }

        //[BindProperty] 
        //[Required(AllowEmptyStrings = true)] 
        public override void OnGet()
        {
            base.OnGet();
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            if (_registerService.HasExist(Register.UserName))
            {
                ModelState.AddModelError("Register.UserName", "*用户名已经存在");
                return;
            }
            _registerService.Register(Register.UserName, Register.Password);
        }

        private void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class Register
    {
        [MustFillInRequired]
        [Display(Name = "用户名")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string UserName { get; set; }


        [DataType(DataType.Password)]
        [MaxLength(16)]
        [MinLength(6)]
        [MustFillInRequired]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Display(Name = "密码")]
        public string Password { get; set; }


        [Compare("Password")]
        [MustFillInRequired]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Display(Name ="验证密码")]
        public string ConfirmPassword { get; set; }
    }
}