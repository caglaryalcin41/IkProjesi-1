using IkProjesi_1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IkProjesi_1.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    public class UnvanController : Controller
    {
        PersonelContext db = new PersonelContext();
        // GET: Admin/Unvan
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UnvanListesi()
        {
            List<Unvan> Unvans = db.Unvan.ToList();

            TempData["Unvan"] = "Çağlar Yalçın";
            return View(Unvans);
        }

        [HttpGet]
        public ActionResult UnvanEkleme()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UnvanEkleme(Unvan Unvan)
        {
            if (ModelState.IsValid)
            {
                Unvan.AktifMi = 1;
                Unvan.CreatedBy = 1;
                Unvan.CreatedOn = DateTime.Now;
                db.Unvan.Add(Unvan);
                db.SaveChanges();
                return RedirectToAction("UnvanListesi");
            }
            return View();
        }


        public ActionResult UnvanDuzenle(int Id)
        {
            Unvan Unvan = db.Unvan.Find(Id);
            return View(Unvan);
        }

        [HttpPost]
        public ActionResult UnvanDuzenle(Unvan Unvan)
        {
            if (ModelState.IsValid)
            {
                Unvan.EditedOn = DateTime.Now;
                Unvan.EditedBy = 1;
                db.Entry(Unvan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("UnvanListesi");
            }
            return View();
        }

        public ActionResult UnvanSil(int Id)
        {
            Unvan Unvan = db.Unvan.Find(Id);
            string UnvanListesi = TempData["Unvan"].ToString();
            return View(Unvan);
        }

        [HttpPost]
        public ActionResult UnvanSil(Unvan Unvan)
        {
            if (ModelState.IsValid)
            {
                Unvan.DeletedOn = DateTime.Now;
                Unvan.AktifMi = 0;
                db.Entry(Unvan).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("UnvanListesi");
            }
            return View(Unvan);
        }
    }
}