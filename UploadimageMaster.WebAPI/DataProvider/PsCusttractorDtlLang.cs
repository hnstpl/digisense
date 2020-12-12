using System;
using System.Collections.Generic;

namespace UploadimageMaster.WebAPI.DataProvider
{
    public partial class PsCusttractorDtlLang
    {
        public int Id { get; set; }
        public int CustTractorDtlId { get; set; }
        public string FeedBackVc { get; set; }
        public string CustomTractorName { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual PsCusttractorDtl CustTractorDtl { get; set; }
        public virtual MstLanguage MstLang { get; set; }
    }
}
