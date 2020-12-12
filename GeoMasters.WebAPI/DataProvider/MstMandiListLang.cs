using System;
using System.Collections.Generic;

namespace GeoMasters.WebAPI.DataProvider
{
    public partial class MstMandiListLang
    {
        public int Id { get; set; }
        public int MandiId { get; set; }
        public string MandiName { get; set; }
        public string StateNameVc { get; set; }
        public string DistrictNameVc { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstMandiList Mandi { get; set; }
        public virtual MstLanguage MstLang { get; set; }
    }
}
