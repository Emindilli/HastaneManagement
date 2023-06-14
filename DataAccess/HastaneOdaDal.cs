using HastaneOtomasyon.Business;
using HastaneOtomasyon.Core.DependencyResolvers;
using HastaneOtomasyon.Entities;
using KutuphaneOtomasyonu.DataAccess.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HastaneOtomasyon.DataAccess
{
    public class HastaneOdaDal
    {
        private DataAccessBase _base;

        public HastaneOdaDal()
        {
            _base = HastaneManagementFactory.CreateDataAccessBase();
        }

        public List<HastaneOda> GetAll()
        {
            string sqlSentence = "SELECT * FROM HastaneOdaTbl";
            var result = _base.Get(sqlSentence);
            return ParseToList(result);
        }

        public void Add(HastaneOda hastaneOda)
        {
            string sqlSentence = $"INSERT INTO HastaneOdaTbl (OdaID, OdaNo, OdaTipi, DolulukDurumu) VALUES ({hastaneOda.OdaID}, " +
                $"{hastaneOda.OdaNo},'{hastaneOda.OdaTipi}','{hastaneOda.DolulukDurumu}')";
            _base.Post(sqlSentence);
        }

        public void Delete(HastaneOda hastaneOda)
        {
            string sqlSentence = $"DELETE FROM HastaneOdaTbl WHERE OdaID={hastaneOda.OdaID}";
            _base.Post(sqlSentence);
        }

        public void Update(HastaneOda hastaneOda)
        {
            string sqlSentence = $"UPDATE HastaneOdaTbl SET OdaNo={hastaneOda.OdaNo}," +
                $"OdaTipi='{hastaneOda.OdaTipi}', DolulukDurumu='{hastaneOda.DolulukDurumu}', WHERE" +
                $"OdaID={hastaneOda.OdaID}";
            _base.Post(sqlSentence);
        }

        private List<HastaneOda> ParseToList(DataSet dataSet)
        {
            List<HastaneOda> hastaneOdas = dataSet.Tables[0].AsEnumerable().Select(row =>
                new HastaneOda
                {
                    OdaID = row.Field<int>("OdaID"),
                    OdaNo = row.Field<int>("OdaNo"),
                    OdaTipi = row.Field<string>("OdaTipi"),
                    DolulukDurumu = row.Field<string>("DolulukDurumu")
                }).ToList();

            return hastaneOdas;
        }
    }
}
