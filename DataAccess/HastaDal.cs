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
    public class HastaDal
    {
        private DataAccessBase _base;

        public HastaDal()
        {
            _base = HastaneManagementFactory.CreateDataAccessBase();
        }

        public List<Hasta> GetAll()
        {
            string sqlSentence = "SELECT * FROM HastaTbl";
            var result = _base.Get(sqlSentence);
            return ParseToList(result);
        }

        public void Add(Hasta hasta)
        {
            string sqlSentence = $"INSERT INTO HastaTbl ( HastaAdi, HastaSoyAdi, HastaDogumTarihi, HastaCinsiyet,HastaTel, HastaAdres) VALUES (" +
                $"'{hasta.HastaAdi}','{hasta.HastaSoyAdi}','{hasta.HastaDogumTarihi}','{hasta.HastaCinsiyet}','{hasta.HastaTel}','{hasta.HastaAdres}')";
            _base.Post(sqlSentence);
        }

        public void Delete(Hasta hasta)
        {
            string sqlSentence = $"DELETE FROM HastaTbl WHERE HastaID={hasta.HastaID}";
            _base.Post(sqlSentence);
        }

        public void Update(Hasta hasta)
        {
            string sqlSentence = $"UPDATE HastaTbl SET HastaAdi='{hasta.HastaAdi}' ,HastaSoyAdi='{hasta.HastaSoyAdi}'," + 
            $"HastaDogumTarihi='{hasta.HastaDogumTarihi}', HastaCinsiyet='{hasta.HastaCinsiyet}',HastaTel='{hasta.HastaTel}'," +
            $"HastaAdres ='{hasta.HastaAdres}' WHERE HastaID = {hasta.HastaID}";
            _base.Post(sqlSentence);
        }
        
        private List<Hasta> ParseToList(DataSet dataSet)
        {
            List<Hasta> hastas = dataSet.Tables[0].AsEnumerable().Select(row =>
                new Hasta
                { 
                    HastaID = row.Field<int>("HastaID"),
                    HastaAdi = row.Field<string>("HastaAdi"),
                    HastaSoyAdi = row.Field<string>("HastaSoyAdi"),
                    HastaTel = row.Field<string>("HastaTel"),
                    HastaCinsiyet = row.Field<string>("HastaCinsiyet"),
                    HastaAdres = row.Field<string>("HastaAdres"),
                    HastaDogumTarihi = row.Field<string>("HastaDogumTarihi")
                }).ToList();

            return hastas;
        }      
    }
}
    
