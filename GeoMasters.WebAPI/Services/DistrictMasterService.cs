using GeoMasters.WebAPI.DataProvider;
using GeoMasters.WebAPI.Models.DistrictMaster;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMasters.WebAPI.Services
{
    public class DistrictMasterService:IDistrictMasterService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;



        private readonly IConfiguration _config;
        private readonly IGlobalService _global;

        string moduleName = "";
        public DistrictMasterService(dev_encrypted_generalcustomerappContext dataContext, IConfiguration config, IGlobalService Global)
        {
            _context = dataContext;
            _config = config;
            _global = Global;

            //Get Module name from config to get the content version
            moduleName = _config.GetValue<string>("GeoMasters:DistrictMaster");
        }

        public MastersModel GetDistricts(string LanguageCode, string customerCode, StateCode stateCode)
        {

            MastersModel masterModel = new MastersModel();

                      
            //Get Languages
            List<MstLanguage> languages = _global.GetLanguageList(LanguageCode, customerCode);

            List<DistrictMaster> masterList = new List<DistrictMaster>();
            foreach (var Language in languages)
            {
                DistrictMaster master = new DistrictMaster
                {
                    contentversion = (from p in _context.TblVersionController
                                      where p.ActiveflagC == "A"
                                      && p.ModuleName == moduleName
                                      select p.Version.Value).FirstOrDefault(),
                    languagecode = Language.LanguageCode,
                    districtlist = new DistrictsList
                    {
                        districts = (from p in _context.MstDistrictLang
                                     join o in _context.MstDistrict on p.DistrictCodeVc equals o.DistrictCodeVc
                                     where p.ActiveflagC == "A" && o.ActiveflagC == "A"
                                     && p.MstLangId == Language.Id
                                     && (string.IsNullOrEmpty(stateCode.statecode) || o.StateCodeI == stateCode.statecode)
                                     select new Districts
                                     {
                                         districtcode = o.DistrictCodeVc,
                                         districtname = p.DistrictNameVc,
                                         statecode = o.StateCodeI
                                     }).ToList()
                    }

                };
                masterList.Add(master);
            }

            masterList.ForEach(x => x.districtlist.totalrecords = x.districtlist.districts.Count);




            masterModel.masters = masterList;

            return masterModel;

        }
    }
}
