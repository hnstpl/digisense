using System;
using System.Collections.Generic;

namespace UserAnalyticsMaster.WebAPI.DataProvider
{
    public partial class SrJobcardHdr
    {
        public int Id { get; set; }
        public string DealerCode { get; set; }
        public string Jobcardno { get; set; }
        public DateTime? JobcarddateandTime { get; set; }
        public string Trsrno { get; set; }
        public decimal? HrsatTimeofRepairs { get; set; }
        public string Servicetype { get; set; }
        public string Servicesubtype { get; set; }
        public string Serviceadvisor { get; set; }
        public string CustomerComplaintsRef { get; set; }
        public decimal? Estimatedcost { get; set; }
        public DateTime? Expecteddeliverydate { get; set; }
        public string Technicianname { get; set; }
        public string PressureFrontRight { get; set; }
        public string PressureFrontLeft { get; set; }
        public string PressureRearRight { get; set; }
        public string PressureRearleft { get; set; }
        public string Jobtype { get; set; }
        public DateTime? Jobcardclosedate { get; set; }
        public DateTime? Nextserviceduedateandtime { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? Invoicedate { get; set; }
        public decimal? PartAmt { get; set; }
        public decimal? PartTax { get; set; }
        public decimal? PartAmount { get; set; }
        public decimal? LabAmt { get; set; }
        public decimal? LabTax { get; set; }
        public decimal? LabourAmount { get; set; }
        public decimal? SubletAmount { get; set; }
        public decimal? MiscAmount { get; set; }
        public decimal? OilAmount { get; set; }
        public decimal? OilTax { get; set; }
        public decimal? TotalOilAmount { get; set; }
        public string ModelName { get; set; }
        public string JcserviceTypeC { get; set; }
        public string JcserviceSubTypeC { get; set; }
        public string CustCodeVc { get; set; }
        public string ServAppointNoVc { get; set; }
        public string JcstatusC { get; set; }
        public DateTime? ServiceStartDateD { get; set; }
        public string PersonBroughtVc { get; set; }
        public string BroughtByVc { get; set; }
        public decimal? KmReadingN { get; set; }
        public string JobCardCatTypeC { get; set; }
        public string DealerBranchCodeVc { get; set; }
        public string ServiceEngineerVc { get; set; }
        public DateTime? PromiseddelryDateD { get; set; }
        public string JobCardTypeCodeC { get; set; }
        public string HoursReadingVc { get; set; }
        public string CustComplaintNt { get; set; }
        public string AdvComplaintNt { get; set; }
        public string MsredemptCouponNolabVc { get; set; }
        public DateTime? RedemptCouponDatelabD { get; set; }
        public string AmcdiscVc { get; set; }
        public string IsDeleteC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstCustprofile CustCodeVcNavigation { get; set; }
        public virtual MstDealerbranchhierarchy DealerBranchCodeVcNavigation { get; set; }
        public virtual Tdealermaster DealerCodeNavigation { get; set; }
    }
}
