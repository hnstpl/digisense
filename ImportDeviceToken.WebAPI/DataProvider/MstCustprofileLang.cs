using System;
using System.Collections.Generic;

namespace ImportDeviceToken.WebAPI.DataProvider
{
    public partial class MstCustprofileLang
    {
        public int Id { get; set; }
        public string CustCodeVc { get; set; }
        public string CustNameVc { get; set; }
        public string CustCoPrefixVc { get; set; }
        public string CustCoNameVc { get; set; }
        public string Add1Vc { get; set; }
        public string Add2Vc { get; set; }
        public string Add3Vc { get; set; }
        public string SalesmanNameVc { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstCustprofile CustCodeVcNavigation { get; set; }
        public virtual MstLanguage MstLang { get; set; }
    }
}
