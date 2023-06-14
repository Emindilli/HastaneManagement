using HastaneOtomasyon.Business;
using HastaneOtomasyon.Core.DependencyResolvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HastaneOtomasyon
{
    public partial class Tablo : System.Web.UI.Page
    {
        private DoktorManager manager;
        private HastaManager managerr;

        public Tablo()
        {
            manager = HastaneManagementFactory.CreateDoktorManager();
            managerr = HastaneManagementFactory.CreateHastaManager();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            gwTablo.DataSource = manager.GetAll();
            gwTablo.DataBind();
            gwTablo2.DataSource = managerr.GetAll();
            gwTablo2.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}