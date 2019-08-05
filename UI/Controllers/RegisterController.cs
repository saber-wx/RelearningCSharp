using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models.Register;

namespace UI.Controllers
{
    public class RegisterController : Controller
    {

        public ActionResult Index(int? id)
        {

            IndexModel model = new IndexModel
            {
                UserName = "Saber",
                IsMale = true
            };
            ViewData["greet"] = "Hello,Hello";

            ViewBag.Id = id;

            //return View("Failed");//除shared和同一文件夹外，如果需要跳转需要写完整路径带.cshtml后缀
            //return View(model);//还可以传model,可以设置默认传值
            return PartialView(model);//还可以传model,可以设置默认传值
        }

        [HttpPost]
        public ActionResult Index(IndexModel model, string UserName)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            ViewBag.userName = UserName;

            return View();
        }

        [ChildActionOnly]
        public PartialViewResult Reminder(int? id)//部分
        {
            //User user = new User
            //{
            //    ID = 22,
            //    Name = "saber"
            //};

            ViewBag.Id = id;
            return PartialView();
        }

        //public ActionResult Index(/*string userNanme, IndexModel model*/)
        //{
        //    //if (!ModelState.IsValid)
        //    //{
        //    //    return View(model);
        //    //}

        //    //ViewBag.userName = userNanme;

        //    ////return File();
        //    return View();
        //}



    }
}