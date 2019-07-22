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
        protected const string userIdKey = "userId";
        private const string userAuth = "userAuth";

        public virtual void OnGet()
        {
            string userIdValue;
            if (Request.Cookies.TryGetValue(userIdKey, out userIdValue))
            {
                UserModel model = new RegisterService().GetById(Convert.ToInt32(userIdValue));
                if (model != null)
                {
                    if (Request.Cookies.TryGetValue(userAuth, out string userAuthValue))
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
