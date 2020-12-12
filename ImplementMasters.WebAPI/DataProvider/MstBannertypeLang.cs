using System;
using System.Collections.Generic;

namespace ImplementMasters.WebAPI.DataProvider
{
    public partial class MstBannertypeLang
    {
        public int Id { get; set; }
        public int BannerTypeId { get; set; }
        public string BannerTypeName { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstBannertype BannerType { get; set; }
        public virtual MstLanguage MstLang { get; set; }
    }
}
