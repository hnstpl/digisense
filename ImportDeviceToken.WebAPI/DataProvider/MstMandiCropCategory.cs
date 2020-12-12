using System;
using System.Collections.Generic;

namespace ImportDeviceToken.WebAPI.DataProvider
{
    public partial class MstMandiCropCategory
    {
        public MstMandiCropCategory()
        {
            MstMandiCropCategoryLang = new HashSet<MstMandiCropCategoryLang>();
            MstMandiCropList = new HashSet<MstMandiCropList>();
        }

        public int CategoryId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual ICollection<MstMandiCropCategoryLang> MstMandiCropCategoryLang { get; set; }
        public virtual ICollection<MstMandiCropList> MstMandiCropList { get; set; }
    }
}
