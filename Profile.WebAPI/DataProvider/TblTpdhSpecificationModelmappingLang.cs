using System;
using System.Collections.Generic;

namespace Profile.WebAPI.DataProvider
{
    public partial class TblTpdhSpecificationModelmappingLang
    {
        public int Id { get; set; }
        public string ModelcodeVc { get; set; }
        public int SpecificationId { get; set; }
        public string SpecificationValue { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstTpdhModel ModelcodeVcNavigation { get; set; }
        public virtual MstLanguage MstLang { get; set; }
        public virtual MstTpdhSpecification Specification { get; set; }
    }
}
