using System;
using System.Collections.Generic;

namespace AdminPortal.Mvc.DataProvider
{
    public partial class MstIpdhModelSpecificationLang
    {
        public int Id { get; set; }
        public int SpecificationId { get; set; }
        public string SpecificationType { get; set; }
        public string SpecificationName { get; set; }
        public string SpecificationValue { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstLanguage MstLang { get; set; }
        public virtual MstIpdhModelSpecification Specification { get; set; }
    }
}
