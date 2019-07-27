using System;
using System.Collections.Generic;
using System.Text;
using BLL;

namespace SRV
{
    public class MockRegisterService : IRegisterService
    {
        public UserModel GetById(int id)
        {
            if (id==1)
            {
                return new UserModel { Name = "", MD5Password = "1234" };
            }
            else
            {
                return null;
            }
        }

        public UserModel GetByName(string userName)
        {
            throw new NotImplementedException();
        }

        public bool HasExist(string userName)
        {
            throw new NotImplementedException();
        }

        public UserModel MapFrom(User user)
        {
            throw new NotImplementedException();
        }

        public bool PasswordCorrect(string rawPassword, string MD5Password)
        {
            throw new NotImplementedException();
        }

        public User Register(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public bool ValidateEmail(int id, string code)
        {
            throw new NotImplementedException();
        }
    }
}
