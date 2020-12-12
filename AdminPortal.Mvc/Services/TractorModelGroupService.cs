using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.TractorModelGroup;
using AdminPortal.Mvc.DataProvider;

namespace AdminPortal.Mvc.Services
{
    public class TractorModelGroupService : ITractorModelGroupService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        public TractorModelGroupService(dev_encrypted_generalcustomerappContext entityContext)
        {
            _context = entityContext;
        }


        public IEnumerable<TractorModelGroup> GetByLanguageID(int LanguageID)
        {
            List<TractorModelGroup> TractorModelGroup = (from tmg in _context.MstTpdhModelgroup

                                                         join mglang in _context.MstTpdhModelgroupLang on tmg.ModelgroupcodeVc equals mglang.ModelgroupcodeVc
                                                         join blang in _context.MstTpdhBrandLang on tmg.BrandcodeVc equals blang.BrandcodeVc
                                                         join mlang in _context.MstLanguage on mglang.MstLangId equals mlang.Id
                                                         where mglang.MstLangId == LanguageID && blang.MstLangId == LanguageID
                                                         orderby mglang.ModelgroupnameVc ascending
                                                         select new TractorModelGroup
                                                         {

                                                             MMODELGROUPCODE_VC = tmg.ModelgroupcodeVc,
                                                             MMODELGROUPNAME = mglang.ModelgroupnameVc,
                                                             MBRANDNAME = blang.BrandnameVc,
                                                             MACTIVEFLAG_C = (mglang.ActiveflagC == "A" ? "Active" : "In Active")

                                                         }).ToList();
            return TractorModelGroup;
        }
    }
}
