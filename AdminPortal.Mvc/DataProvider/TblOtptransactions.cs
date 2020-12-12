using System;
using System.Collections.Generic;

namespace AdminPortal.Mvc.DataProvider
{
    public partial class TblOtptransactions
    {
        public int Id { get; set; }
        public string CustCodeVc { get; set; }
        public string Otp { get; set; }
        public string ActiveFlagC { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UsedOn { get; set; }

        public virtual MstCustprofile CustCodeVcNavigation { get; set; }
    }
}
