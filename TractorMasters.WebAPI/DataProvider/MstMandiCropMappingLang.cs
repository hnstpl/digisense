using System;
using System.Collections.Generic;

namespace TractorMasters.WebAPI.DataProvider
{
    public partial class MstMandiCropMappingLang
    {
        public int Id { get; set; }
        public int MappingId { get; set; }
        public int MandiId { get; set; }
        public string CropName { get; set; }
        public string CategoryName { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstMandiList Mandi { get; set; }
        public virtual MstMandiCropMapping Mapping { get; set; }
        public virtual MstLanguage MstLang { get; set; }
    }
}
