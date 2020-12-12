using System;
using System.Collections.Generic;

namespace GeoMasters.WebAPI.DataProvider
{
    public partial class MstDesignation
    {
        public string DesigcodeVc { get; set; }
        public string DesignameVc { get; set; }
        public string DesigtypeC { get; set; }
        public string ActiveflagC { get; set; }
        public int? SectorIdI { get; set; }
        public string IsDeleteC { get; set; }
        public string SubmitTypeC { get; set; }
        public string SyncStatusC { get; set; }
        public string SyncRemarkVc { get; set; }
        public string CreatedByVc { get; set; }
        public DateTime? CreatedDtD { get; set; }
        public string ModifiedByVc { get; set; }
        public DateTime? ModifiedDtD { get; set; }
        public string DesigTypeVc { get; set; }
    }
}
