using System;
using System.Collections.Generic;

namespace EnquiryMasters.WebAPI.DataProvider
{
    public partial class MstDealerbranchhierarchy
    {
        public MstDealerbranchhierarchy()
        {
            MstCustprofile = new HashSet<MstCustprofile>();
            MstDealerbranchhierarchyLang = new HashSet<MstDealerbranchhierarchyLang>();
            PsCusttractorDtl = new HashSet<PsCusttractorDtl>();
            SrFreeservicecoupon = new HashSet<SrFreeservicecoupon>();
            SrJobcardHdr = new HashSet<SrJobcardHdr>();
            TblEnquiry = new HashSet<TblEnquiry>();
        }

        public string ParentCodeVc { get; set; }
        public string BranchCodeVc { get; set; }
        public string AssBranchCodeVc { get; set; }
        public string BranchCategoryVc { get; set; }
        public string BranchTypeVc { get; set; }
        public string MainDealerCodeVc { get; set; }
        public string BranchSuffixVc { get; set; }
        public string VillageCodeVc { get; set; }
        public string PincodeVc { get; set; }
        public string PhoneNoVc { get; set; }
        public string MobileNoVc { get; set; }
        public string FaxVc { get; set; }
        public string EmailIdVc { get; set; }
        public string SalesCodeVc { get; set; }
        public string ServiceCodeVc { get; set; }
        public string SparesCodeVc { get; set; }
        public string ActiveFlagC { get; set; }
        public string CreatedByVc { get; set; }
        public DateTime? CreatedDtD { get; set; }
        public string ModifiedByVc { get; set; }
        public DateTime? ModifiedDtD { get; set; }
        public string IsSalesVc { get; set; }
        public string IsServiceVc { get; set; }
        public string IsSparesVc { get; set; }
        public string IsUpdated { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public virtual Tdealermaster MainDealerCodeVcNavigation { get; set; }
        public virtual ICollection<MstCustprofile> MstCustprofile { get; set; }
        public virtual ICollection<MstDealerbranchhierarchyLang> MstDealerbranchhierarchyLang { get; set; }
        public virtual ICollection<PsCusttractorDtl> PsCusttractorDtl { get; set; }
        public virtual ICollection<SrFreeservicecoupon> SrFreeservicecoupon { get; set; }
        public virtual ICollection<SrJobcardHdr> SrJobcardHdr { get; set; }
        public virtual ICollection<TblEnquiry> TblEnquiry { get; set; }
    }
}
