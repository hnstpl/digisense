using System;
using System.Collections.Generic;

namespace Mandi.WebAPI.DataProvider
{
    public partial class MstMandiCropListMapping
    {
        public int Id { get; set; }
        public string MandiCropName { get; set; }
        public int? CropId { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
    }
}
