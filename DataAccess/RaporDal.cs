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
    public class RaporDal
    {
        private DataAccessBase _base;

        public RaporDal()
        {
            _base = HastaneManagementFactory.CreateDataAccessBase();
        }

        public List<Rapor> GetAll()
        {
            string sqlSentence = "SELECT * FROM RaporlarTbl";
            var result = _base.Get(sqlSentence);
            return ParseToList(result);
        }

        public void Add(Rapor rapor)
        {
            string sqlSentence = $"INSERT INTO RaporlarTbl (RaporID, HastaID, DoktorID, RaporTarih, RaporIcerik) VALUES ({rapor.RaporID}, " +
                $"{rapor.HastaID},{rapor.DoktorID},'{rapor.RaporTarihi}','{rapor.RaporIcerik}')";
            _base.Post(sqlSentence);
        }

        public void Delete(Rapor rapor)
        {
            string sqlSentence = $"DELETE FROM RaporlarTbl WHERE RaporID={rapor.RaporID}";
            _base.Post(sqlSentence);
        }

        public void Update(Rapor rapor)
        {
            string sqlSentence = $"UPDATE DoktorTbl SET RaporTarihi='{rapor.RaporTarihi}'," +
                $"HastaID={rapor.HastaID}, DoktorID={rapor.DoktorID}, RaporTarihi='{rapor.RaporTarihi}' WHERE" +
                $"RaporID={rapor.RaporID}";
            _base.Post(sqlSentence);
        }

        private List<Rapor> ParseToList(DataSet dataSet)
        {
            List<Rapor> rapors = dataSet.Tables[0].AsEnumerable().Select(row =>
                new Rapor
                {
                    RaporID = row.Field<int>("RaporID"),
                    HastaID = row.Field<int>("HastaID"),
                    DoktorID = row.Field<int>("DoktorID"),
                    RaporTarihi = row.Field<int>("RaporTarihi"),
                    RaporIcerik = row.Field<string>("RaporIcerik")
                }).ToList();

            return rapors;
        }
    }
}