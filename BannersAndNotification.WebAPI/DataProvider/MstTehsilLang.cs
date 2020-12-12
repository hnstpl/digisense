using System;
using System.Collections.Generic;

namespace BannersAndNotification.WebAPI.DataProvider
{
    public partial class MstTehsilLang
    {
        public int Id { get; set; }
        public string TehsilCodeVc { get; set; }
        public string TehsilNameVc { get; set; }
        public string TehsilShortNameVc { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstLanguage MstLang { get; set; }
        public virtual MstTehsil TehsilCodeVcNavigation { get; set; }
    }
}
