using HastaneOtomasyon.Core.DependencyResolvers;
using HastaneOtomasyon.DataAccess;
using HastaneOtomasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HastaneOtomasyon.Business
{
    public class RaporManager
    {
        private RaporDal _raporDal;

        public RaporManager()
        {
            _raporDal = HastaneManagementFactory.CreateRaporDal();

        }

        public void Add(Rapor rapor)
        {
            _raporDal.Add(rapor);
        }
        public void Update(Rapor rapor)
        {
            _raporDal.Update(rapor);
        }
        public void Delete(Rapor rapor)
        {
            _raporDal.Delete(rapor);
        }
        public List<Rapor> GetAll()
        {
            var result = _raporDal.GetAll();

            return result;
        }
    }
}