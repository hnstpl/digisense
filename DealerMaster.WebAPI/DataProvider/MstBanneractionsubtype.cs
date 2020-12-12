using System;
using System.Collections.Generic;

namespace DealerMaster.WebAPI.DataProvider
{
    public partial class MstBanneractionsubtype
    {
        public int Id { get; set; }
        public int ActionTypeId { get; set; }
        public string ActionSubTypeName { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstBanneractiontype ActionType { get; set; }
    }
}
