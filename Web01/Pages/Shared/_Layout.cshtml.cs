using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web01.Pages.Shared
{
    public class _LayoutModel : PageModel
    {
        protected const string USER_ID_KEY = "userId";
        private const string USER_AUTH = "userAuth";

        public IRegisterService _registerService;
        public _LayoutModel(IRegisterService registerService)
        {
            _registerService = registerService;
        }
        //public int? CurrentUserId
        //{
        //    get
        //    {
        //        string userIdValue;
        //        if (Request.Cookies.TryGetValue(USER_ID_KEY, out userIdValue))
        //        {
        //            UserModel model = _registerService.GetById(Convert.ToInt32(userIdValue));

        //            if (Request.Cookies.TryGetValue(USER_AUTH, out string userAuthValue))
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

        public virtual void OnGet()
        {

            string userIdValue;
            if (Request.Cookies.TryGetValue(USER_ID_KEY, out userIdValue))
            {
                UserModel model = _registerService.GetById(Convert.ToInt32(userIdValue));
                if (model != null)
                {
                    if (Request.Cookies.TryGetValue(USER_AUTH, out string userAuthValue))
                    {
                        if (userAuthValue == model.MD5Password)
                        {
                            ViewData["UserName"] = model.Name;
                        }
                    }
                }
            }
        }

    }
}
