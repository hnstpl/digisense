using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdminPortal.Mvc.Models.Crop
{
    public class Crop
    {
        public LanguageModel languageModel { get; set; }
        public CropMapping Mapping { get; set; }
        public SearchFilters searchFilters { get; set; }
        public List<CropData> CropData { get; set; }
    }
    public class CropData
    {
        public int CropID { get; set; }
        public string CropCode { get; set; }
        public string CropName { get; set; }
        public int MandiID { get; set; }
        public string MandiName { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string CategoryName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime? ArrivalDate { get; set; }
        public float? MinPrice { get; set; }
        public float? MaxPrice { get; set; }
        public float? ModalPrice { get; set; }
        public string ImageURL { get; set; }
        public string ACTIVEFLAG_C { get; set; }
        public string CREATEDBY_VC { get; set; }
        public Nullable<System.DateTime> CREATEDDT_D { get; set; }
        public string MODIFIEDBY_VC { get; set; }
        public Nullable<System.DateTime> MODIFIEDDT_D { get; set; }
        public Nullable<int> ImageURL_vr { get; set; }
    }
    public class MandiList
    {
        public int Mandi_ID { get; set; }
        public string Mandi_Name { get; set; }
    }

    public class CropMapping
    {
        public List<string> SelectedMandi { get; set; }
        public SelectList MandiList { get; set; }
    }

    public class SearchFilters
    {
        public int SelectedLanguage { get; set; }
        public List<string> SelectedMandi { get; set; }
        public SelectList MandiList { get; set; }
      
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