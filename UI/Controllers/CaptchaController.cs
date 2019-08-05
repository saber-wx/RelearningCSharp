using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing.Imaging;

namespace UI.Controllers
{

    public class CaptchaController : Controller
    {

        public const string CAPTCHA = "captcha";

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Get()
        {
            byte[] captcha = MakeCaptcha(out string value);

            Session["CAPTCHA"] = value;

            return File(captcha, "jpg");
            //return File("~/Content/沙雕网友笑死了.png", "png","沙雕网友");
        }

        public byte[] MakeCaptcha(out string value)
        {

            Bitmap bitmap = new Bitmap(60, 24);
            Graphics graphics = Graphics.FromImage(bitmap);
            Font font = new Font("Arial", 12, (FontStyle.Bold | FontStyle.Italic));
            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                Color.DarkCyan, Color.AliceBlue, 1.2f, true);

            value = new Random().Next(1000, 9999).ToString();

            graphics.DrawString(value, font, brush, 3, 2);

            MemoryStream stream = new MemoryStream();
            bitmap.Save(stream, ImageFormat.Jpeg);

            return stream.ToArray();
        }
    }



}

