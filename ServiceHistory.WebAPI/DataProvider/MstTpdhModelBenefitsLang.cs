using System;
using System.Collections.Generic;

namespace ServiceHistoryMaster.WebAPI.DataProvider
{
    public partial class MstTpdhModelBenefitsLang
    {
        public int Id { get; set; }
        public int BenefitsId { get; set; }
        public string BenefitsType { get; set; }
        public string BenefitsName { get; set; }
        public string BenefitsValue { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstTpdhModelBenefits Benefits { get; set; }
        public virtual MstLanguage MstLang { get; set; }
    }
}
