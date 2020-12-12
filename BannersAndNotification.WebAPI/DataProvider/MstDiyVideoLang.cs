using System;
using System.Collections.Generic;

namespace BannersAndNotification.WebAPI.DataProvider
{
    public partial class MstDiyVideoLang
    {
        public int Id { get; set; }
        public int DiyId { get; set; }
        public string DiyName { get; set; }
        public string DiyDescription { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
        public string VideoPath { get; set; }
        public int? VideoTypeId { get; set; }

        public virtual MstDiyVideo Diy { get; set; }
        public virtual MstLanguage MstLang { get; set; }
    }
}
