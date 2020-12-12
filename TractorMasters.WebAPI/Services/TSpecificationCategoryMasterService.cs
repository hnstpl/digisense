using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using TractorMasters.WebAPI.DataProvider;
using TractorMasters.WebAPI.Models.TSpecificationCategoryMaster;

namespace TractorMasters.WebAPI.Services
{
    public class TSpecificationCategoryMasterService:ITSpecificationCategoryMasterService
    {

        private readonly dev_encrypted_generalcustomerappContext _context;


        private readonly IConfiguration _config;
        private readonly IGlobalService _global;

        string moduleName = "";
        public TSpecificationCategoryMasterService(dev_encrypted_generalcustomerappContext dataContext, IConfiguration config, IGlobalService Global)
        {
            _context = dataContext;
            _config = config;
            _global = Global;

            //Get Module name from config to get the content version
            moduleName = _config.GetValue<string>("TractorMasters:TractorSpecCategoryMaster");
        }

        public MastersModel GetTractorSpecificationCategory(string LanguageCode, string customerCode)
        {
            MastersModel masterModel = new MastersModel();
            try
            {

                //Get Languages
                List<MstLanguage> languages = _global.GetLanguageList(LanguageCode, customerCode);


                List<SpeficicationCategoryMasters> masterList = new List<SpeficicationCategoryMasters>();
                foreach (var Language in languages)
                {
                    SpeficicationCategoryMasters master = new SpeficicationCategoryMasters
                    {
                        contentversion = (from p in _context.TblVersionController
                                          where p.ActiveflagC == "A"
                                          && p.ModuleName == moduleName
                                          select p.Version.Value).FirstOrDefault(),
                        languagecode = Language.LanguageCode,
                        tractorspeccategorylist = new TPDHSpecificationsCategoryList
                        {
                            tractorspecificationcategory = (from p in _context.MstTpdhSpecificationCategoryLang
                                                            join o in _context.MstTpdhSpecificationCategory on p.Id equals o.SpecCategoryId
                                                            where p.ActiveflagC == "A" && o.ActiveflagC == "A"
                                                            && p.MstLangId == Language.Id
                                                            select new TPDHSpecificationsCategory
                                                            {
                                                                categoryid = p.SpecCategoryId,
                                                                categoryname = p.SpecCategoryName
                                                            }).ToList()
                        }

                    };
                    masterList.Add(master);
                }

                masterList.ForEach(x => x.tractorspeccategorylist.totalrecords = x.tractorspeccategorylist.tractorspecificationcategory.Count);

            

                masterModel.masters = masterList;

            }
            catch (Exception e)
            {

            }
            return masterModel;
        }
    }
}
