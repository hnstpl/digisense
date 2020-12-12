using System;
using System.Collections.Generic;

namespace ServiceHistoryMaster.WebAPI.DataProvider
{
    public partial class MstTpdhModelgroupLang
    {
        public int Id { get; set; }
        public string ModelgroupcodeVc { get; set; }
        public string ModelgroupnameVc { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstTpdhModelgroup ModelgroupcodeVcNavigation { get; set; }
        public virtual MstLanguage MstLang { get; set; }
    }
}
