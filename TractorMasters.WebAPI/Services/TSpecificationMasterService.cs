using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using TractorMasters.WebAPI.DataProvider;
using TractorMasters.WebAPI.Models.TSpecificationMaster;

namespace TractorMasters.WebAPI.Services
{
    public class TSpecificationMasterService:ITSpecificationMasterService
    {

        private readonly dev_encrypted_generalcustomerappContext _context;


        private readonly IConfiguration _config;
        private readonly IGlobalService _global;

        string moduleName = "";
        public TSpecificationMasterService(dev_encrypted_generalcustomerappContext dataContext, IConfiguration config, IGlobalService Global)
        {
            _context = dataContext;
            _config = config;
            _global = Global;

            //Get Module name from config to get the content version
            moduleName = _config.GetValue<string>("TractorMasters:TractorSpecificationMaster");
        }

        public MastersModel GetTractorSpecification(string LanguageCode, string customerCode)
        {
            MastersModel masterModel = new MastersModel();
            try
            {
            
                    //Get Languages
                    List<MstLanguage> languages = _global.GetLanguageList(LanguageCode, customerCode);

                    List<SpeficicationMaster> masterList = new List<SpeficicationMaster>();
                    foreach (var Language in languages)
                    {
                        SpeficicationMaster master = new SpeficicationMaster
                        {
                            contentversion = (from p in _context.TblVersionController
                                              where p.ActiveflagC == "A"
                                              && p.ModuleName == moduleName
                                              select p.Version.Value).FirstOrDefault(),
                            languagecode = Language.LanguageCode,
                            tractorspeclist = new TPDHSpecificationsList
                            {
                                tractorspecifications = (from p in _context.MstTpdhModelSpecificationLang
                                                         join o in _context.MstTpdhModelSpecification on p.SpecificationId equals o.SpecificationId
                                                         join i in _context.MstTpdhSpecificationCategory on o.SpecificationCategory equals i.SpecCategoryId
                                                         where p.ActiveflagC == "A" && o.ActiveflagC == "A" && i.ActiveflagC == "A"
                                                         && p.MstLangId == Language.Id
                                                         select new TPDHSpecifications
                                                         {
                                                             speccategoryid = i.SpecCategoryId,
                                                             specificationid = o.SpecificationId,
                                                             specificationname = p.SpecificationName
                                                         }).ToList()
                            }

                        };
                        masterList.Add(master);
                    }

                    masterList.ForEach(x => x.tractorspeclist.totalrecords = x.tractorspeclist.tractorspecifications.Count);


                masterModel.masters = masterList;
                
            }
            catch (Exception e)
            {
               
            }
            return masterModel;
        }
    }
}
