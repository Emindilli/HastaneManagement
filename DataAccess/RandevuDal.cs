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
    public class RandevuDal
    {
        private DataAccessBase _base;

        public RandevuDal()
        {
            _base = HastaneManagementFactory.CreateDataAccessBase();
        }

        public List<Randevu> GetAll()
        {
            string sqlSentence = "SELECT * FROM RandevuTbl";
            var result = _base.Get(sqlSentence);
            return ParseToList(result);
        }

        public void Add(Randevu randevu)
        {
            string sqlSentence = $"INSERT INTO RandevuTbl ( HastaID, DoktorID, RandevuTarihi) VALUES (, " +
                $"{randevu.HastaID},{randevu.DoktorID},{randevu.RandevuTarihi})";
            _base.Post(sqlSentence);
        }

        public void Delete(Randevu randevu)
        {
            string sqlSentence = $"DELETE FROM RandevuTbl WHERE RandevuID={randevu.RandevuID}";
            _base.Post(sqlSentence);
        }

        public void Update(Randevu randevu)
        {
            string sqlSentence = $"UPDATE RandevuTbl SET DoktorID={randevu.DoktorID}," +
                $"HastaID={randevu.HastaID}, RandevuTarihi={randevu.RandevuTarihi}, WHERE" +
                $"RandevuID={randevu.RandevuID}";
            _base.Post(sqlSentence);
        }

        private List<Randevu> ParseToList(DataSet dataSet)
        {
            List<Randevu> randevus = dataSet.Tables[0].AsEnumerable().Select(row =>
                new Randevu
                {
                    RandevuID = row.Field<int>("RandevuID"),
                    HastaID = row.Field<int>("HastaID"),
                    DoktorID = row.Field<int>("DoktorID"),
                    RandevuTarihi = row.Field<int>("RandevuTarihi")
                }).ToList();

            return randevus;
        }
    }
}