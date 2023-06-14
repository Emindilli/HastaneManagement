using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HastaneOtomasyon.Entities
{
    public class Doktor
    {
        public int DoktorID { get; set; }
        public string DoktorAdi { get; set; }
        public string DoktorSoyAdi { get; set; }
        public string DoktorUzmanlik { get; set; }
        public string DoktorTel { get; set; }
    }
}