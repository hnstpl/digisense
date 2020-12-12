using System;
using System.Collections.Generic;

namespace DIYMaster.WebAPI.DataProvider
{
    public partial class MstTipofthedayCategoryLang
    {
        public int Id { get; set; }
        public int TipCategoryId { get; set; }
        public string CategoryName { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstLanguage MstLang { get; set; }
        public virtual MstTipofthedayCategory TipCategory { get; set; }
    }
}
