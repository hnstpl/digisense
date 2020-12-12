using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using AdminPortal.Mvc.TipoftheDay;
using Microsoft.AspNetCore.Mvc.Rendering;
using AdminPortal.Mvc.DataProvider;

namespace AdminPortal.Mvc.Models.TipoftheDay
{
    public class TipoftheDayModel
    {
        public LanguageModel languageModel { get; set; }
        public List<TipoftheDayData> tipoftheDayData { get; set; }
        public int tipListCount { get; set; }
        public AddNewTip NewTip { get; set; }
        public SearchFilters searchFilters { get; set; }
    }

    public class TipoftheDayData
    {
        public int tipID { get; set; }
        public string tipCategory { get; set; }
        public string tipTitle { get; set; }
        public string tipText { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd mmm yyyy}")]
        public DateTime? validfrom { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime? validthru { get; set; }
        public string status { get; set; }
    }


    public class AddNewTip
    {
        [Required]
        public int SelectedCategory { get; set; }
        public SelectList TipCategoryList { get; set; }
        public List<string> SelectedStates { get; set; }
        public SelectList StateList { get; set; }
        public List<string> SelectedDistricts { get; set; }
        public SelectList DistrictList { get; set; }

        [StringLength(50,ErrorMessage ="Tip title cannot exceed 50 char!")]
        public string TipTitle { get; set; }
        [Required]
        public string TipText { get; set; }
        public string Validity { get; set; }
        public string NewTipSubmit { get; set; }
        [Required]
        public ApplicableLanguageModel languageModel { get; set; }
    }


    public class CategorySelectList
    {
        public int TipCategory_ID { get; set; }
        public string Category_Name { get; set; }
    }

    public class StateSelectList
    {
        public string StateCode_I { get; set; }
        public string StateName_VC { get; set; }
    }

    public class DistrictSelectList
    {
        public string DistrictCode_VC { get; set; }
        public string DistrictName_VC { get; set; }
    }

    public class ApplicableLanguageModel
    {
        public List<int> selectedApplicableLanguage { get; set; }
        public SelectList LanguageList { get; set; }
    }

    public class ChangeTipStatusData
    {
        public int TipID { get; set; }
        public int TipStatus { get; set; }
        public int LanguageID { get; set; }
    }

    public class SearchFilters
    {
        public int SelectedCategory { get; set; }
        public int SelectedLanguage { get; set; }
        public string SelectedDateRange { get; set; }
    }
    public class LanguageModel
    {
        public int selectedLanguage { get; set; }
        public SelectList LanguageList { get; set; }
    }

    public class Languages
    {
        public int LanguageID { get; set; }
        public string LanguageName { get; set; }
    }
}