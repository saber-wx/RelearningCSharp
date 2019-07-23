//using BLL;
//using BLL.Repository;
//using System;
//using System.Collections.Generic;
//using System.Text;

////namespace Factory
////{
////    internal class RegisterFactory
////    {
////        internal static User Saber, Lancer, Caster;
////        private static UserRepository _userRepository;
////        static RegisterFactory()
////        {
////            _userRepository = new UserRepository();
////        }
////        internal static void Create()
////        {

////            Saber = register("saber");
////            Lancer = register("lancer");
////            Caster = register("caster");

////        }

////        private static User register(string name)
////        {
////            User user = new User { Name = name, Password = Helper.PASSWORD };
////            Saber.Register();
////            _userRepository.Save(user);
////            return user;
////        }
////    }
////}

using BLL;
using SRV;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    internal class RegisterFactory
    {
        internal static User Saber, Lancer, Caster;
        private static RegisterService _registerService;
        static RegisterFactory()
        {
            _registerService = new RegisterService();
        }
        internal static void Create()
        {
            Saber = _registerService.Register("saber", Helper.PASSWORD);
            Lancer = _registerService.Register("lancer", Helper.PASSWORD);
            Caster = _registerService.Register("caster", Helper.PASSWORD);
        }
    }
}
