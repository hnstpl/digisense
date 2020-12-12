using System;
using System.Collections.Generic;

namespace Profile.WebAPI.DataProvider
{
    public partial class MstTipofthedayCategory
    {
        public MstTipofthedayCategory()
        {
            MstTipofthedayCategoryLang = new HashSet<MstTipofthedayCategoryLang>();
            TblTipoftheday = new HashSet<TblTipoftheday>();
        }

        public int TipCategoryId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual ICollection<MstTipofthedayCategoryLang> MstTipofthedayCategoryLang { get; set; }
        public virtual ICollection<TblTipoftheday> TblTipoftheday { get; set; }
    }
}
