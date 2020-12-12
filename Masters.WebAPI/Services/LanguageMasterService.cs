using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Masters.WebAPI.DataProvider;
using Masters.WebAPI.Models.LanguageMaster;

namespace Masters.WebAPI.Services
{
    public class LanguageMasterService : ILanguageMasterService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        public LanguageMasterService(dev_encrypted_generalcustomerappContext Context)
        {
            _context = Context;
        }


        public IEnumerable<LanguageMaster> GetAll()
        {
            List<LanguageMaster> languageResult = (from p in _context.MstLanguage
                                                   where p.ActiveflagC == "A"
                                                   select new LanguageMaster
                                                   {
                                                       id = p.Id,
                                                       languagecode = p.LanguageCode,
                                                       languagename = p.LanguageName,
                                                       languagenametranslated = p.TranslateName
                                                   }).ToList();

            return languageResult;

        }

        public decimal GetContentVerstion(string moduleName)
        {
            var contentversion = (from p in _context.TblVersionController
                                  where p.ActiveflagC == "A"
                                  && p.ModuleName == moduleName
                                  select p.Version.Value).FirstOrDefault();

            return contentversion;
        }
    }
}
