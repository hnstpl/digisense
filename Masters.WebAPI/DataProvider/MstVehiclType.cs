using System;
using System.Collections.Generic;

namespace Masters.WebAPI.DataProvider
{
    public partial class MstVehiclType
    {
        public MstVehiclType()
        {
            PsCusttractorDtl = new HashSet<PsCusttractorDtl>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual ICollection<PsCusttractorDtl> PsCusttractorDtl { get; set; }
    }
}
