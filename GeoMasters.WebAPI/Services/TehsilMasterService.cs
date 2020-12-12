using GeoMasters.WebAPI.DataProvider;
using GeoMasters.WebAPI.Models.TehsilMaster;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMasters.WebAPI.Services
{
    public class TehsilMasterService:ITehsilMasterService
    {

        private readonly dev_encrypted_generalcustomerappContext _context;



        private readonly IConfiguration _config;
        private readonly IGlobalService _global;

        string moduleName = "";
        public TehsilMasterService(dev_encrypted_generalcustomerappContext dataContext, IConfiguration config, IGlobalService Global)
        {
            _context = dataContext;
            _config = config;
            _global = Global;

            //Get Module name from config to get the content version
            moduleName = _config.GetValue<string>("GeoMasters:TehsilMaster");
        }

        public MastersModel GetTehsils(string LanguageCode, string customerCode, DistrictCode districtCode)
        {

            MastersModel masterModel = new MastersModel();        


            //Get Languages
            List<MstLanguage> languages = _global.GetLanguageList(LanguageCode, customerCode);


            List<TehsilMaster> masterList = new List<TehsilMaster>();
            foreach (var Language in languages)
            {
                TehsilMaster master = new TehsilMaster
                {
                    contentversion = (from p in _context.TblVersionController
                                      where p.ActiveflagC == "A"
                                      && p.ModuleName == moduleName
                                      select p.Version.Value).FirstOrDefault(),
                    languagecode = Language.LanguageCode,
                    tehsillist = new TehsilList
                    {
                        tehsils = (from p in _context.MstTehsilLang
                                   join o in _context.MstTehsil on p.TehsilCodeVc equals o.TehsilCodeVc
                                   where p.ActiveflagC == "A" && o.ActiveflagC == "A"
                                   && p.MstLangId == Language.Id
                                   && (string.IsNullOrEmpty(districtCode.districtcode) || o.DistrictCodeVc == districtCode.districtcode)
                                   select new Tehsils
                                   {
                                       tehsilcode = o.TehsilCodeVc,
                                       tehsilname = p.TehsilNameVc,
                                       districtcode = o.DistrictCodeVc
                                   }).ToList()
                    }

                };
                masterList.Add(master);
            }

            masterList.ForEach(x => x.tehsillist.totalrecords = x.tehsillist.tehsils.Count);



            masterModel.masters = masterList;

            return masterModel;

        }
    }
}
