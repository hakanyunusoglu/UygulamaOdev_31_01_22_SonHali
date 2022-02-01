using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UygulamaOdev_31_01_22.Models.DTO
{
    public class UrunDTO
    {
        public int UrunID { get; set; }
        public string UrunResim { get; set; }
        public string UrunAD { get; set; }
        public string Aciklama { get; set; }
        public decimal Fiyat { get; set; }
        public int KategoriID { get; set; }
        public string KategoriADI { get; set; }

        public Urunler urunler { get; set; }
    }
}