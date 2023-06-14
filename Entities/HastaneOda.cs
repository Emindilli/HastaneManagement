using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HastaneOtomasyon.Entities
{
    public class HastaneOda
    {
        public int OdaID { get; set; }
        public int OdaNo { get; set; }

        public string OdaTipi { get; set; }
        public string DolulukDurumu { get; set; }

    }
}