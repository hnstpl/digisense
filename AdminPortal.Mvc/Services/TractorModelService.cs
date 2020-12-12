using AdminPortal.Mvc.DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.TractorModel;

namespace AdminPortal.Mvc.Services
{
    public class TractorModelService : ITractorModelService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        public TractorModelService(dev_encrypted_generalcustomerappContext entityContext)
        {
            _context = entityContext;
        }

        public IEnumerable<TractorModel> GetByLanguageID(int LanguageID)
        {
            List<TractorModel> TractorModel = (from tm in _context.MstTpdhModel

                                               join tmlang in _context.MstTpdhModelLang on tm.ModelcodeVc equals tmlang.ModelcodeVc
                                               join mlang in _context.MstLanguage on tmlang.MstLangId equals mlang.Id
                                               join tmglang in _context.MstTpdhModelgroupLang on tm.ModelgroupcodeVc equals tmglang.ModelgroupcodeVc
                                               join hplang in _context.MstTpdhHpLang on tm.HpcodeVc equals hplang.HpcodeVc
                                               join blang in _context.MstTpdhBrandLang on tm.BrandcodeVc equals blang.BrandcodeVc
                                               where tmlang.MstLangId == LanguageID && tmglang.MstLangId == LanguageID && hplang.MstLangId == LanguageID
                                               && blang.MstLangId == LanguageID
                                               orderby tmlang.ModelnameVc ascending
                                               select new TractorModel
                                               {
                                                   MMODELCODE_VC = tm.ModelcodeVc,
                                                   MMODELNAME = tmlang.ModelnameVc,
                                                   MMODELGROUPNAME = tmglang.ModelgroupnameVc,
                                                   MHPNAME = hplang.HpnameVc,
                                                   MBRANDNAME = blang.BrandnameVc,
                                                   MACTIVEFLAG_C = (tmlang.ActiveflagC == "A" ? "Active" : "In Active")
                                               }).ToList();

            return TractorModel;
        }
    }
}
