using System;
using System.Collections.Generic;

namespace GeoMasters.WebAPI.DataProvider
{
    public partial class MstTpdhManufacturer
    {
        public MstTpdhManufacturer()
        {
            MstIpdhModel = new HashSet<MstIpdhModel>();
            MstTpdhBrand = new HashSet<MstTpdhBrand>();
            MstTpdhManufacturerLang = new HashSet<MstTpdhManufacturerLang>();
        }

        public string MstTpdhManufacturercode { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual ICollection<MstIpdhModel> MstIpdhModel { get; set; }
        public virtual ICollection<MstTpdhBrand> MstTpdhBrand { get; set; }
        public virtual ICollection<MstTpdhManufacturerLang> MstTpdhManufacturerLang { get; set; }
    }
}
