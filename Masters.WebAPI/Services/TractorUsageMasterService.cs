using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Masters.WebAPI.DataProvider;
using Masters.WebAPI.Models.TractorUsageMaster;

namespace Masters.WebAPI.Services
{
    public class TractorUsageMasterService : ITractorUsageMasterService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        public TractorUsageMasterService(dev_encrypted_generalcustomerappContext Context)
        {
            _context = Context;
        }

        public TractorUsageMaster GetByLanguage(MstLanguage Language, string moduleName)
        {
            TractorUsageMaster master = new TractorUsageMaster
            {
                contentversion = (from p in _context.TblVersionController
                                  where p.ActiveflagC == "A"
                                  && p.ModuleName == moduleName
                                  select p.Version.Value).FirstOrDefault(),
                languagecode = Language.LanguageCode,
                tractorusagelist = new TractorUsageList
                {
                    tractorusage = (from p in _context.MstTractorusage
                                    where p.ActiveflagC == "A"
                                    select new TractorUsage
                                    {
                                        id = p.Id,
                                        usagename = p.Usagename
                                    }).ToList()
                }
            };

            return master;
        }
    }
}
