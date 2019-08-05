using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models.Message;

namespace UI.Controllers
{
    public class MessageController : Controller
    {

        public ActionResult Mine()
        {
            MineModel model = new MineModel
            {
                Messages = new List<MessageItemModel>
                {
                    new MessageItemModel { Content = "一", Id = 1 },
                    new MessageItemModel { Content = "二", Id = 2 },
                    new MessageItemModel { Content = "三", Id = 3 },
                    new MessageItemModel { Content = "四", Id = 4 }
                }
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Mine(MineModel model)
        {
            foreach (var item in model.Messages)
            {
                if (item.Selected)
                {

                }
            }

            return RedirectToAction("Mine");
        }

    }

}

