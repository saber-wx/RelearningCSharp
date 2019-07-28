using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRV
{
    class BaseService
    {
        protected const string USER_ID_KEY = "userId";
        private const string USER_AUTH = "userAuth";


        private IHttpContextAccessor _accessor;

        public BaseService(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        //public UserModel GetUser()
        //{
        //    string CurrentUser = _accessor.HttpContext.Request.Cookies[USER_ID_KEY];
        //    UserModel user = new RegisterService().GetById(_accessor);
        //}

    }
}
