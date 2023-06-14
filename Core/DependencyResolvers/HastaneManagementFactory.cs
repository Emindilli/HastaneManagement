
using HastaneOtomasyon.Business;
using HastaneOtomasyon.DataAccess;
using KutuphaneOtomasyonu.DataAccess.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Core.DependencyResolvers
{
    public class HastaneManagementFactory
    {
        private static DataAccessBase _base;

        private static DoktorDal _doktorDal;

        private static DoktorManager _doktorManager;

        private static HastaDal _hastaDal;

        private static HastaManager _hastaManager;

        private static RaporDal _raporDal;

        private static RaporManager _raporManager;

        private static RandevuDal _randevuDal;

        private static RandevuManager _randevuManager;

        private static HastaneOdaDal _hastaneOdaDal;

        private static HastaneOdaManager _hastaneOdaManager;

        
        public static DataAccessBase CreateDataAccessBase() { return _base == null ? new DataAccessBase() : _base; }
        public static DoktorDal CreateDoktorDal() { return _doktorDal == null ? new DoktorDal() : _doktorDal; }
        public static DoktorManager CreateDoktorManager() { return _doktorManager == null ? new DoktorManager() : _doktorManager; }
        public static HastaDal CreateHastaDal() { return _hastaDal == null ? new HastaDal() : _hastaDal; }
        public static HastaManager CreateHastaManager() { return _hastaManager == null ? new HastaManager() : _hastaManager; }
        public static RaporDal CreateRaporDal() { return _raporDal == null ? new RaporDal() : _raporDal; }
        public static RaporManager CreateRaporManager() { return _raporManager == null ? new RaporManager() : _raporManager; }
        public static RandevuDal CreateRandevuDal() { return _randevuDal == null ? new RandevuDal() : _randevuDal; }
        public static RandevuManager CreateRandevuManager() { return _randevuManager == null ? new RandevuManager() : _randevuManager; }
        public static HastaneOdaDal CreateHastaneOdaDal() { return _hastaneOdaDal == null ? new HastaneOdaDal() : _hastaneOdaDal; }
        public static HastaneOdaManager CreateHastaneOdaManager() { return _hastaneOdaManager == null ? new HastaneOdaManager() : _hastaneOdaManager; }
        


        

    }
}
