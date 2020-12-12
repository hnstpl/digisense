using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using AdminPortal.Mvc.DataProvider;
using Microsoft.AspNetCore.Mvc.Rendering;
//using AdminPortal.Mvc.Models.Global;

namespace AdminPortal.Mvc.Models.DIY
{
    public class DIY
    {
        public SearchFilters searchFilters { get; set; }
        public IEnumerable<MstDiyVideoCategoryLang> videocategory { get; set; }
        public IEnumerable<AdminPortal.Mvc.Models.Global.Language> languages { get; set; }
        public IEnumerable<MstDiyVideo> videos { get; set; }
        public IEnumerable<VideoProperties> videoProperties { get; set; }
        //public List<Videos> videos { get; set; }
        //public AddNewDIY addNewDIY { get; set; }
    }

    public class Videos
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string URI { get; set; }
    }

    
    public class AddNewDIY
    {
        public int FilteredLanguageID { get; set; }
        public int VideoID { get; set; }
        [Required(ErrorMessage ="Video category is required")]
        public int? CategoryID { get; set; }
        public List<NewDIY> newDIY { get; set; }
        public List<NewDIY> newDIYTemplate { get; set; }
        public SelectList Videocategorylist { get; set; }
        public SelectList LanguageList { get; set; }
        public SelectList VideoTypeList { get; set; }
    }

    public class NewDIY
    {
        public int ID { get;set; }
        public int VideoId { get; set; }
        public int LanguageID { get; set; }
        public string LanguageName { get; set; }
        public string VideoName { get; set; }        
        public string VideoDescription { get; set; }
        public string VideoURI { get; set; }
        public int? VideoType { get; set; }
        public string VideoTypeDescription { get; set; }
        public string VideoStatus { get; set; }
    }

    public class VideocategoryList
    {
        public int diyID { get; set; }
        public string Category_Name { get; set; }
    }

    public class VideoProperties
    {
        public int DIY_ID { get; set; }
        public string DIY_NAME { get; set; }
        public string DIY_Description { get; set; }
        public string DIY_Category { get; set; }
    }

    public class LanguageList
    {
        public int ID { get; set; }
        public string Language_Name { get; set; }
    }

    public class VideoTypeList
    {
        public int ID { get; set; }
        public string VideoType { get; set; }
    }


    public class SearchFilters
    {
        public int SelectedCategory { get; set; }
        public int SelectedLanguage { get; set; }
        public string SelectedDateRange { get; set; }
    }

    public class RequestLanguage
    {

    }
}