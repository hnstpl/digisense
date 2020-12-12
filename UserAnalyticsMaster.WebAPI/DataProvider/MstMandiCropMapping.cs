using System;
using System.Collections.Generic;

namespace UserAnalyticsMaster.WebAPI.DataProvider
{
    public partial class MstMandiCropMapping
    {
        public MstMandiCropMapping()
        {
            MstMandiCropMappingLang = new HashSet<MstMandiCropMappingLang>();
        }

        public int Id { get; set; }
        public int MandiId { get; set; }
        public int? CropId { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public float? MinPrice { get; set; }
        public float? MaxPrice { get; set; }
        public float? ModalPrice { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstMandiList Mandi { get; set; }
        public virtual ICollection<MstMandiCropMappingLang> MstMandiCropMappingLang { get; set; }
    }
}
