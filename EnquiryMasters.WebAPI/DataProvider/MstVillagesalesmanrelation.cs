using System;
using System.Collections.Generic;

namespace EnquiryMasters.WebAPI.DataProvider
{
    public partial class MstVillagesalesmanrelation
    {
        public int Id { get; set; }
        public string DealerCodeVc { get; set; }
        public string SalesmanNoVc { get; set; }
        public string VillageNoVc { get; set; }
        public string ActiveFlagC { get; set; }
        public string UserIdVc { get; set; }
        public string DocStatusCodeVc { get; set; }
        public string DealerBranchCodeVc { get; set; }
        public int? SectorIdI { get; set; }
        public string CreatedByVc { get; set; }
        public DateTime? CreatedDtD { get; set; }
        public string ModifiedByVc { get; set; }
        public DateTime? ModifiedDtD { get; set; }
    }
}
