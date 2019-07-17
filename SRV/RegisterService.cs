using BLL;
using BLL.Repository;
using System;

namespace SRV
{
    public class RegisterService
    {
        public UserRepository _userRepository;
        public RegisterService()
        {
            _userRepository = new UserRepository();
        }
        public void Register(string userName, string password)
        {

            User user = new User
            {
                Name = userName,
                Password = password
            };
            user.Register();

            _userRepository.Save(user);
        }

        public bool HasExist(string userName)
        {
            return _userRepository.GetByName(userName) != null;
        }
    }
}
