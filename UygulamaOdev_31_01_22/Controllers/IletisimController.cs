using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UygulamaOdev_31_01_22.Models;
using UygulamaOdev_31_01_22.Models.DTO;

namespace UygulamaOdev_31_01_22.Controllers
{
    public class IletisimController : Controller
    {
        sinavdbEntities4 db = new sinavdbEntities4();
        // GET: Iletisim
        public ActionResult Iletisim()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Iletisim(Iletisim im)
        {
            db.Entry(im).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            return RedirectToAction("Index","Anasayfa");
        }
    }
}