using System;
using System.Collections.Generic;

namespace Mandi.WebAPI.DataProvider
{
    public partial class TblTipofthedayLocationMapping
    {
        public int Id { get; set; }
        public int TipId { get; set; }
        public string StateCodeI { get; set; }
        public string DistrictCodeVc { get; set; }

        public virtual MstDistrict DistrictCodeVcNavigation { get; set; }
        public virtual MstState StateCodeINavigation { get; set; }
        public virtual TblTipoftheday Tip { get; set; }
    }
}
