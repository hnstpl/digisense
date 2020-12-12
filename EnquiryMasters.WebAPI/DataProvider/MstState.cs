using System;
using System.Collections.Generic;

namespace EnquiryMasters.WebAPI.DataProvider
{
    public partial class MstState
    {
        public MstState()
        {
            MstDistrict = new HashSet<MstDistrict>();
            MstStateLang = new HashSet<MstStateLang>();
            TblBannersLocationMapping = new HashSet<TblBannersLocationMapping>();
            TblTipofthedayLocationMapping = new HashSet<TblTipofthedayLocationMapping>();
            Tdealermaster = new HashSet<Tdealermaster>();
        }

        public string StateCodeI { get; set; }
        public string StateCodeVc { get; set; }
        public string ZoneCodeVc { get; set; }
        public string ActiveFlagC { get; set; }
        public string IsBusinessStateC { get; set; }
        public string CreatedByVc { get; set; }
        public DateTime? CreatedDtD { get; set; }
        public string ModifiedByVc { get; set; }
        public DateTime? ModifiedDtD { get; set; }
        public string IsUnionTerritoriC { get; set; }
        public int? DefaultLangId { get; set; }
        public int? FallbackLangId { get; set; }

        public virtual MstLanguage DefaultLang { get; set; }
        public virtual MstLanguage FallbackLang { get; set; }
        public virtual ICollection<MstDistrict> MstDistrict { get; set; }
        public virtual ICollection<MstStateLang> MstStateLang { get; set; }
        public virtual ICollection<TblBannersLocationMapping> TblBannersLocationMapping { get; set; }
        public virtual ICollection<TblTipofthedayLocationMapping> TblTipofthedayLocationMapping { get; set; }
        public virtual ICollection<Tdealermaster> Tdealermaster { get; set; }
    }
}
