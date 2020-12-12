using System;
using System.Collections.Generic;

namespace UnifiedLogin.WebAPI.DataProvider
{
    public partial class MstTpdhSpecificationLang
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
        public virtual MstTpdhSpecification Specification { get; set; }
    }
}
