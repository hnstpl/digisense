using System;
using System.Collections.Generic;

namespace Profile.WebAPI.DataProvider
{
    public partial class TblCutomerMandiMapping
    {
        public int Id { get; set; }
        public string CustCodeVc { get; set; }
        public int? MandiId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstCustprofile CustCodeVcNavigation { get; set; }
        public virtual MstMandiList Mandi { get; set; }
    }
}
