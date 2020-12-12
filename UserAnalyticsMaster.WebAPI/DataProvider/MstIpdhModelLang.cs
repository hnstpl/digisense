using System;
using System.Collections.Generic;

namespace UserAnalyticsMaster.WebAPI.DataProvider
{
    public partial class MstIpdhModelLang
    {
        public int Id { get; set; }
        public string ModelcodeVc { get; set; }
        public string ModelnameVc { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstIpdhModel ModelcodeVcNavigation { get; set; }
        public virtual MstLanguage MstLang { get; set; }
    }
}
