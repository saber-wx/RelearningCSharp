using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Filters
{
    //继承自授权属性
    public class NeedLogOnAttribute : AuthorizeAttribute
    {
        //授权的时候
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //若cookies能取到用户Id
            HttpContextBase context = filterContext.HttpContext;
            HttpCookie cookieUser = context.Request.Cookies[Const.USER_ID];
            if (cookieUser != null)
            {
                int userId = Convert.ToInt32(cookieUser.Value);
                User user = GetUser(userId);
                if (user != null)
                {
                    if (user.MD5Password == cookieUser[Const.USER_PASSWORD])
                    {

                    }
                }
            }
            string currentPath = context.Request.Url.PathAndQuery;
            context.Response.Cookies.Add(new HttpCookie("PrePage", currentPath));

            filterContext.Result = new RedirectResult("/Log/On");
            //base.OnAuthorization(filterContext);
        }

        private User GetUser(int userId)
        {
            return new User();
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MD5Password { get; internal set; }
    }
}