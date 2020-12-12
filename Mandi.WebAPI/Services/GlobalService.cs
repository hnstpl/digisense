using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mandi.WebAPI.DataProvider;

namespace Mandi.WebAPI.Services
{
    public class GlobalService : IGlobalService
    {

        private readonly dev_encrypted_generalcustomerappContext _context;

        public DateTime epoch = new DateTime(1970, 01, 01);

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

        public IEnumerable<MstLanguage> GetLanguageListForCustomer(string LanguageCode, string CustomerCode)
        {

            List<MstLanguage> languages = new List<MstLanguage>();

            if (LanguageCode == null)
            {
                var UserLanguagePreference = (from p in _context.MstCustprofile
                                              where p.CustCodeVc == CustomerCode
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

        public string GetCustomerCode(string Token)
        {
            return "A000000490";
        }
    }
}
