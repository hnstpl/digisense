using BannersAndNotification.WebAPI.DataProvider;
using BannersAndNotification.WebAPI.Models.BannerActionMaster;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BannersAndNotification.WebAPI.Services
{
    public class BannerActionMasterService:IBannerActionMasterService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;



        private readonly IConfiguration _config;
        private readonly IGlobalService _global;

        string moduleName = "";
        public BannerActionMasterService(dev_encrypted_generalcustomerappContext dataContext, IConfiguration config, IGlobalService Global)
        {
            _context = dataContext;
            _config = config;
            _global = Global;

            //Get Module name from config to get the content version
            moduleName = _config.GetValue<string>("BannerActionMaster:DistrictMaster");
        }

        public MastersModel GetBannerActionTypes(string LanguageCode, string customerCode)
        {

            MastersModel masterModel = new MastersModel();


            //Get Languages
            List<MstLanguage> languages = _global.GetLanguageList(LanguageCode, customerCode);

            List<HomeBannerTypeMaster> masterList = new List<HomeBannerTypeMaster>();
            foreach (var Language in languages)
            {
                HomeBannerTypeMaster master = new HomeBannerTypeMaster
                {
                    contentversion = (from p in _context.TblVersionController
                                      where p.ActiveflagC == "A"
                                      && p.ModuleName == moduleName
                                      select p.Version.Value).FirstOrDefault(),
                    languagecode = Language.LanguageCode,
                    homepagebanneractiontypelist = new HomePageBannerActionTypesList
                    {
                        homepagebanneractiontypes = (from p in _context.MstBanneractiontypeLang
                                                     join o in _context.MstBanneractiontype on p.ActionTypeId equals o.ActionTypeId
                                                     where p.MstLangId == Language.Id
                                                     select new HomePageBannerActionTypes
                                                     {
                                                         id = o.ActionTypeId,
                                                         actiontype = p.ActionTypeName,

                                                         subtypes = (
                                                                        from s in _context.MstBanneractionsubtype
                                                                        where s.ActionTypeId == o.ActionTypeId
                                                                        select new BannerActionsubType
                                                                        {
                                                                            id = s.Id,
                                                                            actionsubtype = s.ActionSubTypeName
                                                                        }).ToList()
                                                     }).ToList()
                    }
                };



                //Update the count
                master.homepagebanneractiontypelist.totalrecords = master.homepagebanneractiontypelist.homepagebanneractiontypes.Count;

                masterList.Add(master);
            }





            masterModel.masters = masterList;

            return masterModel;

        }
    }
}
