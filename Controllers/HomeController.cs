using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCSharp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Anasayfa()
        {
            return View();
        }
        public ActionResult Hakkimizda()
        {
            ViewData["Hak"] = "MVC Birden veri kullanilir View Data";
            ViewBag.hakkimizda = "MVC Üçten beri kullanılır View Bag";
            TempData["Hakkimizda"] = "MVC Üçten beri kullanılır TempData";
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }
        public ActionResult Nestet()
        {
            return View();
        }
        public ActionResult Partial()
        {
            return View();
        }
    }
}