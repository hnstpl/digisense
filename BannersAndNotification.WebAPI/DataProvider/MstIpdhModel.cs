using System;
using System.Collections.Generic;

namespace BannersAndNotification.WebAPI.DataProvider
{
    public partial class MstIpdhModel
    {
        public MstIpdhModel()
        {
            ModelImplementSuitablityNew = new HashSet<ModelImplementSuitablityNew>();
            MstIpdhModelBenefits = new HashSet<MstIpdhModelBenefits>();
            MstIpdhModelFeatures = new HashSet<MstIpdhModelFeatures>();
            MstIpdhModelLang = new HashSet<MstIpdhModelLang>();
            MstIpdhModelSpecification = new HashSet<MstIpdhModelSpecification>();
            TblEnquiry = new HashSet<TblEnquiry>();
        }

        public string ModelcodeVc { get; set; }
        public string OldmodelcodeVc { get; set; }
        public string ManufacturercodeVc { get; set; }
        public int? ImplementCategoryId { get; set; }
        public int? MaterialTypeI { get; set; }
        public string ActiveflagC { get; set; }
        public int? SectoridI { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
        public string IgcodeVc { get; set; }
        public string SubCategoryCodeVc { get; set; }
        public string ImagePathVc { get; set; }
        public string ThumpImage { get; set; }
        public int? ImagePathVersion { get; set; }
        public int? ThumpImageVersion { get; set; }

        public virtual MstIpdhModelgroup IgcodeVcNavigation { get; set; }
        public virtual MstIpdhCategory ImplementCategory { get; set; }
        public virtual MstTpdhManufacturer ManufacturercodeVcNavigation { get; set; }
        public virtual ICollection<ModelImplementSuitablityNew> ModelImplementSuitablityNew { get; set; }
        public virtual ICollection<MstIpdhModelBenefits> MstIpdhModelBenefits { get; set; }
        public virtual ICollection<MstIpdhModelFeatures> MstIpdhModelFeatures { get; set; }
        public virtual ICollection<MstIpdhModelLang> MstIpdhModelLang { get; set; }
        public virtual ICollection<MstIpdhModelSpecification> MstIpdhModelSpecification { get; set; }
        public virtual ICollection<TblEnquiry> TblEnquiry { get; set; }
    }
}
