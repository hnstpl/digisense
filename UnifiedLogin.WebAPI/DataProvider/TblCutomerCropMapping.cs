using System;
using System.Collections.Generic;

namespace UnifiedLogin.WebAPI.DataProvider
{
    public partial class TblCutomerCropMapping
    {
        public int Id { get; set; }
        public string CustCodeVc { get; set; }
        public int? CropId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstMandiCropList Crop { get; set; }
        public virtual MstCustprofile CustCodeVcNavigation { get; set; }
    }
}
