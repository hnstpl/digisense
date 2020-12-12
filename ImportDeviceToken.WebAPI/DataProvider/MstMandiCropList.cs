using System;
using System.Collections.Generic;

namespace ImportDeviceToken.WebAPI.DataProvider
{
    public partial class MstMandiCropList
    {
        public MstMandiCropList()
        {
            MstMandiCropListLang = new HashSet<MstMandiCropListLang>();
            TblCutomerCropMapping = new HashSet<TblCutomerCropMapping>();
        }

        public int CropId { get; set; }
        public string CropCode { get; set; }
        public int? CategoryId { get; set; }
        public string ImageUrl { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
        public int? ImageUrlVr { get; set; }

        public virtual MstMandiCropCategory Category { get; set; }
        public virtual ICollection<MstMandiCropListLang> MstMandiCropListLang { get; set; }
        public virtual ICollection<TblCutomerCropMapping> TblCutomerCropMapping { get; set; }
    }
}
