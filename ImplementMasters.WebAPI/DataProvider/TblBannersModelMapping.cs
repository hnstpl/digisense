using System;
using System.Collections.Generic;

namespace ImplementMasters.WebAPI.DataProvider
{
    public partial class TblBannersModelMapping
    {
        public int Id { get; set; }
        public int BannerId { get; set; }
        public string ModelcodeVc { get; set; }

        public virtual TblBanners Banner { get; set; }
        public virtual MstTpdhModel ModelcodeVcNavigation { get; set; }
    }
}
