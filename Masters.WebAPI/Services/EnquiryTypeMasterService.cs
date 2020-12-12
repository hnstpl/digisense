using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Masters.WebAPI.Models.EnquiryTypeMaster;
using Masters.WebAPI.DataProvider;

namespace Masters.WebAPI.Services
{
    public class EnquiryTypeMasterService : IEnquiryTypeMasterService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        public EnquiryTypeMasterService(dev_encrypted_generalcustomerappContext Context)
        {
            _context = Context;
        }

        public EnquiryTypes GetByLanguage(MstLanguage Language, string moduleName)
        {
            EnquiryTypes EnquiryTypeRecords = new EnquiryTypes
            {
                contentversion = (from p in _context.TblVersionController
                                  where p.ActiveflagC == "A"
                                  && p.ModuleName == moduleName
                                  select p.Version.Value).FirstOrDefault(),
                languagecode = Language.LanguageCode,
                enquirytypelist = (from p in _context.MstEnqTypeLang
                                   join o in _context.MstEnqType on p.EnqTypeId equals o.EnqTypeId
                                   where p.MstLangId == Language.Id
                                   && p.ActiveflagC == "A"
                                   && o.ActiveflagC == "A"
                                   select new EnquiryTypesList
                                   {
                                       enquirytypeid = o.EnqTypeId,
                                       enquirytypename = p.EnqTypeName
                                   }).OrderBy(x => x.enquirytypeid).Distinct().ToList()
            };

            return EnquiryTypeRecords;
        }
    }
}
