using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HastaneOtomasyon.Entities
{
    public class Hasta
    {
        public int HastaID { get; set; }
        public string HastaAdi { get; set; }
        public string HastaSoyAdi { get; set; }
        public string HastaDogumTarihi { get; set; }
        public string HastaCinsiyet { get; set; }
        public string HastaTel { get; set; }
        public string HastaAdres { get; set; }
    }
}