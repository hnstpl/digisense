using System;
using System.Collections.Generic;

namespace EnquiryMasters.WebAPI.DataProvider
{
    public partial class MstBannercategory
    {
        public MstBannercategory()
        {
            MstBannercategoryLang = new HashSet<MstBannercategoryLang>();
            TblBanners = new HashSet<TblBanners>();
        }

        public int CategoryId { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
        public string ActiveflagC { get; set; }

        public virtual ICollection<MstBannercategoryLang> MstBannercategoryLang { get; set; }
        public virtual ICollection<TblBanners> TblBanners { get; set; }
    }
}
