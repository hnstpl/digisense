using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImportDeviceToken.WebAPI.Models.DeviceToken
{
    public class DeviceToken
    {
        public string brand { get; set; }
        public string deviceToken { get; set; }
        public string deviceType { get; set; }
        public string manufacturer { get; set; }
        public string os { get; set; }
        public string osVersion { get; set; }
    }
}
