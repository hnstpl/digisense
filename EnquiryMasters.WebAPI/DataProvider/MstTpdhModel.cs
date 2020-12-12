using System;
using System.Collections.Generic;

namespace EnquiryMasters.WebAPI.DataProvider
{
    public partial class MstTpdhModel
    {
        public MstTpdhModel()
        {
            ModelImplementSuitablityNew = new HashSet<ModelImplementSuitablityNew>();
            MstTpdhDiyMapping = new HashSet<MstTpdhDiyMapping>();
            MstTpdhModelBenefits = new HashSet<MstTpdhModelBenefits>();
            MstTpdhModelDetails = new HashSet<MstTpdhModelDetails>();
            MstTpdhModelFeatures = new HashSet<MstTpdhModelFeatures>();
            MstTpdhModelLang = new HashSet<MstTpdhModelLang>();
            TblBannersModelMapping = new HashSet<TblBannersModelMapping>();
            TblDiyVideoModelmapping = new HashSet<TblDiyVideoModelmapping>();
            TblEnquiry = new HashSet<TblEnquiry>();
            TblTpdhModelImagesMapping = new HashSet<TblTpdhModelImagesMapping>();
            TblTpdhModelSpecificationMapping = new HashSet<TblTpdhModelSpecificationMapping>();
            TblTpdhSpecificationModelmappingLang = new HashSet<TblTpdhSpecificationModelmappingLang>();
        }

        public string ModelcodeVc { get; set; }
        public string OldmodelcodeVc { get; set; }
        public string ModelgroupcodeVc { get; set; }
        public string HpcodeVc { get; set; }
        public int? MaterialTypeI { get; set; }
        public string ActiveflagC { get; set; }
        public int? SectoridI { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
        public string BrandcodeVc { get; set; }

        public virtual MstTpdhBrand BrandcodeVcNavigation { get; set; }
        public virtual MstTpdhHp HpcodeVcNavigation { get; set; }
        public virtual MstTpdhModelgroup ModelgroupcodeVcNavigation { get; set; }
        public virtual ICollection<ModelImplementSuitablityNew> ModelImplementSuitablityNew { get; set; }
        public virtual ICollection<MstTpdhDiyMapping> MstTpdhDiyMapping { get; set; }
        public virtual ICollection<MstTpdhModelBenefits> MstTpdhModelBenefits { get; set; }
        public virtual ICollection<MstTpdhModelDetails> MstTpdhModelDetails { get; set; }
        public virtual ICollection<MstTpdhModelFeatures> MstTpdhModelFeatures { get; set; }
        public virtual ICollection<MstTpdhModelLang> MstTpdhModelLang { get; set; }
        public virtual ICollection<TblBannersModelMapping> TblBannersModelMapping { get; set; }
        public virtual ICollection<TblDiyVideoModelmapping> TblDiyVideoModelmapping { get; set; }
        public virtual ICollection<TblEnquiry> TblEnquiry { get; set; }
        public virtual ICollection<TblTpdhModelImagesMapping> TblTpdhModelImagesMapping { get; set; }
        public virtual ICollection<TblTpdhModelSpecificationMapping> TblTpdhModelSpecificationMapping { get; set; }
        public virtual ICollection<TblTpdhSpecificationModelmappingLang> TblTpdhSpecificationModelmappingLang { get; set; }
    }
}
