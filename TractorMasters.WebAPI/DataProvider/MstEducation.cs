using System;
using System.Collections.Generic;

namespace TractorMasters.WebAPI.DataProvider
{
    public partial class MstEducation
    {
        public MstEducation()
        {
            MstCustprofile = new HashSet<MstCustprofile>();
        }

        public int Id { get; set; }
        public string Education { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual ICollection<MstCustprofile> MstCustprofile { get; set; }
    }
}
