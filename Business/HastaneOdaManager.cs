using HastaneOtomasyon.Core.DependencyResolvers;
using HastaneOtomasyon.DataAccess;
using HastaneOtomasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HastaneOtomasyon.Business
{
    public class HastaneOdaManager
    {
        private HastaneOdaDal _hastaneOdaDal;

        public HastaneOdaManager()
        {
            _hastaneOdaDal = HastaneManagementFactory.CreateHastaneOdaDal();

        }

        public void Add(HastaneOda hastaneOda)
        {
            _hastaneOdaDal.Add(hastaneOda);
        }
        public void Update(HastaneOda hastaneOda)
        {
            _hastaneOdaDal.Update(hastaneOda);
        }
        public void Delete(HastaneOda hastaneOda)
        {
            _hastaneOdaDal.Delete(hastaneOda);
        }
        public List<HastaneOda> GetAll()
        {
            var result = _hastaneOdaDal.GetAll();

            return result;
        }
    }
}