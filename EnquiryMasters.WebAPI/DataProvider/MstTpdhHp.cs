using System;
using System.Collections.Generic;

namespace EnquiryMasters.WebAPI.DataProvider
{
    public partial class MstTpdhHp
    {
        public MstTpdhHp()
        {
            MstTpdhHpLang = new HashSet<MstTpdhHpLang>();
            MstTpdhModel = new HashSet<MstTpdhModel>();
        }

        public string HpcodeVc { get; set; }
        public string ActiveflagC { get; set; }
        public int? SectoridI { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual ICollection<MstTpdhHpLang> MstTpdhHpLang { get; set; }
        public virtual ICollection<MstTpdhModel> MstTpdhModel { get; set; }
    }
}
