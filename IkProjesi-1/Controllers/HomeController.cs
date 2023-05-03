using IkProjesi_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IkProjesi_1.Controllers
{
    public class HomeController : Controller
    {
        PersonelContext db = new PersonelContext();
        // GET: Home
        public ActionResult Index()
        {
          var personelListesi =  db.Personel41.Include("Unvan2").Where(x=>x.AktifMi == 1).ToList();
            return View(personelListesi);
        }
       
    }
}