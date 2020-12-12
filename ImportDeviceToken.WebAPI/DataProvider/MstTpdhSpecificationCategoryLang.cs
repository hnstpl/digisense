using System;
using System.Collections.Generic;

namespace ImportDeviceToken.WebAPI.DataProvider
{
    public partial class MstTpdhSpecificationCategoryLang
    {
        public int Id { get; set; }
        public int SpecCategoryId { get; set; }
        public string SpecCategoryName { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstLanguage MstLang { get; set; }
        public virtual MstTpdhSpecificationCategory SpecCategory { get; set; }
    }
}
