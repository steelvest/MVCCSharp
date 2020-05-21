using MVCCSharp.Models;
using MVCCSharp.Veri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCSharp.Controllers
{
    public class YeniPersonelController : Controller
    {
        // GET: YeniPersonel
        public ActionResult Yeni()
        {
            return View();
        }
        public static Personel uye = new Personel
        {
            Id = 1,
            ad = "Oğuz",
            soyad = "Özgül",
            TCKN = 14133003982,
            dogumtarihi = new DateTime(1984, 06, 01)
        };
        public ActionResult Detail()
        {
            return View(uye);
        }
    }
}