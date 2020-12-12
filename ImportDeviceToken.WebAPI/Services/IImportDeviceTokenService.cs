using ImportDeviceToken.WebAPI.Models.DeviceToken;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImportDeviceToken.WebAPI.Services
{
  public  interface IImportDeviceTokenService
    {
        public int devicetoken(DeviceToken input, string customerCode, string deviceID);
    }
}
