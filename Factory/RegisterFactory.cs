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
            _registerService.Register("小明",Helper.PASSWORD);
            _registerService.Register("老王",Helper.PASSWORD);

        }
    }
}
