using AdminPortal.Mvc.Models.Banner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Services
{
    public interface IBannerNotificationService
    {
        IEnumerable<BannerData> GetBannerList(int LanguageID);
      
        public string GetBannerModelList(int BannerId, int LanguageID);
        public string GetBannerStateList(int BannerId, int? LanguageID);
        public int GetUserCount(int BannerId, int LanguageID);
        public IEnumerable<string> GetStateList4UserCount(int BannerId, int? languageID);
        public IEnumerable<string> GetDistrictList4UserCount(int BannerId, int? languageID);
        public IEnumerable<StateSelectList> GetStatesList(int languageID);
        //public IEnumerable<BannerData> GetBannerListBySearch(BannerModel bannermodel);
        public IEnumerable<BannerData> GetBannerListBySearch(List<string> SelectedStates, string Validity, int selectedLanguage, int SelectedBannerType);
        public int BannerCount(AddNewBanner NewBanner);
        public int AddBanner(AddNewBanner NewBanner, int? languageID, string Host);
        public IEnumerable<CategorySelectList> GetCategoryList(int? languageID);
        public string SaveImage(string base64String, string filepath, string filename);

        public int GetUserList(UserCount userCount);
        public bool CheckDefaultBannerExists(UpdateBannerStatus Status, int SelectedLanguage = 1);

        public string UpdateStatus(UpdateBannerStatus Status);
        public IEnumerable<BannerActionSelectList> GetBannerActionList(int? languageID);
        public IEnumerable<ModelSelectList> GetModelList(int? languageID);
        public IEnumerable<DistrictSelectList> GetDistrictList(int? languageID);
    }
}
