using System;
using System.Collections.Generic;

namespace ImplementMasters.WebAPI.DataProvider
{
    public partial class TblTpdhModelImagesMapping
    {
        public int Id { get; set; }
        public string ModelcodeVc { get; set; }
        public string ImagePath { get; set; }
        public string ActiveflagC { get; set; }
        public int? ImageVersion { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstTpdhModel ModelcodeVcNavigation { get; set; }
    }
}
