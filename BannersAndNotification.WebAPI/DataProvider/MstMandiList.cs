using System;
using System.Collections.Generic;

namespace BannersAndNotification.WebAPI.DataProvider
{
    public partial class MstMandiList
    {
        public MstMandiList()
        {
            MstMandiCropMapping = new HashSet<MstMandiCropMapping>();
            MstMandiCropMappingLang = new HashSet<MstMandiCropMappingLang>();
            MstMandiListLang = new HashSet<MstMandiListLang>();
            TblCutomerMandiMapping = new HashSet<TblCutomerMandiMapping>();
        }

        public int MandiId { get; set; }
        public string StateCodeI { get; set; }
        public string DistrictCodeVc { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual ICollection<MstMandiCropMapping> MstMandiCropMapping { get; set; }
        public virtual ICollection<MstMandiCropMappingLang> MstMandiCropMappingLang { get; set; }
        public virtual ICollection<MstMandiListLang> MstMandiListLang { get; set; }
        public virtual ICollection<TblCutomerMandiMapping> TblCutomerMandiMapping { get; set; }
    }
}
