using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AdminPortal.Mvc.Models.Mandi
{
    public class MandiModel
    {
        public LanguageModel languageModel { get; set; }
        public int MandiListCount { get; set; }
        public SearchFilters searchFilters { get; set; }
        public MandiMapping Mapping { get; set; }
        public List<Mandi> MandiData { get; set; }
        public List<string> SelectedStates { get; set; }
        public SelectList StateList { get; set; }
        public List<string> SelectedDistricts { get; set; }
        public SelectList DistrictList { get; set; }
    }

    public class Mandi
    {
        public int Mandi_ID { get; set; }
        public string StateCode_I { get; set; }
        public string DistrictCode_VC { get; set; }
        public string ACTIVEFLAG_C { get; set; }
        public string CREATEDBY_VC { get; set; }
        public Nullable<System.DateTime> CREATEDDT_D { get; set; }
        public string MODIFIEDBY_VC { get; set; }
        public Nullable<System.DateTime> MODIFIEDDT_D { get; set; }
        public string Mandi_Name { get; set; }
        public string StateName_VC { get; set; }
        public string DistrictName_VC { get; set; }
        public int MST_LANG_ID { get; set; }
    }

    public class MandiMapping
    {
        public List<string> SelectedStates { get; set; }
        public SelectList StateList { get; set; }
        public List<string> SelectedDistricts { get; set; }
        public SelectList DistrictList { get; set; }

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

    public class SearchFilters
    {
        public int SelectedLanguage { get; set; }
        public string SelectedDateRange { get; set; }
        public List<string> SelectedStates { get; set; }
        public SelectList StateList { get; set; }
        public List<string> SelectedDistricts { get; set; }
        public SelectList DistrictList { get; set; }

    }
    public class Language
    {
        public int Languageid { get; set; }
        public string Languagename { get; set; }
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