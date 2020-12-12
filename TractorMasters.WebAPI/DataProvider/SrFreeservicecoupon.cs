using System;
using System.Collections.Generic;

namespace TractorMasters.WebAPI.DataProvider
{
    public partial class SrFreeservicecoupon
    {
        public int Id { get; set; }
        public string DealerCodeVc { get; set; }
        public string LocalFsccodeVc { get; set; }
        public string ServiceCouponNo { get; set; }
        public int? CouponNo { get; set; }
        public string ServiceCouponNoSap { get; set; }
        public string CustomerName { get; set; }
        public string TractorSrNo { get; set; }
        public string SellingDlrCode { get; set; }
        public string ServicingDlrCode { get; set; }
        public DateTime? SellDate { get; set; }
        public DateTime? ServiceDate { get; set; }
        public string HoursOperated { get; set; }
        public string Aocode { get; set; }
        public string Amount { get; set; }
        public string DocType { get; set; }
        public string Creditno { get; set; }
        public DateTime? Creditdate { get; set; }
        public string Debitno { get; set; }
        public DateTime? Debitdate { get; set; }
        public string DocStatusCode { get; set; }
        public string DocNotes { get; set; }
        public string SapreplyNote { get; set; }
        public string SaprefNo { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string InstallationLocation { get; set; }
        public string InstalledBy { get; set; }
        public DateTime? SubmittedOn { get; set; }
        public string JobCardNo { get; set; }
        public string ErrorFlag { get; set; }
        public string ErrorDesc { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? XmlgenerationDate { get; set; }
        public int? SectorIdI { get; set; }
        public string ActiveflagC { get; set; }
        public string SubmitTypeC { get; set; }
        public string CreatedByVc { get; set; }
        public DateTime? CreatedDtD { get; set; }
        public string ModifiedByVc { get; set; }
        public DateTime? ModifiedDtD { get; set; }
        public string DealerBranchCodeVc { get; set; }
        public string AddOnInvoiceNoVc { get; set; }
        public string ClaimNo { get; set; }
        public string TaxinvnoVc { get; set; }
        public DateTime? TaxinvdtDt { get; set; }
        public string Plant { get; set; }
        public string GstnoVc { get; set; }
        public string Odnno { get; set; }
        public string IsSigned { get; set; }

        public virtual MstDealerbranchhierarchy DealerBranchCodeVcNavigation { get; set; }
        public virtual Tdealermaster DealerCodeVcNavigation { get; set; }
    }
}
