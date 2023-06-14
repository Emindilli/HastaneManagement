using HastaneOtomasyon.Core.DependencyResolvers;
using HastaneOtomasyon.DataAccess;
using HastaneOtomasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HastaneOtomasyon.Business
{
    public class RandevuManager
    {
        private RandevuDal _randevuDal;

        public RandevuManager()
        {
            _randevuDal = HastaneManagementFactory.CreateRandevuDal();

        }

        public void Add(Randevu randevu)
        {
            _randevuDal.Add(randevu);
        }
        public void Update(Randevu randevu)
        {
            _randevuDal.Update(randevu);
        }
        public void Delete(Randevu randevu)
        {
            _randevuDal.Delete(randevu);
        }
        public List<Randevu> GetAll()
        {
            var result = _randevuDal.GetAll();

            return result;
        }
    }
}