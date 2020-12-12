using System;
using System.Collections.Generic;

namespace Masters.WebAPI.DataProvider
{
    public partial class TblBannersLang
    {
        public int Id { get; set; }
        public int BannerId { get; set; }
        public string BannerTitle { get; set; }
        public string NotificationText { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual TblBanners Banner { get; set; }
        public virtual MstLanguage MstLang { get; set; }
    }
}
