using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Filters;

namespace UI.Controllers
{
    public class AdController:Controller
    {

        [ContextPerRequest]
        [ErrorLog]
        [NeedLogOn]
        public ActionResult Write()
        {
            return View();
        }
    }
}