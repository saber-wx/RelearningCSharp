using BLL;
using BLL.Repository;
using System;

namespace SRV
{
    public class RegisterService
    {
        public void Register(string userName, string password)
        {
            User user = new User
            {
                Name = userName,
                Password = password
            };
            user.Register();

            new UserRepository().Save(user);
        }

        public bool HasExist(string userName)
        {
          return  new UserRepository().GetByName(userName)!=null;
        }
    }
}
