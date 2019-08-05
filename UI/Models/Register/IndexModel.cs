using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UI.Models.Register
{
    public class IndexModel
    {

        [Required(ErrorMessage = "用户名不能为空")]
        public string UserName { get; set; }

        public string Password { get; set; }

        public bool? IsMale { get; set; }

        public string SelfIntroduction { get; set; }

        public Cities? InCity { get; set; }

        public User Inviter { get; set; }

        public bool RemberMe { get; set; }

    }

    public enum Cities
    {
        chongqing,
        chengdu,
        [Display(Name = "武汉")]
        wuhan
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}