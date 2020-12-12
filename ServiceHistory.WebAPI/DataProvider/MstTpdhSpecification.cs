using System;
using System.Collections.Generic;

namespace ServiceHistoryMaster.WebAPI.DataProvider
{
    public partial class MstTpdhSpecification
    {
        public MstTpdhSpecification()
        {
            MstTpdhSpecificationLang = new HashSet<MstTpdhSpecificationLang>();
            TblTpdhSpecificationModelmappingLang = new HashSet<TblTpdhSpecificationModelmappingLang>();
        }

        public int SpecificationId { get; set; }
        public int? SpecCategoryId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual ICollection<MstTpdhSpecificationLang> MstTpdhSpecificationLang { get; set; }
        public virtual ICollection<TblTpdhSpecificationModelmappingLang> TblTpdhSpecificationModelmappingLang { get; set; }
    }
}
