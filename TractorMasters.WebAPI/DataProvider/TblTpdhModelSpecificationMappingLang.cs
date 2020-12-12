using System;
using System.Collections.Generic;

namespace TractorMasters.WebAPI.DataProvider
{
    public partial class TblTpdhModelSpecificationMappingLang
    {
        public int Id { get; set; }
        public int MappingId { get; set; }
        public string SpecificationValue { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual TblTpdhModelSpecificationMapping Mapping { get; set; }
        public virtual MstLanguage MstLang { get; set; }
    }
}
