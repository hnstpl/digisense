using System;
using System.Collections.Generic;

namespace GeoMasters.WebAPI.DataProvider
{
    public partial class MstDiyVideoCategory
    {
        public MstDiyVideoCategory()
        {
            MstDiyVideo = new HashSet<MstDiyVideo>();
            MstDiyVideoCategoryLang = new HashSet<MstDiyVideoCategoryLang>();
        }

        public int Id { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual ICollection<MstDiyVideo> MstDiyVideo { get; set; }
        public virtual ICollection<MstDiyVideoCategoryLang> MstDiyVideoCategoryLang { get; set; }
    }
}
