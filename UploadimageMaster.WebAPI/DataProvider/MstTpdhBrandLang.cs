using System;
using System.Collections.Generic;

namespace UploadimageMaster.WebAPI.DataProvider
{
    public partial class MstTpdhBrandLang
    {
        public int Id { get; set; }
        public string BrandcodeVc { get; set; }
        public string BrandnameVc { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstTpdhBrand BrandcodeVcNavigation { get; set; }
        public virtual MstLanguage MstLang { get; set; }
    }
}
