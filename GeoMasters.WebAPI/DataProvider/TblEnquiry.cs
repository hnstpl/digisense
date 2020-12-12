using System;
using System.Collections.Generic;

namespace GeoMasters.WebAPI.DataProvider
{
    public partial class TblEnquiry
    {
        public TblEnquiry()
        {
            TblEnquiryImageMapping = new HashSet<TblEnquiryImageMapping>();
        }

        public int EnqId { get; set; }
        public int? EnqTypeId { get; set; }
        public string CustCodeVc { get; set; }
        public string DealerCodeVc { get; set; }
        public string VillageCodeVc { get; set; }
        public int? ProductNimplement { get; set; }
        public string ReferralName { get; set; }
        public string ReferralVillageCodeVc { get; set; }
        public string ReferralMobileNoVc { get; set; }
        public string EnqTicketId { get; set; }
        public string EnqStatus { get; set; }
        public string TpdhModelcodeVc { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
        public string IpdhModelcodeVc { get; set; }
        public string EnqRemarks { get; set; }
        public string ManufacturercodeVc { get; set; }
        public string Isrcavailable { get; set; }
        public string YearOfManufacture { get; set; }
        public int? IntrestedIn { get; set; }
        public string IntrestedInTpdhModelcodeVc { get; set; }
        public string IntrestedInIpdhModelcodeVc { get; set; }
        public string DealerBranchCodeVc { get; set; }
        public string Tractorbrand { get; set; }

        public virtual MstCustprofile CustCodeVcNavigation { get; set; }
        public virtual MstDealerbranchhierarchy DealerBranchCodeVcNavigation { get; set; }
        public virtual Tdealermaster DealerCodeVcNavigation { get; set; }
        public virtual MstEnqType EnqType { get; set; }
        public virtual MstIpdhModel IntrestedInIpdhModelcodeVcNavigation { get; set; }
        public virtual MstTpdhModel IntrestedInTpdhModelcodeVcNavigation { get; set; }
        public virtual ICollection<TblEnquiryImageMapping> TblEnquiryImageMapping { get; set; }
    }
}
