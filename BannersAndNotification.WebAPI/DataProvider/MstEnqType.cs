using System;
using System.Collections.Generic;

namespace BannersAndNotification.WebAPI.DataProvider
{
    public partial class MstEnqType
    {
        public MstEnqType()
        {
            MstEnqTypeLang = new HashSet<MstEnqTypeLang>();
            TblEnquiry = new HashSet<TblEnquiry>();
        }

        public int EnqTypeId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual ICollection<MstEnqTypeLang> MstEnqTypeLang { get; set; }
        public virtual ICollection<TblEnquiry> TblEnquiry { get; set; }
    }
}
