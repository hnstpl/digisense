using System;
using System.Collections.Generic;

namespace EnquiryMasters.WebAPI.DataProvider
{
    public partial class MstIpdhModelgroupLang
    {
        public int Id { get; set; }
        public string IgcodeVc { get; set; }
        public string IgnameVc { get; set; }
        public string ShortNameVc { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstIpdhModelgroup IgcodeVcNavigation { get; set; }
        public virtual MstLanguage MstLang { get; set; }
    }
}
