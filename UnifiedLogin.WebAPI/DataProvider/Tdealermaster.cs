using System;
using System.Collections.Generic;

namespace UnifiedLogin.WebAPI.DataProvider
{
    public partial class Tdealermaster
    {
        public Tdealermaster()
        {
            MstCustprofile = new HashSet<MstCustprofile>();
            MstDealerbranchhierarchy = new HashSet<MstDealerbranchhierarchy>();
            PsCusttractorDtl = new HashSet<PsCusttractorDtl>();
            SrFreeservicecoupon = new HashSet<SrFreeservicecoupon>();
            SrJobcardHdr = new HashSet<SrJobcardHdr>();
            SrMshreeEnrolcustHdr = new HashSet<SrMshreeEnrolcustHdr>();
            SrMshreeRedemptionDtl = new HashSet<SrMshreeRedemptionDtl>();
            TblEnquiry = new HashSet<TblEnquiry>();
            TdealermasterLang = new HashSet<TdealermasterLang>();
        }

        public string DealerCode { get; set; }
        public string CategoryCodeVc { get; set; }
        public string BranchCodeVc { get; set; }
        public string AccountCode { get; set; }
        public string City { get; set; }
        public string StateCodeI { get; set; }
        public string DistrictCodeVc { get; set; }
        public string Aocode { get; set; }
        public string PinCode { get; set; }
        public string TelOff1 { get; set; }
        public string TelOff2 { get; set; }
        public string Email { get; set; }
        public string DealerType { get; set; }
        public string DealerPhoto { get; set; }
        public string Status { get; set; }
        public int? SectorIdI { get; set; }
        public string CreatedByVc { get; set; }
        public DateTime? CreatedDtD { get; set; }
        public string ModifiedByVc { get; set; }
        public DateTime? ModifiedDtD { get; set; }
        public string DealerBranchCode { get; set; }
        public string DealerTypeVc { get; set; }
        public string MahindraShree { get; set; }
        public int? TypeofofficeI { get; set; }

        public virtual MstAreaoffice AocodeNavigation { get; set; }
        public virtual MstDistrict DistrictCodeVcNavigation { get; set; }
        public virtual MstState StateCodeINavigation { get; set; }
        public virtual ICollection<MstCustprofile> MstCustprofile { get; set; }
        public virtual ICollection<MstDealerbranchhierarchy> MstDealerbranchhierarchy { get; set; }
        public virtual ICollection<PsCusttractorDtl> PsCusttractorDtl { get; set; }
        public virtual ICollection<SrFreeservicecoupon> SrFreeservicecoupon { get; set; }
        public virtual ICollection<SrJobcardHdr> SrJobcardHdr { get; set; }
        public virtual ICollection<SrMshreeEnrolcustHdr> SrMshreeEnrolcustHdr { get; set; }
        public virtual ICollection<SrMshreeRedemptionDtl> SrMshreeRedemptionDtl { get; set; }
        public virtual ICollection<TblEnquiry> TblEnquiry { get; set; }
        public virtual ICollection<TdealermasterLang> TdealermasterLang { get; set; }
    }
}
