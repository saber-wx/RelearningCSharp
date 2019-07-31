using AutoMapper;
using BLL;
using BLL.Repository;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SRV
{
    public class BaseService
    {
        protected const string USER_ID_KEY = "userId";
        private const string USER_AUTH = "userAuth";

        protected UserRepository userRepository;
        protected IHttpContextAccessor accessor;

        protected static MapperConfiguration autoMapperconfig;
        static BaseService()
        {
            autoMapperconfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Blog, Blog>(MemberList.None);
                cfg.CreateMap<Blog, Blog>(MemberList.None);
            });

        }

        public BaseService(IHttpContextAccessor accessor, UserRepository userRepository)
        {
            this.accessor = accessor;
            this.userRepository = userRepository;

        }

        protected IMapper mapper
        {
            get
            {
                return autoMapperconfig.CreateMapper();
            }
        }

        /// <summary>
        /// 当前用户
        /// </summary>
        protected User CurrentUser
        {
            get
            {
                string currentUserId = accessor.HttpContext.Request.Cookies[USER_ID_KEY];
                if (currentUserId != null)
                {
                    return userRepository.GetById(Convert.ToInt32(currentUserId));
                }

                return null;
            }
        }

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
        //                if (userAuthValue == model.MD5Password)
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
