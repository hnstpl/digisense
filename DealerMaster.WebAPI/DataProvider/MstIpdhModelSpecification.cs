using System;
using System.Collections.Generic;

namespace DealerMaster.WebAPI.DataProvider
{
    public partial class MstIpdhModelSpecification
    {
        public MstIpdhModelSpecification()
        {
            MstIpdhModelSpecificationLang = new HashSet<MstIpdhModelSpecificationLang>();
        }

        public int SpecificationId { get; set; }
        public string IpdhModelcodeVc { get; set; }
        public string ActiveflagC { get; set; }
        public int? SectoridI { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstIpdhModel IpdhModelcodeVcNavigation { get; set; }
        public virtual ICollection<MstIpdhModelSpecificationLang> MstIpdhModelSpecificationLang { get; set; }
    }
}
