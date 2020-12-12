using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAnalyticsMaster.WebAPI.DataProvider;
using UserAnalyticsMaster.WebAPI.Models.UserAnalytics;

namespace UserAnalyticsMaster.WebAPI.Services
{
    public class UserAnalyticsService:IUserAnalyticsService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;



        private readonly IConfiguration _config;
        private readonly IGlobalService _global;

        string moduleName = "";
        public UserAnalyticsService(dev_encrypted_generalcustomerappContext dataContext, IConfiguration config, IGlobalService Global)
        {
            _context = dataContext;
            _config = config;
            _global = Global;
        }

        public int CaptureUpdate(UserAnalyticsCapture input, string customerCode)
        {
            int Result = 0;

            foreach (var itm in input.useranalytics)
            {
                var startTime = new DateTime(1970, 1, 1).Add(TimeSpan.FromSeconds((int)Convert.ToDouble(itm.starttime)));
                var endTime = new DateTime(1970, 1, 1).Add(TimeSpan.FromSeconds((int)Convert.ToDouble(itm.endtime)));

                TblUserAnalytics Record = new TblUserAnalytics
                {
                    CustomerCodeVc = customerCode,
                    ModuleId = itm.moduleid,
                    SubModuleId = itm.submoduleid,
                    ModelCode = itm.modelcode,
                    StartTime = startTime,
                    EndTime = endTime,
                    Duration = (int)(itm.endtime - itm.starttime),
                    DeviceId = itm.deviceid,
                    Osversion = itm.osversion,
                    ActiveflagC = "A",
                    CreatedbyVc = customerCode
                };

                _context.TblUserAnalytics.Add(Record);
            }

            Result = _context.SaveChanges();

            return Result;

        }
    }
}
