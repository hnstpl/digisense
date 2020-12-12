using System;
using System.Collections.Generic;

namespace AdminPortal.Mvc.DataProvider
{
    public partial class TblTpdhModelSpecificationMapping
    {
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
        public virtual TblTpdhModelSpecificationMappingLang TblTpdhModelSpecificationMappingLang { get; set; }
    }
}
