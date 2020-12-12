using System;
using System.Collections.Generic;

namespace UnifiedLogin.WebAPI.DataProvider
{
    public partial class TblDevicetoken
    {
        public int Id { get; set; }
        public string CustCodeVc { get; set; }
        public string DeviceId { get; set; }
        public string DeviceToken { get; set; }
        public string Brand { get; set; }
        public string DeviceType { get; set; }
        public string Manufacturer { get; set; }
        public string Os { get; set; }
        public string Osversion { get; set; }
        public string ActiveFlagC { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual MstCustprofile CustCodeVcNavigation { get; set; }
    }
}
