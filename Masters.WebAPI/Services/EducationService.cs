using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Masters.WebAPI.Models.EducationMaster;
using Masters.WebAPI.DataProvider;

namespace Masters.WebAPI.Services
{
    public class EducationService : IEducationService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        public EducationService(dev_encrypted_generalcustomerappContext Context)
        {
            _context = Context;
        }

        public EducationMaster GetDataByLanguageID(MstLanguage Language, string Modulename)
        {
            EducationMaster master = new EducationMaster
            {
                contentversion = (from p in _context.TblVersionController
                                  where p.ActiveflagC == "A"
                                  && p.ModuleName == Modulename
                                  select p.Version.Value).FirstOrDefault(),
                languagecode = Language.LanguageCode,
                educationlist = new EducationList
                {
                    education = (from p in _context.MstEducation
                                 where p.ActiveflagC == "A"
                                 select new Education
                                 {
                                     id = p.Id,
                                     educationname = p.Education
                                 }).ToList()
                }

            };

            return master;
        }
    }
}
