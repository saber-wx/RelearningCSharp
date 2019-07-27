using BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRV
{
    public interface IRegisterService
    {
        User Register(string userName, string password);

        UserModel GetById(int id);

        //比较用户输入的密码和数据存储的密码
        bool PasswordCorrect(string rawPassword, string MD5Password);

        UserModel MapFrom(User user);

        bool HasExist(string userName);
        
        bool ValidateEmail(int id, string code);

        UserModel GetByName(string userName);



    }
}
