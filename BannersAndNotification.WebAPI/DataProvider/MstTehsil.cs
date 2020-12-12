using System;
using System.Collections.Generic;

namespace BannersAndNotification.WebAPI.DataProvider
{
    public partial class MstTehsil
    {
        public MstTehsil()
        {
            MstTehsilLang = new HashSet<MstTehsilLang>();
            MstVillage = new HashSet<MstVillage>();
        }

        public string TehsilCodeVc { get; set; }
        public string DistrictCodeVc { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstDistrict DistrictCodeVcNavigation { get; set; }
        public virtual ICollection<MstTehsilLang> MstTehsilLang { get; set; }
        public virtual ICollection<MstVillage> MstVillage { get; set; }
    }
}
