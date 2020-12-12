using System;
using System.Collections.Generic;

namespace Masters.WebAPI.DataProvider
{
    public partial class MstMandiDistrictMapping
    {
        public int Id { get; set; }
        public string MandiDistrictName { get; set; }
        public string DistrictCodeVc { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
    }
}
