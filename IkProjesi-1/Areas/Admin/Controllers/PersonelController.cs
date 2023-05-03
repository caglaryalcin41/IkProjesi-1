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
    public class PersonelController : Controller
    {
        PersonelContext db = new PersonelContext();
        // GET: Admin/Personel
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult KisiListesi()
        { 
            List<Personel> personels = db.Personel41.Include(x=>x.Unvan2).ToList();
            

 
 
            TempData["personel"] = "Çağlar Yalçın";
            return View(personels);
        }

        [HttpGet]
        public ActionResult KisiEkleme()
        {
           ViewBag.UnvanId = new SelectList(db.Unvan.ToList(), "Id", "ReservedName");
            return View();
        }
  

        [HttpPost]
        public ActionResult KisiEkleme(Personel personel)
        {
            ViewBag.UnvanId = new SelectList(db.Unvan.ToList(), "Id", "ReservedName");

            if (ModelState.IsValid)
            {
                personel.AktifMi = 1;
                personel.CreatedBy = 1;
                personel.CreatedOn = DateTime.Now;
                db.Personel41.Add(personel);
                db.SaveChanges();
                return RedirectToAction("KisiListesi");
            }
            return View();
        }
         

        public ActionResult KisiDuzenle(int Id)
        {
          Personel personel =  db.Personel41.Find(Id);
            ViewBag.UnvanId = new SelectList(db.Unvan.ToList(), "Id", "ReservedName");
            return View(personel);
        }

        [HttpPost]
        public ActionResult KisiDuzenle(Personel personel)
        {
            if (ModelState.IsValid)
            {
                personel.EditedOn = DateTime.Now;
                personel.EditedBy = 1;
                db.Entry(personel).State  = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("KisiListesi");
            }
            return View();
        } 

        public ActionResult KisiSil(int Id)
        {
           Personel personel=  db.Personel41.Find(Id);
            string personelListesi = TempData["personel"].ToString();
            return View(personel);
        }

        [HttpPost]
        public ActionResult KisiSil(Personel personel)
        {
            if (ModelState.IsValid)
            {
                personel.DeletedOn = DateTime.Now;
                personel.AktifMi = 0;
                db.Entry(personel).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("KisiListesi");
            }
            return View(personel);
        }

        public ActionResult KisiAktifEt(int Id)
        {
            ViewBag.Id = Id;
            string degisken = TempData["personel"].ToString();
            ViewBag.Ad = degisken;
            return View();
        }
         
        public ActionResult KisiAktifEtOn(int Id)
        {
           
            Personel personel = db.Personel41.Find(Id);
            if (ModelState.IsValid)
            {
                personel.ActiveOn = DateTime.Now;
                personel.ActivetedBy = 1;
                personel.AktifMi = 1;
                db.Entry(personel).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("KisiListesi");
            }
            return View(personel);
        }
    }
}