using System;
using System.Collections.Generic;

namespace Profile.WebAPI.DataProvider
{
    public partial class MstAreaoffice
    {
        public MstAreaoffice()
        {
            MstAreaofficeLang = new HashSet<MstAreaofficeLang>();
            Tdealermaster = new HashSet<Tdealermaster>();
        }

        public string AocodeVc { get; set; }
        public string StateCodeI { get; set; }
        public string AocityVc { get; set; }
        public string AodistrictVc { get; set; }
        public string ZonecodeVc { get; set; }
        public string TelOffVc { get; set; }
        public string FaxOffVc { get; set; }
        public string PinCodeVc { get; set; }
        public string Status { get; set; }
        public int? BusStateCodeI { get; set; }
        public string CreatedByVc { get; set; }
        public DateTime? CreatedDtD { get; set; }
        public string ModifiedByVc { get; set; }
        public DateTime? ModifiedDtD { get; set; }

        public virtual ICollection<MstAreaofficeLang> MstAreaofficeLang { get; set; }
        public virtual ICollection<Tdealermaster> Tdealermaster { get; set; }
    }
}
