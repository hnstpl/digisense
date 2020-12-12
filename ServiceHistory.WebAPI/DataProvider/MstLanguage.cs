using System;
using System.Collections.Generic;

namespace ServiceHistoryMaster.WebAPI.DataProvider
{
    public partial class MstLanguage
    {
        public MstLanguage()
        {
            MstAreaofficeLang = new HashSet<MstAreaofficeLang>();
            MstBanneractiontypeLang = new HashSet<MstBanneractiontypeLang>();
            MstBannercategoryLang = new HashSet<MstBannercategoryLang>();
            MstBannertypeLang = new HashSet<MstBannertypeLang>();
            MstCustprofile = new HashSet<MstCustprofile>();
            MstCustprofileLang = new HashSet<MstCustprofileLang>();
            MstDealerbranchhierarchyLang = new HashSet<MstDealerbranchhierarchyLang>();
            MstDistrictLang = new HashSet<MstDistrictLang>();
            MstDiyVideoCategoryLang = new HashSet<MstDiyVideoCategoryLang>();
            MstDiyVideoLang = new HashSet<MstDiyVideoLang>();
            MstEnqTypeLang = new HashSet<MstEnqTypeLang>();
            MstIpdhCategoryLang = new HashSet<MstIpdhCategoryLang>();
            MstIpdhModelBenefitsLang = new HashSet<MstIpdhModelBenefitsLang>();
            MstIpdhModelFeaturesLang = new HashSet<MstIpdhModelFeaturesLang>();
            MstIpdhModelLang = new HashSet<MstIpdhModelLang>();
            MstIpdhModelSpecificationLang = new HashSet<MstIpdhModelSpecificationLang>();
            MstIpdhModelgroupLang = new HashSet<MstIpdhModelgroupLang>();
            MstMandiCropCategoryLang = new HashSet<MstMandiCropCategoryLang>();
            MstMandiCropListLang = new HashSet<MstMandiCropListLang>();
            MstMandiCropMappingLang = new HashSet<MstMandiCropMappingLang>();
            MstMandiListLang = new HashSet<MstMandiListLang>();
            MstStateDefaultLang = new HashSet<MstState>();
            MstStateFallbackLang = new HashSet<MstState>();
            MstStateLang = new HashSet<MstStateLang>();
            MstTehsilLang = new HashSet<MstTehsilLang>();
            MstTipofthedayCategoryLang = new HashSet<MstTipofthedayCategoryLang>();
            MstTpdhBrandLang = new HashSet<MstTpdhBrandLang>();
            MstTpdhDiyMapping = new HashSet<MstTpdhDiyMapping>();
            MstTpdhHpLang = new HashSet<MstTpdhHpLang>();
            MstTpdhManufacturerLang = new HashSet<MstTpdhManufacturerLang>();
            MstTpdhModelBenefitsLang = new HashSet<MstTpdhModelBenefitsLang>();
            MstTpdhModelFeaturesLang = new HashSet<MstTpdhModelFeaturesLang>();
            MstTpdhModelLang = new HashSet<MstTpdhModelLang>();
            MstTpdhModelSpecificationLang = new HashSet<MstTpdhModelSpecificationLang>();
            MstTpdhModelgroupLang = new HashSet<MstTpdhModelgroupLang>();
            MstTpdhSpecificationCategoryLang = new HashSet<MstTpdhSpecificationCategoryLang>();
            MstTpdhSpecificationLang = new HashSet<MstTpdhSpecificationLang>();
            MstVillageLang = new HashSet<MstVillageLang>();
            PsCusttractorDtlLang = new HashSet<PsCusttractorDtlLang>();
            TblBannersLang = new HashSet<TblBannersLang>();
            TblDiyVideoModelmapping = new HashSet<TblDiyVideoModelmapping>();
            TblTipofthedayLang = new HashSet<TblTipofthedayLang>();
            TblTpdhModelSpecificationMappingLang = new HashSet<TblTpdhModelSpecificationMappingLang>();
            TblTpdhSpecificationModelmappingLang = new HashSet<TblTpdhSpecificationModelmappingLang>();
            TdealermasterLang = new HashSet<TdealermasterLang>();
        }

        public int Id { get; set; }
        public string LanguageName { get; set; }
        public string TranslateName { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public DateTime? ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
        public string LanguageCode { get; set; }

        public virtual ICollection<MstAreaofficeLang> MstAreaofficeLang { get; set; }
        public virtual ICollection<MstBanneractiontypeLang> MstBanneractiontypeLang { get; set; }
        public virtual ICollection<MstBannercategoryLang> MstBannercategoryLang { get; set; }
        public virtual ICollection<MstBannertypeLang> MstBannertypeLang { get; set; }
        public virtual ICollection<MstCustprofile> MstCustprofile { get; set; }
        public virtual ICollection<MstCustprofileLang> MstCustprofileLang { get; set; }
        public virtual ICollection<MstDealerbranchhierarchyLang> MstDealerbranchhierarchyLang { get; set; }
        public virtual ICollection<MstDistrictLang> MstDistrictLang { get; set; }
        public virtual ICollection<MstDiyVideoCategoryLang> MstDiyVideoCategoryLang { get; set; }
        public virtual ICollection<MstDiyVideoLang> MstDiyVideoLang { get; set; }
        public virtual ICollection<MstEnqTypeLang> MstEnqTypeLang { get; set; }
        public virtual ICollection<MstIpdhCategoryLang> MstIpdhCategoryLang { get; set; }
        public virtual ICollection<MstIpdhModelBenefitsLang> MstIpdhModelBenefitsLang { get; set; }
        public virtual ICollection<MstIpdhModelFeaturesLang> MstIpdhModelFeaturesLang { get; set; }
        public virtual ICollection<MstIpdhModelLang> MstIpdhModelLang { get; set; }
        public virtual ICollection<MstIpdhModelSpecificationLang> MstIpdhModelSpecificationLang { get; set; }
        public virtual ICollection<MstIpdhModelgroupLang> MstIpdhModelgroupLang { get; set; }
        public virtual ICollection<MstMandiCropCategoryLang> MstMandiCropCategoryLang { get; set; }
        public virtual ICollection<MstMandiCropListLang> MstMandiCropListLang { get; set; }
        public virtual ICollection<MstMandiCropMappingLang> MstMandiCropMappingLang { get; set; }
        public virtual ICollection<MstMandiListLang> MstMandiListLang { get; set; }
        public virtual ICollection<MstState> MstStateDefaultLang { get; set; }
        public virtual ICollection<MstState> MstStateFallbackLang { get; set; }
        public virtual ICollection<MstStateLang> MstStateLang { get; set; }
        public virtual ICollection<MstTehsilLang> MstTehsilLang { get; set; }
        public virtual ICollection<MstTipofthedayCategoryLang> MstTipofthedayCategoryLang { get; set; }
        public virtual ICollection<MstTpdhBrandLang> MstTpdhBrandLang { get; set; }
        public virtual ICollection<MstTpdhDiyMapping> MstTpdhDiyMapping { get; set; }
        public virtual ICollection<MstTpdhHpLang> MstTpdhHpLang { get; set; }
        public virtual ICollection<MstTpdhManufacturerLang> MstTpdhManufacturerLang { get; set; }
        public virtual ICollection<MstTpdhModelBenefitsLang> MstTpdhModelBenefitsLang { get; set; }
        public virtual ICollection<MstTpdhModelFeaturesLang> MstTpdhModelFeaturesLang { get; set; }
        public virtual ICollection<MstTpdhModelLang> MstTpdhModelLang { get; set; }
        public virtual ICollection<MstTpdhModelSpecificationLang> MstTpdhModelSpecificationLang { get; set; }
        public virtual ICollection<MstTpdhModelgroupLang> MstTpdhModelgroupLang { get; set; }
        public virtual ICollection<MstTpdhSpecificationCategoryLang> MstTpdhSpecificationCategoryLang { get; set; }
        public virtual ICollection<MstTpdhSpecificationLang> MstTpdhSpecificationLang { get; set; }
        public virtual ICollection<MstVillageLang> MstVillageLang { get; set; }
        public virtual ICollection<PsCusttractorDtlLang> PsCusttractorDtlLang { get; set; }
        public virtual ICollection<TblBannersLang> TblBannersLang { get; set; }
        public virtual ICollection<TblDiyVideoModelmapping> TblDiyVideoModelmapping { get; set; }
        public virtual ICollection<TblTipofthedayLang> TblTipofthedayLang { get; set; }
        public virtual ICollection<TblTpdhModelSpecificationMappingLang> TblTpdhModelSpecificationMappingLang { get; set; }
        public virtual ICollection<TblTpdhSpecificationModelmappingLang> TblTpdhSpecificationModelmappingLang { get; set; }
        public virtual ICollection<TdealermasterLang> TdealermasterLang { get; set; }
    }
}
