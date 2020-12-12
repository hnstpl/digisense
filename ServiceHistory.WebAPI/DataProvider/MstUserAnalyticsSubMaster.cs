using System;
using System.Collections.Generic;

namespace ServiceHistoryMaster.WebAPI.DataProvider
{
    public partial class MstUserAnalyticsSubMaster
    {
        public int Id { get; set; }
        public int? ModuleId { get; set; }
        public string SubModuleName { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstUserAnalyticsMaster Module { get; set; }
    }
}
