using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.ImplementModelGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Services
{
    public class ImplementModelGroupService : IImplementModelGroupService
    {

        private readonly dev_encrypted_generalcustomerappContext _context;

        public ImplementModelGroupService(dev_encrypted_generalcustomerappContext entityContext)
        {
            _context = entityContext;
        }


        public IEnumerable<ImplementModelGroup> GetByLanguageID(int LanguageID)
        {

            List<ImplementModelGroup> ImplementModelGroup = (from img in _context.MstIpdhModelgroup

                                                             join imglang in _context.MstIpdhModelgroupLang on img.IgcodeVc equals imglang.IgcodeVc
                                                             join mlang in _context.MstLanguage on imglang.MstLangId equals mlang.Id
                                                             where imglang.MstLangId == LanguageID
                                                             orderby imglang.IgnameVc ascending
                                                             select new ImplementModelGroup
                                                             {

                                                                 MIGCode_VC = img.IgcodeVc,
                                                                 MIGROUPNAME = imglang.IgnameVc,
                                                                 MActiveFlag_C = (img.ActiveFlagC == "A" ? "Active" : "In Active")

                                                             }).ToList();

            return ImplementModelGroup;
        }
    }
}
