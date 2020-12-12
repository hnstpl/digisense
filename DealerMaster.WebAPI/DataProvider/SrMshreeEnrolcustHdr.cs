using System;
using System.Collections.Generic;

namespace DealerMaster.WebAPI.DataProvider
{
    public partial class SrMshreeEnrolcustHdr
    {
        public int Id { get; set; }
        public string DealerCode { get; set; }
        public string Customercode { get; set; }
        public string ServerCustomerCode { get; set; }
        public string Customername { get; set; }
        public string Village { get; set; }
        public string Tehsil { get; set; }
        public string District { get; set; }
        public string Phoneno { get; set; }
        public string ModelPurchased { get; set; }
        public string TrsrlNo { get; set; }
        public DateTime? DateofSale { get; set; }
        public string MembershipNo { get; set; }
        public DateTime? Membershipdate { get; set; }
        public decimal? Loyaltypts { get; set; }
        public decimal? TotalLoyaltypts { get; set; }
        public string PrevTrModel { get; set; }
        public string PrevTrsrlNo { get; set; }
        public string Mscategory { get; set; }
        public DateTime? DateofCatagoryUpdatation { get; set; }
        public string ReferedByOrToCustCode { get; set; }
        public string ReferredByOrTo { get; set; }
        public string ReferredByOrTophoneno { get; set; }
        public string ReferredByOrToMembershipNo { get; set; }
        public string ReferralCouponno { get; set; }
        public DateTime? CouponCollectionDate { get; set; }
        public string Deliverymasterno { get; set; }
        public string PointsType { get; set; }
        public string Activeflag { get; set; }
        public string Docstatuscode { get; set; }
        public string DealerBranchCode { get; set; }
        public string CreatedByVc { get; set; }
        public DateTime? CreatedDtD { get; set; }
        public string ModifiedByVc { get; set; }
        public DateTime? ModifiedDtD { get; set; }
        public string SmsStatusC { get; set; }
        public string IsDeleteC { get; set; }
        public string DelvrysmsStatusC { get; set; }
        public string UpgradeSmsStatusC { get; set; }
        public string ReferenceNoVc { get; set; }

        public virtual MstCustprofile CustomercodeNavigation { get; set; }
        public virtual Tdealermaster DealerCodeNavigation { get; set; }
    }
}
