using System;
using System.Collections.Generic;

namespace ImportDeviceToken.WebAPI.DataProvider
{
    public partial class MstCustprofile
    {
        public MstCustprofile()
        {
            MstCustprofileLang = new HashSet<MstCustprofileLang>();
            PsCusttractorDtl = new HashSet<PsCusttractorDtl>();
            SrJobcardHdr = new HashSet<SrJobcardHdr>();
            SrMshreeEnrolcustHdr = new HashSet<SrMshreeEnrolcustHdr>();
            SrMshreeRedemptionDtl = new HashSet<SrMshreeRedemptionDtl>();
            TblCutomerCropMapping = new HashSet<TblCutomerCropMapping>();
            TblCutomerMandiMapping = new HashSet<TblCutomerMandiMapping>();
            TblDevicetoken = new HashSet<TblDevicetoken>();
            TblEnquiry = new HashSet<TblEnquiry>();
            TblNotificationTracker = new HashSet<TblNotificationTracker>();
            TblOtptransactions = new HashSet<TblOtptransactions>();
        }

        public string CustCodeVc { get; set; }
        public string DealerCodeVc { get; set; }
        public string GlobalCustCodeVc { get; set; }
        public string OldCustomerCodeVc { get; set; }
        public string CustCoCodeVc { get; set; }
        public string PreferredAddressVc { get; set; }
        public string AreaPrefixVc { get; set; }
        public string VillageCodeVc { get; set; }
        public string OldVillageCodeVc { get; set; }
        public string OfficeVillageCodeVc { get; set; }
        public string PincodeVc { get; set; }
        public string PhonenoVc { get; set; }
        public string MobileNoVc { get; set; }
        public string EmailIdVc { get; set; }
        public string CustAgeI { get; set; }
        public string CustDobD { get; set; }
        public string FourWheelModelVc { get; set; }
        public string ActiveFlagC { get; set; }
        public DateTime? LastModifiedD { get; set; }
        public string CustTypeVc { get; set; }
        public decimal? CreditLimitN { get; set; }
        public string DealerBranchCodeVc { get; set; }
        public string PurchaseDateD { get; set; }
        public string EnrollDateD { get; set; }
        public string ReEnrollDateD { get; set; }
        public string MsLoyaltyPtsVc { get; set; }
        public string MsrCategoryVc { get; set; }
        public string MenrollNoVc { get; set; }
        public DateTime? AmcStartDateD { get; set; }
        public DateTime? AmcEndDateD { get; set; }
        public decimal? AmcAmountN { get; set; }
        public string IsDeleteC { get; set; }
        public string CustCategoryCodeVc { get; set; }
        public string CrmEnrichedStatus { get; set; }
        public DateTime? CrmEnrichmentDate { get; set; }
        public string AlternateMobNo { get; set; }
        public string ProfilePicName { get; set; }
        public string TractorEnabledType { get; set; }
        public string Password { get; set; }
        public int? LanguagePreference { get; set; }
        public string Ownedlandsize { get; set; }
        public string Leasedlandsize { get; set; }
        public string Education { get; set; }
        public int? ProfilePicNameVr { get; set; }
        public int? Tractorusage { get; set; }
        public int? EducationId { get; set; }
        public int? Version { get; set; }
        public string SalesmanNameVc { get; set; }

        public virtual MstDealerbranchhierarchy DealerBranchCodeVcNavigation { get; set; }
        public virtual Tdealermaster DealerCodeVcNavigation { get; set; }
        public virtual MstEducation EducationNavigation { get; set; }
        public virtual MstLanguage LanguagePreferenceNavigation { get; set; }
        public virtual MstVillage OfficeVillageCodeVcNavigation { get; set; }
        public virtual MstTractorusage TractorusageNavigation { get; set; }
        public virtual MstVillage VillageCodeVcNavigation { get; set; }
        public virtual ICollection<MstCustprofileLang> MstCustprofileLang { get; set; }
        public virtual ICollection<PsCusttractorDtl> PsCusttractorDtl { get; set; }
        public virtual ICollection<SrJobcardHdr> SrJobcardHdr { get; set; }
        public virtual ICollection<SrMshreeEnrolcustHdr> SrMshreeEnrolcustHdr { get; set; }
        public virtual ICollection<SrMshreeRedemptionDtl> SrMshreeRedemptionDtl { get; set; }
        public virtual ICollection<TblCutomerCropMapping> TblCutomerCropMapping { get; set; }
        public virtual ICollection<TblCutomerMandiMapping> TblCutomerMandiMapping { get; set; }
        public virtual ICollection<TblDevicetoken> TblDevicetoken { get; set; }
        public virtual ICollection<TblEnquiry> TblEnquiry { get; set; }
        public virtual ICollection<TblNotificationTracker> TblNotificationTracker { get; set; }
        public virtual ICollection<TblOtptransactions> TblOtptransactions { get; set; }
    }
}
