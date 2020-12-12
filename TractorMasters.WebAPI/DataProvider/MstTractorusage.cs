using System;
using System.Collections.Generic;

namespace TractorMasters.WebAPI.DataProvider
{
    public partial class MstTractorusage
    {
        public MstTractorusage()
        {
            MstCustprofile = new HashSet<MstCustprofile>();
        }

        public int Id { get; set; }
        public string Usagename { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
        public string TractorUseCodeVc { get; set; }
        public string TractorSubUseNameVc { get; set; }
        public string TractorSubUseShortNameVc { get; set; }
        public string RefCodeVc { get; set; }
        public string ShowSeqVc { get; set; }
        public string ActiveC { get; set; }
        public string DealerBranchCodeVc { get; set; }
        public int? SectorIdI { get; set; }

        public virtual ICollection<MstCustprofile> MstCustprofile { get; set; }
    }
}
