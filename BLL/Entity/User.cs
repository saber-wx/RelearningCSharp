using BLL.Repository;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace BLL
{
    public class User:Entity
    {
        //-- 不可更改！！
        private const string _salt = "s$)&a@^b!~#)e%*r";
        //-- 不可更改！！

        public string Name { get; set; }
        [Required]
        public string Password { get; set; }

        [NotMapped]
        public string ConfirmPassword { get; set; }

        //public User InvitedBy { get; set; }

        public virtual Email Email { get; set; }

        public virtual IList<Article> Article { get; set; }

        public void Register()
        {
            //if (InvitedBy !=null) 
            //{
            //    Message.Send("", InvitedBy);
            //}

            Password = (GetMd5Hash(Password));
        }

        public static string GetMd5Hash(string input)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                //1. 将字符串转换成byte[]
                //2. 进行MD5加密运算
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input + _salt));

                //StringBuilder提高性能（其实也提高了可读性）
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }

        }

        public static bool IsNameDuplicated(string name)
        {
            return false;

        }

        public bool IsPasswordValid()
        {
            return Password.Length >= 4;
        }
    }
}
