using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.Mandi;
using AdminPortal.Mvc.DataProvider;

namespace AdminPortal.Mvc.Services
{
    public class MandiService : IMandiService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        public MandiService(dev_encrypted_generalcustomerappContext Context)
        {
            _context = Context;
        }


        public IEnumerable<Mandi> GetMandiDataByLanguageID(int LanguageID)
        {
            List<Mandi> MandiData = (from p in _context.MstMandiList
                                     join o in _context.MstMandiListLang on p.MandiId equals o.MandiId
                                     join d in _context.MstDistrictLang on o.DistrictNameVc equals d.DistrictNameVc
                                     join s in _context.MstStateLang on o.StateNameVc equals s.StateNameVc
                                     where o.MstLangId == LanguageID
                                     select new Mandi
                                     {
                                         Mandi_ID = p.MandiId,
                                         Mandi_Name = o.MandiName,
                                         StateName_VC = o.StateNameVc,
                                         DistrictName_VC = o.DistrictNameVc,
                                         ACTIVEFLAG_C = p.ActiveflagC,
                                         StateCode_I=p.StateCodeI,
                                         DistrictCode_VC=p.DistrictCodeVc
                                     }).OrderBy(x => x.Mandi_ID).Distinct().ToList();

            return MandiData;
        }
    }
}
