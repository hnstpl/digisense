using System;
using System.Collections.Generic;

namespace DIYMaster.WebAPI.DataProvider
{
    public partial class TblTpdhModelSpecificationMapping
    {
        public TblTpdhModelSpecificationMapping()
        {
            TblTpdhModelSpecificationMappingLang = new HashSet<TblTpdhModelSpecificationMappingLang>();
        }

        public int MappingId { get; set; }
        public int? SpecificationId { get; set; }
        public string ModelcodeVc { get; set; }
        public string ActiveflagC { get; set; }
        public int? SectoridI { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstTpdhModel ModelcodeVcNavigation { get; set; }
        public virtual MstTpdhModelSpecification Specification { get; set; }
        public virtual ICollection<TblTpdhModelSpecificationMappingLang> TblTpdhModelSpecificationMappingLang { get; set; }
    }
}
