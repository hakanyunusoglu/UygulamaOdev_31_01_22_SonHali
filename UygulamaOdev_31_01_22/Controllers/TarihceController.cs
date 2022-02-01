using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UygulamaOdev_31_01_22.Models;
using UygulamaOdev_31_01_22.Models.DTO;

namespace UygulamaOdev_31_01_22.Controllers
{
    
    public class TarihceController : Controller
    {
        // GET: Tarihce
        sinavdbEntities4 db = new sinavdbEntities4();
        TarihceModel tm = new TarihceModel();
        public ActionResult Tarihce()
        {

            List<TarihceDTO> tarihceList = db.Tarihces.Select(x => new TarihceDTO
            {
                Aciklama = x.Aciklama,
                Baslik = x.Baslik,
                Resim = x.Resim
            }).ToList();
            List<OzellikDTO> ozellikList = db.Ozelliks.Select(x => new OzellikDTO
            {
                ButonRenk = x.ButonRenk,
                Icon = x.Icon,
                OzellikAciklama = x.Aciklama
            }).ToList();
            tm.tarihceList = tarihceList;
            tm.ozellikList = ozellikList;
            return View(tm);
        }
    }
}