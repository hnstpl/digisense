using System;
using System.Collections.Generic;

namespace GeoMasters.WebAPI.DataProvider
{
    public partial class MstIpdhCategory
    {
        public MstIpdhCategory()
        {
            MstIpdhCategoryLang = new HashSet<MstIpdhCategoryLang>();
            MstIpdhModel = new HashSet<MstIpdhModel>();
        }

        public int ImplementCategoryId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual ICollection<MstIpdhCategoryLang> MstIpdhCategoryLang { get; set; }
        public virtual ICollection<MstIpdhModel> MstIpdhModel { get; set; }
    }
}
