using System;
using System.Collections.Generic;

namespace ImportDeviceToken.WebAPI.DataProvider
{
    public partial class MstDistrictLang
    {
        public int Id { get; set; }
        public string DistrictCodeVc { get; set; }
        public string DistrictNameVc { get; set; }
        public string DistrictShortNameVc { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstDistrict DistrictCodeVcNavigation { get; set; }
        public virtual MstLanguage MstLang { get; set; }
    }
}
