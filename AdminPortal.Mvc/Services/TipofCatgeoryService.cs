using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.TipofCatgeory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Services
{
    public class TipofCatgeoryService : ITipofCatgeoryService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        public TipofCatgeoryService(dev_encrypted_generalcustomerappContext Context)
        {
            _context = Context;
        }

        public IEnumerable<TipofCatgeory> GetAll(int LanguageID)
        {
            List<TipofCatgeory> TipofCatgeory = (from tp in _context.MstTipofthedayCategory
                                                 join Tiplang in _context.MstTipofthedayCategoryLang on tp.TipCategoryId equals Tiplang.TipCategoryId
                                                 join mlang in _context.MstLanguage on Tiplang.MstLangId equals mlang.Id
                                                 where (LanguageID == 0 || Tiplang.MstLangId == LanguageID)
                                                 orderby Tiplang.CategoryName ascending
                                                 select new TipofCatgeory
                                                 {
                                                     MTipCategory_ID = tp.TipCategoryId,
                                                     MTipCategoryName = Tiplang.CategoryName,
                                                     MACTIVEFLAG_C = (Tiplang.ActiveflagC == "A" ? "Active" : "In Active")
                                                 }).ToList();
            return TipofCatgeory;
        }
    }
}
