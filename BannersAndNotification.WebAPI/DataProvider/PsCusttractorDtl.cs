using System;
using System.Collections.Generic;

namespace BannersAndNotification.WebAPI.DataProvider
{
    public partial class PsCusttractorDtl
    {
        public PsCusttractorDtl()
        {
            PsCusttractorDtlLang = new HashSet<PsCusttractorDtlLang>();
        }

        public int Id { get; set; }
        public string DealerCodeVc { get; set; }
        public string CustCodeVc { get; set; }
        public string MasterTypeC { get; set; }
        public int? SrlNoN { get; set; }
        public string ServerCustCodeVc { get; set; }
        public string ModelCodeVc { get; set; }
        public string AvgHrsPaVc { get; set; }
        public string SerialNoVc { get; set; }
        public string YopVc { get; set; }
        public string YosVc { get; set; }
        public string TraSatLevelB { get; set; }
        public string SerSatLevelB { get; set; }
        public string SprSatLevelB { get; set; }
        public string TrackDissatVc { get; set; }
        public DateTime? RegDtD { get; set; }
        public string RegNoVc { get; set; }
        public DateTime? DopD { get; set; }
        public DateTime? DosD { get; set; }
        public string JobCardNoVc { get; set; }
        public string DealerBranchCodeVc { get; set; }
        public string CustTypeVc { get; set; }
        public decimal? KmReadingN { get; set; }
        public DateTime? PrmryWarDateD { get; set; }
        public DateTime? AddWarRegDateD { get; set; }
        public DateTime? WarrExpiryDateD { get; set; }
        public decimal? AddWarRegAmountN { get; set; }
        public string RegCouponVc { get; set; }
        public DateTime? AmcStartDateD { get; set; }
        public DateTime? AmcEndDateD { get; set; }
        public decimal? AmcAmountN { get; set; }
        public string AmcCodeVc { get; set; }
        public DateTime? AmcRegDateD { get; set; }
        public string IsDeleteC { get; set; }
        public string SubmitTypeC { get; set; }
        public int? SectorIdI { get; set; }
        public string CreatedByVc { get; set; }
        public DateTime? CreatedDtD { get; set; }
        public string ModifiedByVc { get; set; }
        public DateTime? ModifiedDtD { get; set; }
        public string SmscustStatusC { get; set; }
        public string SmsdealerStatusC { get; set; }
        public string CrmEnrichedStatus { get; set; }
        public DateTime? CrmEnrichmentDate { get; set; }
        public string AmcDealerCodeVc { get; set; }
        public string AddOnDealerCodeVc { get; set; }
        public string AddOnDealerBranchCodeVc { get; set; }
        public string DigisenseId { get; set; }
        public string LanguagePreference { get; set; }
        public int? VehicleType { get; set; }

        public virtual MstCustprofile CustCodeVcNavigation { get; set; }
        public virtual MstDealerbranchhierarchy DealerBranchCodeVcNavigation { get; set; }
        public virtual Tdealermaster DealerCodeVcNavigation { get; set; }
        public virtual MstVehiclType VehicleTypeNavigation { get; set; }
        public virtual ICollection<PsCusttractorDtlLang> PsCusttractorDtlLang { get; set; }
    }
}
