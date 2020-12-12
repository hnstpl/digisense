using System;
using System.Collections.Generic;

namespace ImportDeviceToken.WebAPI.DataProvider
{
    public partial class MstBanneractiontype
    {
        public MstBanneractiontype()
        {
            MstBanneractionsubtype = new HashSet<MstBanneractionsubtype>();
            MstBanneractiontypeLang = new HashSet<MstBanneractiontypeLang>();
            TblBanners = new HashSet<TblBanners>();
        }

        public int ActionTypeId { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
        public string ActiveflagC { get; set; }

        public virtual ICollection<MstBanneractionsubtype> MstBanneractionsubtype { get; set; }
        public virtual ICollection<MstBanneractiontypeLang> MstBanneractiontypeLang { get; set; }
        public virtual ICollection<TblBanners> TblBanners { get; set; }
    }
}
