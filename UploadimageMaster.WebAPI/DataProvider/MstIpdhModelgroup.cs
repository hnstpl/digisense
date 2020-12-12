using System;
using System.Collections.Generic;

namespace UploadimageMaster.WebAPI.DataProvider
{
    public partial class MstIpdhModelgroup
    {
        public MstIpdhModelgroup()
        {
            MstIpdhModel = new HashSet<MstIpdhModel>();
            MstIpdhModelgroupLang = new HashSet<MstIpdhModelgroupLang>();
        }

        public string IgcodeVc { get; set; }
        public string ActiveFlagC { get; set; }
        public int? SectorIdI { get; set; }
        public string CreatedByVc { get; set; }
        public DateTime? CreatedDtD { get; set; }
        public string ModifiedByVc { get; set; }
        public DateTime? ModifiedDtD { get; set; }
        public string ModelImgVc { get; set; }

        public virtual ICollection<MstIpdhModel> MstIpdhModel { get; set; }
        public virtual ICollection<MstIpdhModelgroupLang> MstIpdhModelgroupLang { get; set; }
    }
}
