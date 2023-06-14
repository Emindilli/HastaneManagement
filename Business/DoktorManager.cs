using HastaneOtomasyon.Core.DependencyResolvers;
using HastaneOtomasyon.DataAccess;
using HastaneOtomasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HastaneOtomasyon.Business
{
    public class DoktorManager
    {
        private DoktorDal _doktorDal;

        public DoktorManager()
        {
            _doktorDal= HastaneManagementFactory.CreateDoktorDal();

        }

        public void Add (Doktor doktor)
        {
            _doktorDal.Add(doktor);
        }
        public void Update(Doktor doktor)
        {
            _doktorDal.Update(doktor);
        }
        public void Delete(Doktor doktor)
        {
            _doktorDal.Delete(doktor);
        }
        public List<Doktor> GetAll ()
        {
            var result= _doktorDal.GetAll();

            return result;
        }
    }
}