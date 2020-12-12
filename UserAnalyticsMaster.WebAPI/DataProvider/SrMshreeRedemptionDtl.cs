using System;
using System.Collections.Generic;

namespace UserAnalyticsMaster.WebAPI.DataProvider
{
    public partial class SrMshreeRedemptionDtl
    {
        public int Id { get; set; }
        public string DealerCode { get; set; }
        public string LocalRedemptCodeVc { get; set; }
        public string Customercode { get; set; }
        public string Customername { get; set; }
        public string Membershipno { get; set; }
        public DateTime? RedemptReqDate { get; set; }
        public decimal? RedemptPts { get; set; }
        public decimal? Loyalpts { get; set; }
        public DateTime? RedemptCouponDate { get; set; }
        public string RedemptProduct { get; set; }
        public string Productcode { get; set; }
        public string Docstatuscode { get; set; }
        public string DealerBranchCode { get; set; }
        public string RedCategory { get; set; }
        public string SubmitTypeC { get; set; }
        public string CreatedByVc { get; set; }
        public DateTime? CreatedDtD { get; set; }
        public string ModifiedByVc { get; set; }
        public DateTime? ModifiedDtD { get; set; }
        public string SmsstatusC { get; set; }
        public string ReferenceNoVc { get; set; }

        public virtual MstCustprofile CustomercodeNavigation { get; set; }
        public virtual Tdealermaster DealerCodeNavigation { get; set; }
    }
}
