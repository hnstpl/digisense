using System;
using System.Collections.Generic;

namespace GeoMasters.WebAPI.DataProvider
{
    public partial class MstVillage
    {
        public MstVillage()
        {
            MstCustprofileOfficeVillageCodeVcNavigation = new HashSet<MstCustprofile>();
            MstCustprofileVillageCodeVcNavigation = new HashSet<MstCustprofile>();
            MstVillageLang = new HashSet<MstVillageLang>();
        }

        public string VillageCodeVc { get; set; }
        public string OldVillageCodeVc { get; set; }
        public string TehsilCodeVc { get; set; }
        public string PostCodeVc { get; set; }
        public string BlockCodeVc { get; set; }
        public int? Classification1I { get; set; }
        public int? Classification2I { get; set; }
        public int? Rclassification1I { get; set; }
        public int? Rclassification2I { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
        public string SyncStatusC { get; set; }
        public string SyncRemarkVc { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }

        public virtual MstTehsil TehsilCodeVcNavigation { get; set; }
        public virtual ICollection<MstCustprofile> MstCustprofileOfficeVillageCodeVcNavigation { get; set; }
        public virtual ICollection<MstCustprofile> MstCustprofileVillageCodeVcNavigation { get; set; }
        public virtual ICollection<MstVillageLang> MstVillageLang { get; set; }
    }
}
