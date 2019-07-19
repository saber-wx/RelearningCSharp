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
            User user = new User{Name = userName,Password = password};
            user.Register();
            _userRepository.Save(user);
        }
        
        //public UserModel GetById(int id)
        //{
        //    User user = _userRepository.GetById(id);
        //    return mapFrom(user);
        //}

        public UserModel Login(string userName, string password)
        {
            User user = _userRepository.GetByName(userName);
            if (user == null)
            {
                return null;
            }
            else
            {

                UserModel model = new UserModel();
                model.Id = user.Id;
                model.MD5Password = user.Password;

                return model;
            }

        }

        public bool HasExist(string userName)
        {
            return _userRepository.GetByName(userName) != null;
        }

      


        //检查密码
        public bool PasswordCorrect(string rawPassword, string MD5Password)
        {
            return User.GetMd5Hash(rawPassword) == MD5Password;
        }

        //根据Info取
        public UserModel GetUser( string userName)
        {
            User user = _userRepository.GetByName(userName);
            if (user == null)
            {
                return null;
            }
            else
            {
                UserModel model = new UserModel();
                model.Id = user.Id;
                model.MD5Password = user.Password;

                return model;
            }
        }

        public object getByName(string userName)
        {
            throw new NotImplementedException();
        }
    }

    public class UserModel
    {
        public int Id { get; set; }
        public string MD5Password { get; set; }
    }
}
