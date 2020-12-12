using System;
using System.Collections.Generic;

namespace DIYMaster.WebAPI.DataProvider
{
    public partial class MstTpdhModelSpecificationLang
    {
        public int Id { get; set; }
        public int SpecificationId { get; set; }
        public string SpecificationName { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstLanguage MstLang { get; set; }
        public virtual MstTpdhModelSpecification Specification { get; set; }
    }
}
