using GeoMasters.WebAPI.DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMasters.WebAPI.Services
{
    public class GlobalService : IGlobalService
    {

        private readonly dev_encrypted_generalcustomerappContext _context;

        public GlobalService(dev_encrypted_generalcustomerappContext DataContext)
        {
            _context = DataContext;
        }

        public IEnumerable<MstLanguage> GetAllLanguages()
        {
            return _context.MstLanguage.Where(x => x.ActiveflagC == "A");
        }

        public MstLanguage GetLanguageByCode(string Code)
        {
            return _context.MstLanguage.Where(x => x.LanguageCode == Code && x.ActiveflagC == "A").FirstOrDefault();
        }


        public List<MstLanguage> GetLanguageList(string LanguageCode, string customerCode)
        {
            List<MstLanguage> languages = new List<MstLanguage>();


            if (LanguageCode == null)
            {
                var UserLanguagePreference = (from p in _context.MstCustprofile
                                              where p.CustCodeVc == customerCode
                                              select p).FirstOrDefault();

                languages = (from p in _context.MstLanguage
                             where p.ActiveflagC == "A"
                             && p.Id == UserLanguagePreference.LanguagePreference
                             select p).ToList();
            }
            else
            {
                languages = (from p in _context.MstLanguage
                             where p.ActiveflagC == "A"
                             && (LanguageCode == null || p.LanguageCode == LanguageCode)
                             select p).ToList();
            }

            return languages;
        }
        public MstLanguage GetLanguage(string LanguageCode, string customerCode)
        {
            MstLanguage languages = new MstLanguage();


            if (LanguageCode == null)
            {
                var UserLanguagePreference = (from p in _context.MstCustprofile
                                              where p.CustCodeVc == customerCode
                                              select p).FirstOrDefault();

                languages = (from p in _context.MstLanguage
                             where p.ActiveflagC == "A"
                             && p.Id == UserLanguagePreference.LanguagePreference
                             select p).FirstOrDefault();
            }
            else
            {
                languages = (from p in _context.MstLanguage
                             where p.ActiveflagC == "A"
                             && (LanguageCode == null || p.LanguageCode == LanguageCode)
                             select p).FirstOrDefault();
            }


            return languages;
        }

        public string GetCustomerCode()
        {
            //return ClaimsPrincipal.Current.Identities.First().Claims.FirstOrDefault(x => x.Type.Contains("nameidentifier")).Value.Replace("\"", "");
            return "A000000490";
        }
    }
}
