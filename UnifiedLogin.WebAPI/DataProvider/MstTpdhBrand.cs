using System;
using System.Collections.Generic;

namespace UnifiedLogin.WebAPI.DataProvider
{
    public partial class MstTpdhBrand
    {
        public MstTpdhBrand()
        {
            MstTpdhBrandLang = new HashSet<MstTpdhBrandLang>();
            MstTpdhModel = new HashSet<MstTpdhModel>();
            MstTpdhModelgroup = new HashSet<MstTpdhModelgroup>();
        }

        public string BrandcodeVc { get; set; }
        public string SeriescodeVc { get; set; }
        public int? SectoridI { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
        public string ManufacturercodeVc { get; set; }

        public virtual MstTpdhManufacturer ManufacturercodeVcNavigation { get; set; }
        public virtual ICollection<MstTpdhBrandLang> MstTpdhBrandLang { get; set; }
        public virtual ICollection<MstTpdhModel> MstTpdhModel { get; set; }
        public virtual ICollection<MstTpdhModelgroup> MstTpdhModelgroup { get; set; }
    }
}
