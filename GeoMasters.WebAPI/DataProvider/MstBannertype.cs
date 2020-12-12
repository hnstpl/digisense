using System;
using System.Collections.Generic;

namespace GeoMasters.WebAPI.DataProvider
{
    public partial class MstBannertype
    {
        public MstBannertype()
        {
            MstBannertypeLang = new HashSet<MstBannertypeLang>();
            TblBanners = new HashSet<TblBanners>();
        }

        public int BannerTypeId { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
        public string ActiveflagC { get; set; }

        public virtual ICollection<MstBannertypeLang> MstBannertypeLang { get; set; }
        public virtual ICollection<TblBanners> TblBanners { get; set; }
    }
}
