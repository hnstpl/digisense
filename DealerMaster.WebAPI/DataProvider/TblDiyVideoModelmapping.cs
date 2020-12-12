using System;
using System.Collections.Generic;

namespace DealerMaster.WebAPI.DataProvider
{
    public partial class TblDiyVideoModelmapping
    {
        public int MappingId { get; set; }
        public string ModelcodeVc { get; set; }
        public int? DiyId { get; set; }
        public string ActiveflagC { get; set; }
        public int? SectoridI { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
        public int? MstLangId { get; set; }

        public virtual MstDiyVideo Diy { get; set; }
        public virtual MstTpdhModel ModelcodeVcNavigation { get; set; }
        public virtual MstLanguage MstLang { get; set; }
    }
}
