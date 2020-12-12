using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.Manufacturer;

namespace AdminPortal.Mvc.Services
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;


        public ManufacturerService(dev_encrypted_generalcustomerappContext Context)
        {
            _context = Context;
        }

        public IEnumerable<Manufacturer> GetAll(int LanguageID)
        {
            List<Manufacturer> Manufacturer = (from mr in _context.MstTpdhManufacturer
                                               join mrlang in _context.MstTpdhManufacturerLang on mr.MstTpdhManufacturercode equals mrlang.MstTpdhManufacturercode
                                               join mlang in _context.MstLanguage on mrlang.MstLangId equals mlang.Id
                                               where mrlang.MstLangId == LanguageID
                                               orderby mrlang.MstTpdhManufacturername ascending
                                               select new Manufacturer
                                               {
                                                   MMANUFACTURERCODE = mr.MstTpdhManufacturercode,
                                                   MManufacturerName = mrlang.MstTpdhManufacturername,
                                                   ACTIVEFLAG_C = (mrlang.ActiveflagC == "A" ? "Active" : "In Active")
                                               }).ToList();

            return Manufacturer;
        }
    }
}
