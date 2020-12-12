//using DigisenseAPI.Areas.HelpPage.ModelDescriptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Mandi.WebAPI.Models.MandiModel
{
    public class MastersModel
    {
        public List<MandiList> masters { get; set; }
    }

    public class MandiList
    {
        public decimal contentversion { get; set; }
        public string languagecode { get; set; }
        public List<MandiModel> mandilist { get; set; }
        public int totalrecords { get; set; }
    }

    public class MandiModel
    {
        public int mandid { get; set; }
        public string mandiname { get; set; }
        public string statecode { get; set; }
        public string statename { get; set; }
        public string districtcode { get; set; }
        public string districtname { get; set; }
        public double createdate { get; set; }
        public double modifieddate { get; set; }
        public List<Crop> crops { get; set; }
    }

    public class Crop
    {
        public int cropid { get; set; }
        public string cropcode { get; set; }
        public string cropname { get; set; }
        public int? categoryid { get; set; }
        public string categoryname { get; set; }
        public double arrivaldate { get; set; }
        public double? minprice { get; set; }
        public double? maxprice { get; set; }
        public double? modalprice { get; set; }
        public string imageurl { get; set; }
        public double lastupdateddate { get; set; }
    }


  

    //[ModelName("LanguageCodeForMandi")]
    public class LanguageCode
    {
        /// <summary>
        /// languagecode is optional
        /// </summary>
        [DefaultValue(null)]
        public string languagecode { get; set; }
    }
    //public class MandiType
    //{
    //    [DefaultValue(null)]
    //    public int manditype { get; set; }
    //}


    public class MandiSelectList
    {
        public int MandiId { get; set; }
    }

    public class CropSelectionList
    {
        public int CropId { get; set; }
    }

    [Flags]
    [DefaultValue(null)]
    public enum MandiTypes
    {
        All = 0,
        Specific = 1        
    }
}