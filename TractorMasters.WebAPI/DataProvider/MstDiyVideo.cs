using System;
using System.Collections.Generic;

namespace TractorMasters.WebAPI.DataProvider
{
    public partial class MstDiyVideo
    {
        public MstDiyVideo()
        {
            MstDiyVideoLang = new HashSet<MstDiyVideoLang>();
            MstTpdhDiyMapping = new HashSet<MstTpdhDiyMapping>();
            TblDiyVideoModelmapping = new HashSet<TblDiyVideoModelmapping>();
        }

        public int DiyId { get; set; }
        public int? DiyCategory { get; set; }
        public string DiyVideoUrl { get; set; }
        public string ActiveflagC { get; set; }
        public int? SectoridI { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstDiyVideoCategory DiyCategoryNavigation { get; set; }
        public virtual ICollection<MstDiyVideoLang> MstDiyVideoLang { get; set; }
        public virtual ICollection<MstTpdhDiyMapping> MstTpdhDiyMapping { get; set; }
        public virtual ICollection<TblDiyVideoModelmapping> TblDiyVideoModelmapping { get; set; }
    }
}
