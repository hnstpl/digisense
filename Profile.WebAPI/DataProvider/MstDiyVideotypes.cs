using System;
using System.Collections.Generic;

namespace Profile.WebAPI.DataProvider
{
    public partial class MstDiyVideotypes
    {
        public int Id { get; set; }
        public string VideoType { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
    }
}
