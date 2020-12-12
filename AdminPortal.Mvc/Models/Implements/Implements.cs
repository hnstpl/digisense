using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Models.Implements
{
    public class ImplementMaster
    {
        public List<Implements> ImplementData { get; set; }
        public ImplementModelSearch implementModelSearch { get; set; }
    }

    public class Implements
    {
        public string ModelCode { get; set; }
        public string ModelName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ModelImage { get; set; }
        public int LanguageId { get; set; }
        public string DefaultModelImage { get; set; }
    }

    public class UpdateImplementsDetails
    {
        public List<Features> features { get; set; }
        public List<Benefits> benefits { get; set; }
        public List<Specification> specifications { get; set; }
        public ImplementConfiguration implementConfiguration { get; set; }
        public SelectList LanguageList { get; set; }
        public int selectedLanguage { get; set; }
    }

    public class Specification
    {
        public int SpecificationId { get; set; }
        public string SpecificationName { get; set; }
        public string SpecififcationValue { get; set; }
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
        public string IGCode_VC { get; set; }
        public string IGName_VC { get; set; }
    }

    public class ImplementConfiguration
    {
        public string SelectedIGCode_VC { get; set; }
        public SelectList ModelCategoryList { get; set; }
        public IFormFile ModelImage { get; set; }
        public IFormFile ThumpImage { get; set; }
        public bool Status { get; set; }
        public string Isactive { get; set; }
        public string Modelcode { get; set; }
        public string ModelImagePath { get; set; }
        public string ThumpImagePath { get; set; }
        public string CategoryName { get; set; }
        public string ModelName { get; set; }
        public int ModelImageUpdated { get; set; }
        public int ThumpImageUpdated { get; set; }
        public string DefaultModelImage { get; set; }
        public string ImageURL { get; set; }
        public string ThumpImageURL { get; set; }
    }

    public class ImplementModelSearch
    {
        public List<string> SelectedCategory { get; set; }
        public SelectList ModelCategoryList { get; set; }
        public int selectedLanguage { get; set; }
        public SelectList LanguageList { get; set; }
    }

    public class Language
    {
        public int LanguageID { get; set; }
        public string LanguageName { get; set; }
    }
}
