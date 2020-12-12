using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.HP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Services
{
    public class HPService : IHPService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        public HPService(dev_encrypted_generalcustomerappContext Context)
        {
            _context = Context;
        }

        public IEnumerable<HP> GetAll(int LanguageID)
        {
            List<HP> HP = (from hp in _context.MstTpdhHp
                           join hplang in _context.MstTpdhHpLang on hp.HpcodeVc equals hplang.HpcodeVc
                           join mlang in _context.MstLanguage on hplang.MstLangId equals mlang.Id
                           where (LanguageID == 0 || hplang.MstLangId == LanguageID)
                           orderby hplang.HpnameVc ascending
                           select new HP
                           {
                               MHPCODE_VC = hp.HpcodeVc,
                               MHPNAME_VC = hplang.HpnameVc,
                               MACTIVEFLAG_C = (hplang.ActiveflagC == "A" ? "Active" : "In Active")
                           }).ToList();
            return HP;
        }
    }
}
