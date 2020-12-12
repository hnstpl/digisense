using System;
using System.Collections.Generic;

namespace ImplementMasters.WebAPI.DataProvider
{
    public partial class TdealermasterLang
    {
        public int Id { get; set; }
        public string DealerCode { get; set; }
        public string DealerTitle { get; set; }
        public string DealerName { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Addr3 { get; set; }
        public string Addr4 { get; set; }
        public string DealerLoc { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string ContactPerson { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual Tdealermaster DealerCodeNavigation { get; set; }
        public virtual MstLanguage MstLang { get; set; }
    }
}
