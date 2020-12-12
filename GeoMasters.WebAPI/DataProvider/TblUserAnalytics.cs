using System;
using System.Collections.Generic;

namespace GeoMasters.WebAPI.DataProvider
{
    public partial class TblUserAnalytics
    {
        public int Id { get; set; }
        public string CustomerCodeVc { get; set; }
        public int? ModuleId { get; set; }
        public int? SubModuleId { get; set; }
        public string ModelCode { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Duration { get; set; }
        public string DeviceId { get; set; }
        public string Osversion { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
    }
}
