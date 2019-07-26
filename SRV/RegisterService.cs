using BLL;
using BLL.Repository;
using System;

namespace SRV
{
    public class RegisterService
    {
        public UserRepository _userRepository;
        public EmailRepository _emailRepository;
        public RegisterService()
        {
            _userRepository = new UserRepository();
        }

        //public User Register(string userName, string password)
        //{
        //    User user = new User{Name = userName,Password = password};
        //    user.Register();
        //    _userRepository.Save(user);
        //    return user;
        //}

        //public UserModel GetById(int id)
        //{
        //    User user = _userRepository.GetById(id);
        //    return MapFrom(user);
        //}

        //private UserModel MapFrom(User user)
        //{
        //    if (user == null)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        UserModel model = new UserModel
        //        {
        //            Id = user.Id,
        //            Name = user.Name,
        //            MD5Password = user.Password
        //        };
        //        return model;
        //    }
        //}

        //public UserModel GetByName(string userName)
        //{
        //    User user = _userRepository.GetByName(userName);
        //    return MapFrom(user);
        //}

        //public UserModel Login(string userName, string password)
        //{
        //    User user = _userRepository.GetByName(userName);
        //    if (user == null)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        UserModel model = new UserModel();
        //        model.Id = user.Id;
        //        model.MD5Password = user.Password;
        //        return model;
        //    }
        //}

        //public bool HasExist(string userName)
        //{
        //    return _userRepository.GetByName(userName) != null;
        //}

        ////比较用户输入的密码和数据存储的密码
        //public bool PasswordCorrect(string rawPassword, string MD5Password)
        //{
        //    return User.GetMd5Hash(rawPassword) == MD5Password;
        //}

        ////在Service层通过Repository获得用户信息： 
        //public UserModel GetUser( string userName)
        //{
        //    User user = _userRepository.GetByName(userName);
        //    if (user == null)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        UserModel model = new UserModel();
        //        model.Id = user.Id;
        //        model.MD5Password = user.Password;

        //        return model;
        //    }
        //}

        //public bool ValidateEmail(int id,string code)
        //{
        //    Email email = _emailRepository.Get(id);
        //    email.Validate();
        //    _userRepository.Flush();
        //    return email.ValidationCode == code;
        //}



        UserModel GetByName(string userName)
        {
            User user = _userRepository.GetByName(userName);
            return MapFrom(user);
        }

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

        

        //在Service层通过Repository获得用户信息： 
        public UserModel GetUser(string userName)
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

    }

    //Service层向UI层传递数据的容器： 
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MD5Password { get; set; }
    }
}
