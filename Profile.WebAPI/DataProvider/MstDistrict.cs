using System;
using System.Collections.Generic;

namespace Profile.WebAPI.DataProvider
{
    public partial class MstDistrict
    {
        public MstDistrict()
        {
            MstDistrictLang = new HashSet<MstDistrictLang>();
            MstTehsil = new HashSet<MstTehsil>();
            TblBannersLocationMapping = new HashSet<TblBannersLocationMapping>();
            TblTipofthedayLocationMapping = new HashSet<TblTipofthedayLocationMapping>();
            Tdealermaster = new HashSet<Tdealermaster>();
        }

        public string DistrictCodeVc { get; set; }
        public string StateCodeI { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstState StateCodeINavigation { get; set; }
        public virtual ICollection<MstDistrictLang> MstDistrictLang { get; set; }
        public virtual ICollection<MstTehsil> MstTehsil { get; set; }
        public virtual ICollection<TblBannersLocationMapping> TblBannersLocationMapping { get; set; }
        public virtual ICollection<TblTipofthedayLocationMapping> TblTipofthedayLocationMapping { get; set; }
        public virtual ICollection<Tdealermaster> Tdealermaster { get; set; }
    }
}
