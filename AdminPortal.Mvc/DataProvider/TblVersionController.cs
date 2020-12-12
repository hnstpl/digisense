using System;
using System.Collections.Generic;

namespace AdminPortal.Mvc.DataProvider
{
    public partial class TblVersionController
    {
        public int Id { get; set; }
        public string ModuleName { get; set; }
        public decimal? Version { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
    }
}
