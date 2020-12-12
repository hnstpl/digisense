using System;
using System.Collections.Generic;

namespace ImportDeviceToken.WebAPI.DataProvider
{
    public partial class MstMandiStateMapping
    {
        public int Id { get; set; }
        public string MandiStateName { get; set; }
        public string StateCodeI { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
    }
}
