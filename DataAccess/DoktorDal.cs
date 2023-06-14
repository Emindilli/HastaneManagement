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
    public class DoktorDal
    {
        private DataAccessBase _base;

        public DoktorDal()
        {
            _base = HastaneManagementFactory.CreateDataAccessBase();
        }

        public List<Doktor> GetAll()
        {
            string sqlSentence = "SELECT * FROM DoktorTbl";
            var result = _base.Get(sqlSentence);
            return ParseToList(result);
        }

        public void Add(Doktor doktor)
        {
            string sqlSentence = $"INSERT INTO DoktorTbl ( DoktorAdi, DoktorSoyAdi, DoktorTel, DoktorUzmanlik) VALUES( " +
            $"'{doktor.DoktorAdi}','{doktor.DoktorSoyAdi}','{doktor.DoktorTel}','{doktor.DoktorUzmanlik}')";
            _base.Post(sqlSentence);
        }

        public void Delete(Doktor doktor)
        {
            string sqlSentence = $"DELETE FROM DoktorTbl WHERE DoktorID={doktor.DoktorID}";
            _base.Post(sqlSentence);
        }

        public void Update(Doktor doktor)
        {
            string sqlSentence = $"UPDATE DoktorTbl SET DoktorAdi='{doktor.DoktorAdi}'," +
                $"DoktorSoyAdi='{doktor.DoktorSoyAdi}', DoktorTel='{doktor.DoktorTel}', " +
                $"DoktorUzmanlik='{doktor.DoktorUzmanlik}' WHERE DoktorID={doktor.DoktorID}";
            _base.Post(sqlSentence);
        }

        private List<Doktor> ParseToList(DataSet dataSet)
        {
            List<Doktor> doktors = dataSet.Tables[0].AsEnumerable().Select(row =>
                new Doktor
                {
                    DoktorID = row.Field<int>("DoktorID"),
                    DoktorAdi = row.Field<string>("DoktorAdi"),
                    DoktorSoyAdi = row.Field<string>("DoktorSoyAdi"),
                    DoktorTel = row.Field<string>("DoktorTel"),
                    DoktorUzmanlik = row.Field<string>("DoktorUzmanlik")
                }).ToList();

            return doktors;
        }
    }
}