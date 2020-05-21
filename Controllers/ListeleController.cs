using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCSharp.Controllers
{
    public class ListeleController : Controller
    {
        // GET: Listele
        public ActionResult Listele()
        {
            if (TempData["deger"] == null)
            {
                ViewBag.Deger = new List<int>();
            } else
            {
                ViewBag.Deger = TempData["deger"];
            }
           
            return View();
        }
        public ActionResult VeriGetir()
        {
            List<int> listDegerler = new List<int>();
            listDegerler.Add(23);
            listDegerler.Add(453);
            listDegerler.Add(43);
            listDegerler.Add(11);
            listDegerler.Add(888);

            TempData["deger"] = listDegerler;
            return RedirectToAction("Listele");
        }
    }
}