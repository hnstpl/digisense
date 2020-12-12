using System;
using System.Collections.Generic;

namespace BannersAndNotification.WebAPI.DataProvider
{
    public partial class MstEnqTypeLang
    {
        public int Id { get; set; }
        public int EnqTypeId { get; set; }
        public string EnqTypeName { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstEnqType EnqType { get; set; }
        public virtual MstLanguage MstLang { get; set; }
    }
}
