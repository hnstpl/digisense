using System;
using System.Collections.Generic;

namespace ImportDeviceToken.WebAPI.DataProvider
{
    public partial class MstDealerbranchhierarchyLang
    {
        public int Id { get; set; }
        public string BranchCodeVc { get; set; }
        public string BranchNameVc { get; set; }
        public string BranchlLocationVc { get; set; }
        public string Address1Vc { get; set; }
        public string Address2Vc { get; set; }
        public string Address3Vc { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstDealerbranchhierarchy BranchCodeVcNavigation { get; set; }
        public virtual MstLanguage MstLang { get; set; }
    }
}
