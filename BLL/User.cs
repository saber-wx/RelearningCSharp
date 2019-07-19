using BLL.Repository;
using System;
using System.Security.Cryptography;
using System.Text;

namespace BLL
{
    public class User
    {
        //-- 不可更改！！
        private const string _salt = "s$)&a@^b!~#)e%*r";
        //-- 不可更改！！

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public User InvitedBy { get; set; }

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
