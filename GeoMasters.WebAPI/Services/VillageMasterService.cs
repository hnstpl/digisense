using GeoMasters.WebAPI.DataProvider;
using GeoMasters.WebAPI.Models.VillageMaster;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMasters.WebAPI.Services
{
    public class VillageMasterService:IVillageMasterService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;



        private readonly IConfiguration _config;
        private readonly IGlobalService _global;

        string moduleName = "";
        public VillageMasterService(dev_encrypted_generalcustomerappContext dataContext, IConfiguration config, IGlobalService Global)
        {
            _context = dataContext;
            _config = config;
            _global = Global;

            //Get Module name from config to get the content version
            moduleName = _config.GetValue<string>("GeoMasters:VillageMaster");
        }

        public MastersModel GetVillages(string LanguageCode, string customerCode, TehsilCode tehsilcode)
        {

            MastersModel masterModel = new MastersModel();

            //Get Languages
            List<MstLanguage> languages = _global.GetLanguageList(LanguageCode, customerCode);


            List<VillageMaster> masterList = new List<VillageMaster>();
            foreach (var Language in languages)
            {
                VillageMaster master = new VillageMaster
                {
                    contentversion = (from p in _context.TblVersionController
                                      where p.ActiveflagC == "A"
                                      && p.ModuleName == moduleName
                                      select p.Version.Value).FirstOrDefault(),
                    languagecode = Language.LanguageCode,
                    villagelist = new VillagesList
                    {
                        villages = (from p in _context.MstVillageLang
                                    join o in _context.MstVillage on p.VillageCodeVc equals o.VillageCodeVc
                                    where p.ActiveflagC == "A" && o.ActiveflagC == "A"
                                    && p.MstLangId == Language.Id
                                   && (string.IsNullOrEmpty(tehsilcode.tehsilcode) || o.TehsilCodeVc == tehsilcode.tehsilcode)
                                    select new Villages
                                    {
                                        villagecode = o.VillageCodeVc,
                                        villagename = p.VillageNameVc,
                                        tehsilcode = o.TehsilCodeVc
                                    }).ToList()

                    }

                };
                masterList.Add(master);
            }

            masterList.ForEach(x => x.villagelist.totalrecords = x.villagelist.villages.Count);



            masterModel.masters = masterList;

            return masterModel;

        }
    }
}
