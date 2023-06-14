using HastaneOtomasyon.Business;
using HastaneOtomasyon.Core.DependencyResolvers;
using HastaneOtomasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace HastaneOtomasyon
{
    public partial class DoktorKayit : System.Web.UI.Page
    {
        private DoktorManager manager;

        public DoktorKayit()
        {
            manager = HastaneManagementFactory.CreateDoktorManager();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            manager.Add(new Entities.Doktor
            {
                DoktorAdi = txtIsim.Text,
                DoktorSoyAdi = txtSoyIsim.Text,
                DoktorUzmanlik = txtAlan.Text,
                DoktorTel = txtTel.Text,
            });
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            manager.Add(new Entities.Doktor
            {
                DoktorID = Convert.ToInt32(txtID.Text),
                DoktorAdi = txtIsim.Text,
                DoktorSoyAdi = txtSoyIsim.Text,
                DoktorUzmanlik = txtAlan.Text,
                DoktorTel = txtTel.Text,
            });

        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            manager.Delete(new Entities.Doktor
            {
                DoktorID = Convert.ToInt32(txtID.Text),
                DoktorAdi = txtIsim.Text,
                DoktorSoyAdi = txtSoyIsim.Text,
                DoktorUzmanlik = txtAlan.Text,
                DoktorTel = txtTel.Text,
            });
        }

        protected void btnGetAllData_Click(object sender, EventArgs e)
        {
            
            gwTablo.DataSource = manager.GetAll();
            gwTablo.DataBind();

        }
    }
}