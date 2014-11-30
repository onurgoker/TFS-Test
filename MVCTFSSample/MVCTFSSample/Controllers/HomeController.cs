using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTFSSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //fsdfsdfs
            ViewBag.Message = "Çok Özel Bir Mesaj.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Uygulama Açıklama Sayfası.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "İletişim Sayfası.";

            return View();
        }
    }
}
