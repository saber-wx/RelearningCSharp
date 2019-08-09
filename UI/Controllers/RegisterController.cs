using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using UI.Filters;
using UI.Models.Register;

namespace UI.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        [ImportModelState]
        public ActionResult Index(int? id)
        {

            IndexModel model = new IndexModel
            {
                Cities = new List<Cities>
                {
                    Cities.chengdu,Cities.wuhan
                },
                UserName = "Saber",
                IsMale = true
            };
            ViewData["greet"] = "Hello,Hello";

            ViewBag.Id = id;

            //return View("Failed");//除shared和同一文件夹外，如果需要跳转需要写完整路径带.cshtml后缀
            return View(model);//还可以传model,可以设置默认传值
                               //return PartialView(model);//还可以传model,可以设置默认传值
        }

        [HttpPost]
        [AutoValidationFilter]
        [ImportModelState]
        [OutputCache(Duration = 1000)]
        public ActionResult Index(IndexModel model, string UserName,int? id)
        {
            Thread.Sleep(1000);

            ViewData[Const.TIME] = DateTime.Now;

            if (model.Captcha != Session[CaptchaController.CAPTCHA].ToString())
            {
                ModelState.AddModelError("Captcha", "* 验证码输入错误");
                return View(model);
            }

            ViewBag.userName = UserName;

            return View();
        }

        [ChildActionOnly]
        [OutputCache(Duration = 50,
            Order = 300, VaryByParam = "none")]
        public PartialViewResult Reminder(int? id)//部分
        {

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