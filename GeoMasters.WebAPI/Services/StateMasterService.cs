using GeoMasters.WebAPI.DataProvider;
using GeoMasters.WebAPI.Models.StateMaster;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMasters.WebAPI.Services
{
    public class StateMasterService:IStateMasterService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;



        private readonly IConfiguration _config;
        private readonly IGlobalService _global;

        string moduleName = "";
        public StateMasterService(dev_encrypted_generalcustomerappContext dataContext, IConfiguration config, IGlobalService Global)
        {
            _context = dataContext;
            _config = config;
            _global = Global;

            //Get Module name from config to get the content version
            moduleName = _config.GetValue<string>("GeoMasters:StateMaster");
        }

        public MastersModel GetStates(string LanguageCode, string customerCode)
        {

            MastersModel masterModel = new MastersModel();


            //Get Languages
            List<MstLanguage> languages = _global.GetLanguageList(LanguageCode, customerCode);


            List<StateMaster> masterList = new List<StateMaster>();
            foreach (var Language in languages)
            {
                StateMaster master = new StateMaster
                {
                    contentversion = (from p in _context.TblVersionController
                                      where p.ActiveflagC == "A"
                                      && p.ModuleName == moduleName
                                      select p.Version.Value).FirstOrDefault(),
                    languagecode = Language.LanguageCode,
                    stateslist = new StatesList
                    {
                        states = (from p in _context.MstStateLang
                                  join o in _context.MstState on p.StateCodeI equals o.StateCodeI
                                  where p.ActiveflagC == "A" && o.ActiveFlagC == "A"
                                  & p.MstLangId == Language.Id
                                  select new States
                                  {
                                      statecode = o.StateCodeI,
                                      statename = p.StateNameVc
                                  }).ToList()
                    }

                };
                masterList.Add(master);
            }

            masterList.ForEach(x => x.stateslist.totalrecords = x.stateslist.states.Count);



            masterModel.masters = masterList;

            return masterModel;

        }
    }
}
