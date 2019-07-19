using SRV;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
   internal class RegisterFactory
    {
        private static RegisterService _registerService;
        public RegisterFactory()
        {
            _registerService = new RegisterService();
        }
        internal static void Create()
        {
            _registerService.Register("张三",Helper.PASSWORD);
            _registerService.Register("王五",Helper.PASSWORD);

        }
    }
}
