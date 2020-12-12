using System;
using System.Collections.Generic;

namespace ImplementMasters.WebAPI.DataProvider
{
    public partial class MstTpdhModelSpecification
    {
        public MstTpdhModelSpecification()
        {
            MstTpdhModelSpecificationLang = new HashSet<MstTpdhModelSpecificationLang>();
            TblTpdhModelSpecificationMapping = new HashSet<TblTpdhModelSpecificationMapping>();
        }

        public int SpecificationId { get; set; }
        public int? SpecificationCategory { get; set; }
        public string ImageUrl { get; set; }
        public string ActiveflagC { get; set; }
        public int? SectoridI { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstTpdhSpecificationCategory SpecificationCategoryNavigation { get; set; }
        public virtual ICollection<MstTpdhModelSpecificationLang> MstTpdhModelSpecificationLang { get; set; }
        public virtual ICollection<TblTpdhModelSpecificationMapping> TblTpdhModelSpecificationMapping { get; set; }
    }
}
