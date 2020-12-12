using System;
using System.Collections.Generic;

namespace ImportDeviceToken.WebAPI.DataProvider
{
    public partial class MstIpdhModelBenefits
    {
        public MstIpdhModelBenefits()
        {
            MstIpdhModelBenefitsLang = new HashSet<MstIpdhModelBenefitsLang>();
        }

        public int BenefitsId { get; set; }
        public string IpdhModelcodeVc { get; set; }
        public string ActiveflagC { get; set; }
        public int? SectoridI { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstIpdhModel IpdhModelcodeVcNavigation { get; set; }
        public virtual ICollection<MstIpdhModelBenefitsLang> MstIpdhModelBenefitsLang { get; set; }
    }
}
