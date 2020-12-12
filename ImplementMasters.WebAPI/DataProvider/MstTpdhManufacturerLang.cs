using System;
using System.Collections.Generic;

namespace ImplementMasters.WebAPI.DataProvider
{
    public partial class MstTpdhManufacturerLang
    {
        public int Id { get; set; }
        public string MstTpdhManufacturercode { get; set; }
        public string MstTpdhManufacturername { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstLanguage MstLang { get; set; }
        public virtual MstTpdhManufacturer MstTpdhManufacturercodeNavigation { get; set; }
    }
}
