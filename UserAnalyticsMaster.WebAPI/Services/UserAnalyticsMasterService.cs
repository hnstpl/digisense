using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAnalyticsMaster.WebAPI.DataProvider;
using UserAnalyticsMaster.WebAPI.Models.UserAnalytics;

namespace UserAnalyticsMaster.WebAPI.Services
{
    public class UserAnalyticsMasterService:IUserAnalyticsMasterService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;



        private readonly IConfiguration _config;
        private readonly IGlobalService _global;

        string moduleName = "";
        public UserAnalyticsMasterService(dev_encrypted_generalcustomerappContext dataContext, IConfiguration config, IGlobalService Global)
        {
            _context = dataContext;
            _config = config;
            _global = Global;

            //Get Module name from config to get the content version
            moduleName = _config.GetValue<string>("UserAnalyticsMaster:UserAnalytics");
        }

        public MastersModel GetUserAnalyticsMdules()
        {

            MastersModel masterModel = new MastersModel();

            var Records = new UserAnalyticsModulesMaster
            {
                contentversion = (from p in _context.TblVersionController
                                  where p.ModuleName == moduleName
                                  && p.ActiveflagC == "A"
                                  select p.Version).FirstOrDefault(),
                useranalyticsmodules = (from p in _context.MstUserAnalyticsMaster
                                        where p.ActiveflagC == "A"
                                        select new UserAnalyticsModules
                                        {
                                            moduleid = p.Id,
                                            modulename = p.ModuleName,
                                            submodules = (from o in _context.MstUserAnalyticsSubMaster
                                                          where o.ModuleId == p.Id
                                                          select new UserAnalyticsSubModules
                                                          {
                                                              submoduleid = o.Id,
                                                              submodulename = o.SubModuleName
                                                          }).ToList()
                                        }).ToList()
            };




            masterModel.masters = Records;

            return masterModel;

        }
    }
}
