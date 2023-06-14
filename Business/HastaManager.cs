using HastaneOtomasyon.Core.DependencyResolvers;
using HastaneOtomasyon.DataAccess;
using HastaneOtomasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HastaneOtomasyon.Business
{
    public class HastaManager
    {
        private HastaDal _hastaDal;

        public HastaManager()
        {
            _hastaDal = HastaneManagementFactory.CreateHastaDal();

        }

        public void Add(Hasta hasta)
        {
            _hastaDal.Add(hasta);
        }
        public void Update(Hasta hasta)
        {
            _hastaDal.Update(hasta);
        }
        public void Delete(Hasta hasta)
        {
            _hastaDal.Delete(hasta);
        }
        public List<Hasta> GetAll()
        {
            var result = _hastaDal.GetAll();

            return result;
        }
    }
}