using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Models.Banner
{

    public class BannerModel
    {
        public BannerSearchModel SearchModel { get; set; }
        public List<BannerData> bannerData { get; set; }
        //public AddNewBanner NewBanner { get; set; }
        public BannerSearch bannerSearch { get; set; }
        public int BannerListCount { get; set; }
    }



    public class UpdateBannerStatus
    {
        public int BannerId { get; set; }
        public string IsActive { get; set; }
        public int LanguageId { get; set; }
    }

    public class BannerData
    {
        public int BannerId { get; set; }
        public string Title { get; set; }
        public string NotificationText { get; set; }
        public int BannerOrNotification { get; set; }
        public string BannerImage { get; set; }
        public string Category { get; set; }
        public string ActionType { get; set; }
        public string BannerType { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public string Status { get; set; }
        public string StateList { get; set; }
        public string ModelList { get; set; }
        public int UserCount { get; set; }
        public string fromdate { get; set; }
        public string todate { get; set; }
        public string ActionLink { get; set; }
        public string Actiontext { get; set; }
        public int ActionTypeId { get; set; }
    }

    public class AddNewBanner
    {
        public int SelectedCategory { get; set; }
        public SelectList BannerCategoryList { get; set; }
        public int BannerType { get; set; }
        public string Notificationtext { get; set; }
        public List<string> SelectedStates { get; set; }
        public SelectList StateList { get; set; }
        public List<string> SelectedDistricts { get; set; }
        public SelectList DistrictList { get; set; }
        public string Subject { get; set; }
        public string Validity { get; set; }
        public IFormFile BannerImage { get; set; }
        public int SelectedBannerAction { get; set; }
        public SelectList BannerActionList { get; set; }
        //public HttpPostedFileBase ActionImage { get; set; }
        public string ActionTypeTarget { get; set; }
        public List<string> SelectedModel { get; set; }
        public SelectList ModelList { get; set; }
        public ApplicableLanguageModel languageModel { get; set; }
        public string ActionLink { get; set; }

        public string BannerImageURL { get; set; }
        public string ActionImageURL { get; set; }
        public IFormFile ActionFile { get; set; }
    }

    public class BannerSearch
    {
        public List<string> SelectedStates { get; set; }
        public SelectList StateList { get; set; }
        public int SelectedBannerType { get; set; }
        public SelectList BannerType { get; set; }
        public string Validity { get; set; }
    }

    public class UserCount
    {
        public List<int> selectedApplicableLanguage { get; set; }
        public List<string> SelectedStates { get; set; }
        public List<string> SelectedDistricts { get; set; }
        public int UserCnt { get; set; }
    }
    public enum ActionType
    {

        HTML = 1,
        Image = 2,
        File = 3,
        Text = 4,
        Link = 5

    }

    public enum SubActionType
    {

        PDF = 1,
        Video = 2,

    }
    //public class Language
    //{
    //    public int Languageid { get; set; }
    //    public string Languagename { get; set; }
    //}


    public class BannerSearchModel
    {
        public int selectedLanguage { get; set; }
        public SelectList LanguageList { get; set; }
        public int SelectedBannerType { get; set; }
        public SelectList BannerType { get; set; }
        public List<string> SelectedStates { get; set; }
        public SelectList StateList { get; set; }
        public string Validity { get; set; }
        //public List<SelectListItem> StateList1 { get; set; }
    }

    public class Language
    {
        public int LanguageID { get; set; }
        public string LanguageName { get; set; }
    }
    public class CategorySelectList
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }

    public class StateSelectList
    {
        public string StateCode_I { get; set; }
        public string StateName_VC { get; set; }
    }
    public class ModelSelectList
    {
        public string MODELCODE_VC { get; set; }
        public string MODELNAME_VC { get; set; }
    }

    public class DistrictSelectList
    {
        public string DistrictCode_VC { get; set; }
        public string DistrictName_VC { get; set; }
    }

    public class BannerActionSelectList
    {
        public int ActionTypeID { get; set; }
        public string ActionTypeName { get; set; }
    }

    //public class LanguageModel
    //{
    //    public int selectedLanguage { get; set; }
    //    public SelectList LanguageList { get; set; }
    //}

    //public class Languages
    //{
    //    public int LanguageID { get; set; }
    //    public string LanguageName { get; set; }
    //}

    public class ApplicableLanguageModel
    {
        public List<int> selectedApplicableLanguage { get; set; }
        public SelectList LanguageList { get; set; }

    }
}
