using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UygulamaOdev_31_01_22.Models.DTO;

namespace UygulamaOdev_31_01_22.Models
{
    public class IletisimModel
    {
        public List<IletisimDTO> iletisimList { get; set; }
        public Iletisim iletisim { get; set; }
    }
}