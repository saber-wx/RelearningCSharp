using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Filters
{
    public class ImportModelState:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Controller.ViewData.ModelState.Merge(
             (ModelStateDictionary)(filterContext.Controller.TempData[Const.ERROR_DATA]));
            base.OnActionExecuting(filterContext);
        }
    }
}