using System;
using System.Collections.Generic;

namespace Profile.WebAPI.DataProvider
{
    public partial class MstIpdhModelFeaturesLang
    {
        public int Id { get; set; }
        public int FeatureId { get; set; }
        public string FeatureType { get; set; }
        public string FeatureName { get; set; }
        public string FeatureValue { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstIpdhModelFeatures Feature { get; set; }
        public virtual MstLanguage MstLang { get; set; }
    }
}
