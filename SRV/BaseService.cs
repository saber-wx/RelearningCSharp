
using AutoMapper;
using BLL;
using BLL.Repository;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRV
{
    public class BaseService
    {
        protected const string USER_ID_KEY = "userId";
        private const string USER_AUTH = "userAuth";

        protected UserRepository _userRepository;
        protected static MapperConfiguration autoMapperconfig;

        protected IHttpContextAccessor _accessor;

        public BaseService(IHttpContextAccessor accessor, UserRepository userRepository)
        {
            _accessor = accessor;
            _userRepository = userRepository;
            autoMapperconfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Article, DTOArticle>();
            });
#if DEBUG
            autoMapperconfig.AssertConfigurationIsValid();
            // use DI (http://docs.automapper.org/en/latest/Dependency-injection.html) or create the mapper yourself
#endif         
        }

        protected IMapper mapper
        {
            get
            {
                return autoMapperconfig.CreateMapper();
            }
        }

        //protected User currentUser
        //{
        //    get
        //    {
                

        //    }
        //}

        //public int? CurrentUserId
        //{
        //    get
        //    {
        //        string userIdValue;
        //        if (_accessor.HttpContext.Request.Cookies.TryGetValue(USER_ID_KEY, out userIdValue))
        //        {
        //            UserModel model = _registerService.GetById(Convert.ToInt32(userIdValue));

        //            if (_accessor.HttpContext.Request.Cookies.TryGetValue(USER_AUTH, out string userAuthValue))
        //            {
        //                if (_accessor.HttpContext.userAuthValue == model.MD5Password)
        //                {
        //                    return model.Id;
        //                }
        //            }
        //        }
        //        return null;
        //    }
        //    set
        //    {
        //    }
        //}

    }
}
