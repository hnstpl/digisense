using System;
using System.Collections.Generic;

namespace Mandi.WebAPI.DataProvider
{
    public partial class MstTpdhModelBenefits
    {
        public MstTpdhModelBenefits()
        {
            MstTpdhModelBenefitsLang = new HashSet<MstTpdhModelBenefitsLang>();
        }

        public int BenefitsId { get; set; }
        public string ModelcodeVc { get; set; }
        public string ActiveflagC { get; set; }
        public int? SectoridI { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstTpdhModel ModelcodeVcNavigation { get; set; }
        public virtual ICollection<MstTpdhModelBenefitsLang> MstTpdhModelBenefitsLang { get; set; }
    }
}
