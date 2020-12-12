using System;
using System.Collections.Generic;

namespace Mandi.WebAPI.DataProvider
{
    public partial class MstAreaofficeLang
    {
        public int Id { get; set; }
        public string AocodeVc { get; set; }
        public string AonameVc { get; set; }
        public string Aoaddr1Vc { get; set; }
        public string Aoaddr2Vc { get; set; }
        public string Aoaddr3Vc { get; set; }
        public string Aoaddr4Vc { get; set; }
        public string AostreetVc { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstAreaoffice AocodeVcNavigation { get; set; }
        public virtual MstLanguage MstLang { get; set; }
    }
}
