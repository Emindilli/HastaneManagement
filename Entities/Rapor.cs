using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HastaneOtomasyon.Entities
{
    public class Rapor
    {
        public int RaporID { get; set; }
        public int HastaID { get; set; }
        public int DoktorID { get; set; }
        public string RaporIcerik { get; set; }
        public int RaporTarihi { get; set; }

    }
}