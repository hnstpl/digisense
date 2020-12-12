using System;
using System.Collections.Generic;

namespace UserAnalyticsMaster.WebAPI.DataProvider
{
    public partial class MstVillageLang
    {
        public int Id { get; set; }
        public string VillageCodeVc { get; set; }
        public string VillageNameVc { get; set; }
        public string VillageShortNameVc { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public virtual MstLanguage MstLang { get; set; }
        public virtual MstVillage VillageCodeVcNavigation { get; set; }
    }
}
