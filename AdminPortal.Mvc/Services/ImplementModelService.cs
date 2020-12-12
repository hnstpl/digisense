using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.ImplementModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.GlobalProvider;

namespace AdminPortal.Mvc.Services
{
    public class ImplementModelService : IImplementModelService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        public ImplementModelService(dev_encrypted_generalcustomerappContext Context)
        {
            _context = Context;
        }

        public IEnumerable<ImplementModel> GetAll(int LanguageID)
        {         
            List<ImplementModel> implementModel = (from im in _context.MstIpdhModel

                                                   join imlang in _context.MstIpdhModelLang on im.ModelcodeVc equals imlang.ModelcodeVc
                                                   join mlang in _context.MstLanguage on imlang.MstLangId equals mlang.Id
                                                   join mrlang in _context.MstTpdhManufacturerLang on im.ManufacturercodeVc equals mrlang.MstTpdhManufacturercode
                                                   join imglang in _context.MstIpdhModelgroupLang on im.IgcodeVc equals imglang.IgcodeVc
                                                   where imlang.MstLangId == LanguageID && mrlang.MstLangId == LanguageID && imglang.MstLangId == LanguageID
                                                   orderby imlang.ModelnameVc ascending
                                                   select new ImplementModel
                                                   {

                                                       MIMPCODE = im.ModelcodeVc,
                                                       MIMPNAME = imlang.ModelnameVc,
                                                       MMANUFACTURERMNAME = mrlang.MstTpdhManufacturername,
                                                       MIGNAME = imglang.IgnameVc,
                                                       MACTIVEFLAG_C = (im.ActiveflagC == "A" ? "Active" : "In Active")

                                                   }).ToList();
            

            return implementModel;
        }

        public IEnumerable<ImplementModel> GetByType(int LanguageID)
        {
            List<ImplementModel> result = new List<ImplementModel>();
                
         
            List<ImplementModel> implementModels = (from im in _context.MstIpdhModel

                                           join imlang in _context.MstIpdhModelLang on im.ModelcodeVc equals imlang.ModelcodeVc
                                           join mlang in _context.MstLanguage on imlang.MstLangId equals mlang.Id
                                                   join mrlang in _context.MstTpdhManufacturerLang on im.ManufacturercodeVc equals mrlang.MstTpdhManufacturercode
                                                   join imglang in _context.MstIpdhModelgroupLang on im.IgcodeVc equals imglang.IgcodeVc
                                                   where imlang.MstLangId == LanguageID && mrlang.MstLangId == LanguageID && imglang.MstLangId == LanguageID
                                           orderby imlang.ModelcodeVc ascending
                                                   select new ImplementModel
                                                   {

                                                       MIMPCODE = im.ModelcodeVc,
                                                       MIMPNAME = imlang.ModelnameVc,
                                                       MMANUFACTURERMNAME = mrlang.MstTpdhManufacturername,
                                                       MIGNAME = imglang.IgnameVc,
                                                       MACTIVEFLAG_C = (im.ActiveflagC == "A" ? "Active" : "In Active")

                                                   }).ToList();

            result = implementModels;

            return result;
        }
     
    }
}
