using ImportDeviceToken.WebAPI.DataProvider;
using ImportDeviceToken.WebAPI.Models.DeviceToken;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImportDeviceToken.WebAPI.Services
{
    public class ImportDeviceTokenService:IImportDeviceTokenService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;



        private readonly IConfiguration _config;
        private readonly IGlobalService _global;

        string moduleName = "";
        public ImportDeviceTokenService(dev_encrypted_generalcustomerappContext dataContext, IConfiguration config, IGlobalService Global)
        {
            _context = dataContext;
            _config = config;
            _global = Global;
        }

        public int devicetoken(DeviceToken input, string customerCode, string deviceID)
        {

            int Result = 0;

            var record = (from p in _context.TblDevicetoken
                          where p.CustCodeVc == customerCode && p.ActiveFlagC == "A"
                          && p.DeviceId == deviceID
                          select p).FirstOrDefault();

            if (record != null)
            {
                record.ActiveFlagC = "I";
            }

            var newRecord = new TblDevicetoken
            {
                CustCodeVc = customerCode,
                DeviceId = deviceID,
                DeviceToken = input.deviceToken,
                Brand = input.brand,
                DeviceType = input.deviceType,
                Manufacturer = input.manufacturer,
                Os = input.os,
                Osversion = input.osVersion,
                ActiveFlagC = "A",
                CreatedOn = DateTime.Now
            };

            _context.TblDevicetoken.Add(newRecord);

            Result=_context.SaveChanges();

            return Result;

        }
    }
}
