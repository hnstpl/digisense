using System;
using System.Collections.Generic;

namespace ImportDeviceToken.WebAPI.DataProvider
{
    public partial class MstTpdhModelDetails
    {
        public int DetailsId { get; set; }
        public string _360ImageUrl { get; set; }
        public string ManualUrl { get; set; }
        public string BrochureUrl { get; set; }
        public string ImageUrl { get; set; }
        public string ModelcodeVc { get; set; }
        public string ActiveflagC { get; set; }
        public int? SectoridI { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
        public int ImageVersion { get; set; }
        public int? FileTypeId { get; set; }
        public int? MstLangId { get; set; }

        public virtual MstTpdhFiletypes FileType { get; set; }
        public virtual MstTpdhModel ModelcodeVcNavigation { get; set; }
    }
}
