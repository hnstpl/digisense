using System;
using System.Collections.Generic;

namespace TractorMasters.WebAPI.DataProvider
{
    public partial class MstTpdhModelgroup
    {
        public MstTpdhModelgroup()
        {
            MstTpdhModel = new HashSet<MstTpdhModel>();
            MstTpdhModelgroupLang = new HashSet<MstTpdhModelgroupLang>();
        }

        public string ModelgroupcodeVc { get; set; }
        public string BrandcodeVc { get; set; }
        public int? SectoridI { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
        public string ActiveflagC { get; set; }

        public virtual MstTpdhBrand BrandcodeVcNavigation { get; set; }
        public virtual ICollection<MstTpdhModel> MstTpdhModel { get; set; }
        public virtual ICollection<MstTpdhModelgroupLang> MstTpdhModelgroupLang { get; set; }
    }
}
