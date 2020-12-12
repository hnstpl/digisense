using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.Brand;
using AdminPortal.Mvc.DataProvider;

namespace AdminPortal.Mvc.Services
{
    public class BrandService : IBrandService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        public BrandService(dev_encrypted_generalcustomerappContext Context)
        {
            _context = Context;
        }

        public IEnumerable<Brand> GetAll(int LanguageID)
        {
            List<Brand> Brand = (from b in _context.MstTpdhBrand
                                 join blang in _context.MstTpdhBrandLang on b.BrandcodeVc equals blang.BrandcodeVc
                                 join mlang in _context.MstLanguage on blang.MstLangId equals mlang.Id
                                 where (LanguageID == 0 || blang.MstLangId == LanguageID)
                                 orderby blang.BrandnameVc ascending
                                 select new Brand
                                 {
                                     MBRANDCODE_VC = b.BrandcodeVc,
                                     MBrandName = blang.BrandnameVc,
                                     ACTIVEFLAG_C = (blang.ActiveflagC == "A" ? "Active" : "In Active")
                                 }).ToList();
            return Brand;
        }
    }
}
