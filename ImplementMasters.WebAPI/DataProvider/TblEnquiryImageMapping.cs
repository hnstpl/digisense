using System;
using System.Collections.Generic;

namespace ImplementMasters.WebAPI.DataProvider
{
    public partial class TblEnquiryImageMapping
    {
        public int Id { get; set; }
        public int? EnqId { get; set; }
        public string ImagePath { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual TblEnquiry Enq { get; set; }
    }
}
