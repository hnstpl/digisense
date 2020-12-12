using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Models.Tractors
{
    public class TractorsMaster
    {
        public List<Tractors> TractorData { get; set; }
        public TractorModelSearch tractorModelSearch { get; set; }
    }

    public class Tractors
    {
        public string ModelCode { get; set; }
        public string ModelName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ModelImage { get; set; }
        public int LanguageId { get; set; }
        public bool DIYVideoExists { get; set; }
        public bool BrochureExists { get; set; }
        public bool _360Exists { get; set; }
    }

    public class UpdateTractorDetails
    {
        public List<Features> features { get; set; }
        public List<Benefits> benefits { get; set; }
        public List<Specification> specifications { get; set; }
        public List<SpecificationGroup> specificationGroups { get; set; }
        public TractorConfiguration tractorConfiguration { get; set; }
        public SelectList LanguageList { get; set; }
        //public List<ModelImageURL> modelImageURLs { get; set; }
        public int selectedLanguage { get; set; }
    }

    public class Specification
    {
        public int SpecificationId { get; set; }
        public string SpecificationName { get; set; }
        public string SpecififcationValue { get; set; }
        public int SpecCategoryId { get; set; }
        public string SpecCategoryName { get; set; }
    }
    public class SpecificationGroup
    {
        public int SpecCategoryId { get; set; }
        public string SpecCategoryName { get; set; }
    }

    public class Features
    {
        public int FeatureId { get; set; }
        public string FeatureName { get; set; }
        public string FeatureValue { get; set; }
    }

    public class Benefits
    {
        public int BenefitsId { get; set; }
        public string BenefitsName { get; set; }
        public string BenefitsValue { get; set; }
    }

    public class ImpCategory
    {
        public int ImplementCategory_ID { get; set; }
        public string ImpCategoryName { get; set; }
    }
    public class DIYVideoMapping
    {
        public int MappingId { get; set; }
        public int VideoId { get; set; }
        public int LanguageId { get; set; }
        public string VideoName { get; set; }
        public string LanguageName { get; set; }
        public string ActiveFlag { get; set; }
    }
    public class TractorConfiguration
    {
        public IFormFile UserManual { get; set; }
        public IFormFile Tractor360View { get; set; }
        public IFormFile ModelImage1 { get; set; }
        public IFormFile ModelImage2 { get; set; }
        public IFormFile ModelImage3 { get; set; }
        public IFormFile ThumpImage { get; set; }
        public IFormFile VideoFile { get; set; }
        public IFormFile Brochure { get; set; }
        public bool Status { get; set; }
        public string Isactive { get; set; }
        public string Modelcode { get; set; }
        public string Model1ImagePath { get; set; }
        public string Model2ImagePath { get; set; }
        public string Model3ImagePath { get; set; }
        public string ThumpImagePath { get; set; }
        public string BrochureURLPath { get; set; }
        public string Tractor360ViewURLPath { get; set; }
        public string UserManaulURLPath { get; set; }
        public string CategoryName { get; set; }
        public string ModelName { get; set; }
        public int ModelImage1Updated { get; set; }
        public int ModelImage2Updated { get; set; }
        public int ModelImage3Updated { get; set; }
        public int ThumpImageUpdated { get; set; }
        public int BrochureUpdated { get; set; }
        public int _360Updated { get; set; }
        public int UserManaulUpdated { get; set; }
        public DIYVideo dIYVideo { get; set; }
        public string ModelImage { get; set; }
        public int LanguageId { get; set; }
        public List<ModelImages> ModelImageslist { get; set; }
        public List<ModelImages> ModelImagesTemplate { get; set; }
        public List<int> Language4UserManual { get; set; }
        public List<int> Language4Brochure { get; set; }
        public List<DIYVideoMapping> dIYVideoMappingList { get; set; }
        public List<DIYVideoMapping> dIYVideoMappingListOrg { get; set; }
        public List<DIYVideoMapping> dIYVideoMappingTemplate { get; set; }
    }

    public class TractorModelSearch
    {
        public List<string> SelectedModel { get; set; }
        public SelectList TpdhModelList { get; set; }
        public List<string> SelectedBrand { get; set; }
        public SelectList TpdhBrandList { get; set; }
        public List<string> SelectedHP { get; set; }
        public SelectList TpdhHPList { get; set; }
        public int selectedLanguage { get; set; }
        public SelectList LanguageList { get; set; }
    }

    public class Language
    {
        public int LanguageID { get; set; }
        public string LanguageName { get; set; }
    }

    public class VideoLanguages
    {
        public int VideoId { get; set; }
        public int LanguageId { get; set; }
         
    }

    public class DIYVideo
    {
        public int VideoId { get; set; }
        public string VideoName { get; set; }
        public int VideoCategory { get; set; }
        public string VideoDescription { get; set; }
        public IFormFile VideoFile { get; set; }
        public int SelectedVideoCategory { get; set; }
        public SelectList VideoCategoryList { get; set; }
        public List<int> selectedLanguage { get; set; }
        public SelectList LanguageList { get; set; }
        public int SelectVideosList { get; set; }
        public SelectList DIYVideosList { get; set; }
    }

    public class DIYVideoCategory
    {
        public int DIYCategoryId { get; set; }
        public string DIYCategoryName { get; set; }
    }
    public class DIYVideosList
    {
        public int DIY_ID { get; set; }
        public string DIY_NAME { get; set; }
    }
    public class TpdhModels
    {
        public string MODELCODE_VC { get; set; }
        public string MODELNAME_VC { get; set; }
    }

    public class TpdhBrand
    {
        public string BRANDCODE_VC { get; set; }
        public string BRANDNAME_VC { get; set; }
    }

    public class TpdhHP
    {
        public string HPCODE_VC { get; set; }
        public string HPNAME_VC { get; set; }
    }

    public enum TpdhModel
    {

        Image = 1,
        _360 = 2,
        UserManaul = 3,
        Brochure = 4,
        ThumpImage = 5

    }
    public enum TpdhModelImages
    {

        Image1 = 0,
        Image2 = 1,
        Image3 = 2

    }

    public class ModelImages
    {
        public int ID { get; set; }
        public string ImageURL { get; set; }
        public string ActiveFlag { get; set; }
    }

    public class ModelImageURL
    {
        public string ImageURL { get; set; }

    }
}
