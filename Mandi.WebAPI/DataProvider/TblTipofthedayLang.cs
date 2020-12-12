using System;
using System.Collections.Generic;

namespace Mandi.WebAPI.DataProvider
{
    public partial class TblTipofthedayLang
    {
        public int Id { get; set; }
        public int TipId { get; set; }
        public string TipTitle { get; set; }
        public string TipText { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstLanguage MstLang { get; set; }
        public virtual TblTipoftheday Tip { get; set; }
    }
}
