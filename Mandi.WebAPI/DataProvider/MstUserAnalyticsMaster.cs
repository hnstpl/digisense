using System;
using System.Collections.Generic;

namespace Mandi.WebAPI.DataProvider
{
    public partial class MstUserAnalyticsMaster
    {
        public MstUserAnalyticsMaster()
        {
            MstUserAnalyticsSubMaster = new HashSet<MstUserAnalyticsSubMaster>();
        }

        public int Id { get; set; }
        public string ModuleName { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual ICollection<MstUserAnalyticsSubMaster> MstUserAnalyticsSubMaster { get; set; }
    }
}
