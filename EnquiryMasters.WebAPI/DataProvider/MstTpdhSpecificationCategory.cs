using System;
using System.Collections.Generic;

namespace EnquiryMasters.WebAPI.DataProvider
{
    public partial class MstTpdhSpecificationCategory
    {
        public MstTpdhSpecificationCategory()
        {
            MstTpdhModelSpecification = new HashSet<MstTpdhModelSpecification>();
            MstTpdhSpecificationCategoryLang = new HashSet<MstTpdhSpecificationCategoryLang>();
        }

        public int SpecCategoryId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual ICollection<MstTpdhModelSpecification> MstTpdhModelSpecification { get; set; }
        public virtual ICollection<MstTpdhSpecificationCategoryLang> MstTpdhSpecificationCategoryLang { get; set; }
    }
}
