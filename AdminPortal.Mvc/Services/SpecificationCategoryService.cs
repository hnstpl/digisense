using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.SpecificationCategory;

namespace AdminPortal.Mvc.Services
{
    public class SpecificationCategoryService : ISpecificationCategoryService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        public SpecificationCategoryService(dev_encrypted_generalcustomerappContext Context)
        {
            _context = Context;
        }


        public IEnumerable<SpecificationCategory> GetAll(int LanguageID)
        {
            List<SpecificationCategory> SpecificationCategory = (from sp in _context.MstTpdhSpecificationCategory
                                                                 join splang in _context.MstTpdhSpecificationCategoryLang on sp.SpecCategoryId
                                                                 equals splang.SpecCategoryId
                                                                 join mlang in _context.MstLanguage on splang.MstLangId equals mlang.Id
                                                                 where (LanguageID == 0 || splang.MstLangId == LanguageID)
                                                                 orderby splang.SpecCategoryName ascending
                                                                 select new SpecificationCategory
                                                                 {

                                                                     MSpecCategoryID = sp.SpecCategoryId,
                                                                     MSpecCategoyName = splang.SpecCategoryName,
                                                                     MACTIVEFLAG_C = (splang.ActiveflagC == "A" ? "Active" : "In Active")
                                                                 }).ToList();
            return SpecificationCategory;
        }
    }
}
