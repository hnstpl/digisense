using System;
using System.Collections.Generic;

namespace UserAnalyticsMaster.WebAPI.DataProvider
{
    public partial class MstBanneractiontypeLang
    {
        public int Id { get; set; }
        public int ActionTypeId { get; set; }
        public string ActionTypeName { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstBanneractiontype ActionType { get; set; }
        public virtual MstLanguage MstLang { get; set; }
    }
}
