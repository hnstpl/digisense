using System;
using System.Collections.Generic;

namespace ServiceHistoryMaster.WebAPI.DataProvider
{
    public partial class ModelImplementSuitablityNew
    {
        public int SuitableId { get; set; }
        public string TpdhModelcodeVc { get; set; }
        public string IpdhModelcodeVc { get; set; }
        public string ActiveflagC { get; set; }
        public int? SectoridI { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstIpdhModel IpdhModelcodeVcNavigation { get; set; }
        public virtual MstTpdhModel TpdhModelcodeVcNavigation { get; set; }
    }
}
