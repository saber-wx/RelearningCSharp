using BLL;
using BLL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    internal class RegisterFactory
    {
        internal static User Saber, Lancer, Caster;
        private static UserRepository _registerFactory;
        static RegisterFactory()
        {
            //_registerFactory = new UserRepository();
        }
        internal static void Create()
        {
            Saber = register("saber");
            Lancer = register("lancer");
            Caster = register("caster");

        }

        private static User register(string name)
        {
            User user = new User { Name = name, Password = Helper.PASSWORD };
            user.Register();
            _registerFactory.Save(user);
            return user;
        }
    }
}
