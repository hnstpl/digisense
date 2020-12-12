using System;
using System.Collections.Generic;

namespace Masters.WebAPI.DataProvider
{
    public partial class TblTipoftheday
    {
        public TblTipoftheday()
        {
            TblTipofthedayLang = new HashSet<TblTipofthedayLang>();
            TblTipofthedayLocationMapping = new HashSet<TblTipofthedayLocationMapping>();
        }

        public int TipId { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidThru { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstTipofthedayCategory Category { get; set; }
        public virtual ICollection<TblTipofthedayLang> TblTipofthedayLang { get; set; }
        public virtual ICollection<TblTipofthedayLocationMapping> TblTipofthedayLocationMapping { get; set; }
    }
}
