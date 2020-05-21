using MVCCSharp.Models;
using MVCCSharp.Veri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCSharp.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        public ActionResult Index()
        {
            var model = PersonelVeriler.listPersoneller;
            return View(model);
        }
        [HttpGet]
        public ActionResult veriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult veriEkle(Personel personel)
        {
            PersonelVeriler.listPersoneller.Add(personel);
            return RedirectToAction("Index");
        }
        public ActionResult Duzenle(int Id)
        {
            var model = PersonelVeriler.listPersoneller.Where(m => m.Id == Id).FirstOrDefault();
            return View(model);
        }
        [HttpPost]
        public ActionResult Duzenle(Personel model)
        {
            var guncellenecek = PersonelVeriler.listPersoneller.Where(m => m.Id == model.Id).FirstOrDefault();

            guncellenecek.ad = model.ad;
            guncellenecek.soyad = model.soyad;
            guncellenecek.TCKN = model.TCKN;
            guncellenecek.dogumtarihi = model.dogumtarihi;

            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var silincek = PersonelVeriler.listPersoneller.Where(m => m.Id == id).FirstOrDefault();
            PersonelVeriler.listPersoneller.Remove(silincek);
            return RedirectToAction("Index");
        }
    }
}