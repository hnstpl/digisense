using System;
using System.Collections.Generic;

namespace GeoMasters.WebAPI.DataProvider
{
    public partial class MstTpdhModelFeatures
    {
        public MstTpdhModelFeatures()
        {
            MstTpdhModelFeaturesLang = new HashSet<MstTpdhModelFeaturesLang>();
        }

        public int FeatureId { get; set; }
        public string FeatureImageUrl { get; set; }
        public string ModelcodeVc { get; set; }
        public string ActiveflagC { get; set; }
        public int? SectoridI { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
        public int? ImageVersion { get; set; }

        public virtual MstTpdhModel ModelcodeVcNavigation { get; set; }
        public virtual ICollection<MstTpdhModelFeaturesLang> MstTpdhModelFeaturesLang { get; set; }
    }
}
