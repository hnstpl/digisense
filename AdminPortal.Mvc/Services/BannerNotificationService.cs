using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.Banner;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Services
{
    public class BannerNotificationService:IBannerNotificationService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        private readonly IGlobalService _global;

        //private static string VirtualPath4Banner = ConfigurationManager.AppSettings["VirtualPath4Banner"];
        //private static string VirtualPath4BannerAction = ConfigurationManager.AppSettings["VirtualPath4BannerAction"];

        //private static string ActualPath4Banner = ConfigurationManager.AppSettings["ActualPath4Banner"];
        //private static string ActualPath4BannerAction = ConfigurationManager.AppSettings["ActualPath4BannerAction"];

        private string VirtualPath4Banner = "";
        private string VirtualPath4BannerAction = "";

        private string ActualPath4Banner = "";
        private string ActualPath4BannerAction = "";

        public IConfiguration _configuration { get; }
        public BannerNotificationService(dev_encrypted_generalcustomerappContext Context, IConfiguration configuration, IGlobalService Global)
        {
            _context = Context;
            _global = Global;
            _configuration = configuration;
            VirtualPath4Banner = _configuration.GetValue<string>("Banners:VirtualPath4Banner");
            VirtualPath4BannerAction = _configuration.GetValue<string>("Banners:VirtualPath4BannerAction");
            ActualPath4Banner = _configuration.GetValue<string>("Banners:ActualPath4Banner");
            ActualPath4BannerAction = _configuration.GetValue<string>("Banners:ActualPath4BannerAction");


        }

        public IEnumerable<BannerData> GetBannerList(int LanguageID)
        {
            List<BannerData> Bannerlist = new List<BannerData>();

            
            var bannerData = (from p in _context.TblBannersLang
                              join o in _context.TblBanners on p.BannerId equals o.BannerId
                              join i in _context.MstBannercategory on o.Category equals i.CategoryId
                              join u in _context.MstBannercategoryLang on i.CategoryId equals u.CategoryId
                              join a in _context.MstBanneractiontype on o.ActionType equals a.ActionTypeId
                              join al in _context.MstBanneractiontypeLang on a.ActionTypeId equals al.ActionTypeId
                              join b in _context.MstBannertype on o.BannerOrNotification equals b.BannerTypeId
                              join bl in _context.MstBannertypeLang on b.BannerTypeId equals bl.BannerTypeId
                              where

                              p.MstLangId == LanguageID
                              && u.MstLangId == LanguageID
                              && al.MstLangId == LanguageID
                              && bl.MstLangId == LanguageID

                              select new BannerData
                              {
                                  BannerId = o.BannerId,
                                  ActionType = al.ActionTypeName,
                                  ActionTypeId = al.ActionTypeId,
                                  Actiontext = o.ActionTypeTarget,
                                  BannerImage = o.BannerImage,
                                  Title = p.BannerTitle,
                                  Category = u.CategoryName,
                                  NotificationText = p.NotificationText,
                                  BannerOrNotification = (int)o.BannerOrNotification,                                  
                                  ValidFrom = (DateTime)o.ValidFrom,
                                  ValidTo = (DateTime)o.ValidTo,
                                  Status = o.ActiveflagC,
                                  BannerType = bl.BannerTypeName                                  
                              }).OrderBy(x => x.BannerId).ToList();


            foreach (var item in bannerData)
            {

                BannerData bannerDatas = new BannerData();
                bannerDatas.BannerId = item.BannerId;
                bannerDatas.ActionType = item.ActionType;
                bannerDatas.BannerImage = item.BannerImage;
                bannerDatas.Title = item.Title;
                bannerDatas.Category = item.Category;
                bannerDatas.NotificationText = item.NotificationText;
                bannerDatas.BannerOrNotification = item.BannerOrNotification;
                bannerDatas.Actiontext = "";
                bannerDatas.ActionLink = "";
                bannerDatas.ActionTypeId = item.ActionTypeId;

                if (bannerDatas.ActionTypeId == (int)ActionType.HTML || bannerDatas.ActionTypeId == (int)ActionType.Text)
                {
                    bannerDatas.Actiontext = item.Actiontext;
                }

                if (bannerDatas.ActionTypeId == (int)ActionType.Link || bannerDatas.ActionTypeId == (int)ActionType.Image || bannerDatas.ActionTypeId == (int)ActionType.File)
                {
                    bannerDatas.ActionLink = item.Actiontext;
                }

          

                bannerDatas.fromdate = item.ValidFrom.ToShortDateString();
                bannerDatas.todate = item.ValidTo.ToShortDateString();

                bannerDatas.Status = item.Status;
                bannerDatas.BannerType = item.BannerType;
                bannerDatas.ModelList = GetBannerModelList(item.BannerId, LanguageID);
                bannerDatas.StateList = GetBannerStateList(item.BannerId, LanguageID);
                bannerDatas.UserCount = GetUserCount(item.BannerId, LanguageID);
                Bannerlist.Add(bannerDatas);
            }

            return Bannerlist;
        }

        //Get Models list
        public  string GetBannerModelList(int BannerId, int LanguageID)
        {
            string ModelList = "";
        
                var ModelsList = (from p in _context.TblBanners
                                  join s in _context.TblBannersModelMapping on p.BannerId equals s.BannerId
                                  join o in _context.MstTpdhModelLang on s.ModelcodeVc equals o.ModelcodeVc
                                  where p.BannerId == BannerId
                                  && (LanguageID == null || o.MstLangId == LanguageID)
                                  select new
                                  {
                                      MODELCODE_VC = o.ModelcodeVc,
                                      MODELNAME_VC = o.ModelnameVc
                                  }).ToList();

                foreach (var item in ModelsList)
                {
                    ModelList = ModelList + item.MODELNAME_VC + ",";
                }
                if (ModelList.Length > 1)
                {
                    ModelList = ModelList.Remove(ModelList.Length - 1);
                }
                return ModelList;


            
        }

        //Get States list
        public string GetBannerStateList(int BannerId, int? languageID)
        {
             string Statelist = "";
          
                var statesList = (from p in _context.TblBanners
                                  join s in _context.TblBannersLocationMapping on p.BannerId equals s.BannerId
                                  join o in _context.MstStateLang on s.StateCodeI equals o.StateCodeI
                                  where p.BannerId == BannerId
                                  && (languageID == null || o.MstLangId == languageID)
                                  select new
                                  {
                                      StateCode_I = o.StateCodeI,
                                      StateName_VC = o.StateNameVc
                                  }).ToList();

                foreach (var item in statesList)
                {
                    Statelist = Statelist + item.StateName_VC + ",";
                }
                if (Statelist.Length > 1)
                {
                    Statelist = Statelist.Remove(Statelist.Length - 1);
                }
                return Statelist;


        }

        public IEnumerable<string> GetStateList4UserCount(int BannerId, int? languageID)
        {
            List<string> Statelist;
           
                var statesList = (from p in _context.TblBanners
                                  join s in _context.TblBannersLocationMapping on p.BannerId equals s.BannerId
                                  join o in _context.MstStateLang on s.StateCodeI equals o.StateCodeI
                                  where p.BannerId == BannerId && string.IsNullOrEmpty(s.StateCodeI) == false
                                  && (languageID == null || o.MstLangId == languageID)
                                  group s by new { s.StateCodeI } into grouped
                                  select new
                                  {
                                      StateCode_I = grouped.Key.StateCodeI,

                                  }).ToList();

                Statelist = new List<string>();
                foreach (var item in statesList)
                {
                    Statelist.Add(item.StateCode_I);
                }
                return Statelist;


            
        }
        public int GetUserCount(int BannerId, int LanguageId)
        {
            int Count = 0;
            try
            {

                UserCount userCount = new UserCount();

                userCount.SelectedStates = GetStateList4UserCount(BannerId, LanguageId).ToList(); ;
                userCount.SelectedDistricts = GetDistrictList4UserCount(BannerId, LanguageId).ToList();

                if ((userCount.SelectedStates == null) && (userCount.SelectedStates == null) && (userCount.SelectedStates == null))
                {
                    Count = 0;
                }
                else
                {
                    if (userCount.SelectedStates == null)
                    {
                        userCount.SelectedStates = new List<string>();
                    }
                    if (userCount.selectedApplicableLanguage == null)
                    {
                        userCount.selectedApplicableLanguage = new List<int>();
                    }
                    if (userCount.SelectedDistricts == null)
                    {
                        userCount.SelectedDistricts = new List<string>();
                    }


                    var Userlist = (
                                    from s in _context.MstState                                       
                                        join d in _context.MstDistrict on s.StateCodeI equals d.StateCodeI
                                       
                                        join t in _context.MstTehsil on d.DistrictCodeVc equals t.DistrictCodeVc
                                       

                                        join v in _context.MstVillage on t.TehsilCodeVc equals v.TehsilCodeVc
                                    join v1 in _context.MstVillageLang on v.VillageCodeVc equals v1.VillageCodeVc

                                    join u in _context.MstCustprofile on v.VillageCodeVc equals u.VillageCodeVc
                                      
                                        where
        

                                     (userCount.SelectedStates.Contains(s.StateCodeI) ||
                                      userCount.SelectedDistricts.Contains(d.DistrictCodeVc)) &&
                                      userCount.selectedApplicableLanguage.Any(i => i == u.LanguagePreference)
                                  
                                        group u by new { u.CustCodeVc } into grouped
                                     
                                        select new
                                    {
                                        userid = grouped.Key.CustCodeVc
                                    }


                                    ).ToList();



                    Count = Userlist.ToList().Count;

                }



            }
            catch (Exception ex)
            {

            }
            return Count;
        }

        public int GetUserList(UserCount userCount)
        {
            int Count = 0;
            try
            {

                if ((userCount.SelectedDistricts == null) && (userCount.SelectedStates == null) && (userCount.selectedApplicableLanguage == null))
                {
                    Count = 0;
                }
                else
                {
                    if (userCount.SelectedStates == null)
                    {
                        userCount.SelectedStates = new List<string>();
                    }
                    if (userCount.selectedApplicableLanguage == null)
                    {
                        userCount.selectedApplicableLanguage = new List<int>();
                    }
                    if (userCount.SelectedDistricts == null)
                    {
                        userCount.SelectedDistricts = new List<string>();
                    }


                    if ((userCount.SelectedStates == null) && (userCount.SelectedStates == null) && (userCount.SelectedStates == null))
                    {
                        Count = 0;
                    }
                    else
                    {
                        if (userCount.SelectedStates == null)
                        {
                            userCount.SelectedStates = new List<string>();
                        }
                        if (userCount.selectedApplicableLanguage == null)
                        {
                            userCount.selectedApplicableLanguage = new List<int>();
                        }
                        if (userCount.SelectedDistricts == null)
                        {
                            userCount.SelectedDistricts = new List<string>();
                        }



                        var Userlist = (
                                        from s in _context.MstState
                                        join d in _context.MstDistrict on s.StateCodeI equals d.StateCodeI

                                        join t in _context.MstTehsil on d.DistrictCodeVc equals t.DistrictCodeVc


                                        join v in _context.MstVillage on t.TehsilCodeVc equals v.TehsilCodeVc
                                        join v1 in _context.MstVillageLang on v.VillageCodeVc equals v1.VillageCodeVc

                                        join u in _context.MstCustprofile on v.VillageCodeVc equals u.VillageCodeVc

                                        where


                                     (userCount.SelectedStates.Contains(s.StateCodeI) ||
                                      userCount.SelectedDistricts.Contains(d.DistrictCodeVc)) &&
                                      userCount.selectedApplicableLanguage.Any(i => i == u.LanguagePreference)

                                        group u by new { u.CustCodeVc } into grouped

                                        select new
                                        {
                                            userid = grouped.Key.CustCodeVc
                                        }


                                        ).ToList();



                        Count = Userlist.ToList().Count;

                    }

                }

            }
            catch (Exception ex)
            {

            }
            return Count;
        }
        public IEnumerable<string> GetDistrictList4UserCount(int BannerId, int? languageID)
        {
            List<string> DistrictList;
      

                var districtlist = (from p in _context.TblBannersLang
                                    join s in _context.TblBannersLocationMapping on p.BannerId equals s.BannerId
                                    join o in _context.MstDistrictLang on s.DistrictCodeVc equals o.DistrictCodeVc
                                    where p.BannerId == BannerId && string.IsNullOrEmpty(s.DistrictCodeVc) == false
                                    && (languageID == null || o.MstLangId == languageID)
                                    group s by new { s.DistrictCodeVc } into grouped
                                    select new
                                    {
                                        DistrictCode_VC = grouped.Key.DistrictCodeVc,

                                    }).ToList();

                DistrictList = new List<string>();
                foreach (var item in districtlist)
                {
                    DistrictList.Add(item.DistrictCode_VC);
                }
                return DistrictList;


            
        }
        public IEnumerable<StateSelectList> GetStatesList(int languageID)
        {
         
                var statesList = (from p in _context.MstStateLang
                                  join o in _context.MstState on p.StateCodeI equals o.StateCodeI
                                  where p.ActiveflagC == "A"
                                  && o.ActiveFlagC == "A"
                                  && (p.MstLangId == languageID)
                                  select new StateSelectList
                                  {
                                      StateCode_I = o.StateCodeI,
                                      StateName_VC = p.StateNameVc
                                  }).ToList();
                return statesList;
            
        }
        //Get District list
        public IEnumerable<DistrictSelectList> GetDistrictList(int? languageID)
        {
         
                var districtList = (from p in _context.MstDistrictLang
                                    join o in _context.MstDistrict on p.DistrictCodeVc equals o.DistrictCodeVc
                                    where p.ActiveflagC == "A"
                                    && o.ActiveflagC == "A"
                                    && (languageID == null || p.MstLangId == languageID)
                                    select new DistrictSelectList
                                    {
                                        DistrictCode_VC = o.DistrictCodeVc,
                                        DistrictName_VC = p.DistrictNameVc
                                    }).ToList();

                return districtList;
           

        }
        //public IEnumerable<BannerData> GetBannerListBySearch(BannerModel bannermodel)
        public IEnumerable<BannerData> GetBannerListBySearch(List<string> SelectedStates,string Validity,int selectedLanguage,int SelectedBannerType)
        {
            //var Dates = bannermodel.SearchModel.Validity.Split('-');
            var Dates =Validity.Split('-');
            DateTime fromDate = new DateTime();
            DateTime toDate = new DateTime();

            DateTime.TryParseExact(Dates[0].Trim(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fromDate);
            DateTime.TryParseExact(Dates[1].Trim(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out toDate);


            //bannerData = null,

            BannerSearchModel searchModel = new BannerSearchModel();
            //searchModel = bannermodel.SearchModel;



            //if (bannermodel.SearchModel.SelectedStates == null)
            //{
            //    bannermodel.SearchModel.SelectedStates = new List<string>();
            //}
            if (SelectedStates == null)
            {
                SelectedStates = new List<string>();
            }



            List<BannerData> Bannerlist = new List<BannerData>();
            var bannerData = (from p in _context.TblBannersLang
                              join o in _context.TblBanners on p.BannerId equals o.BannerId
                              join i in _context.MstBannercategory on o.Category equals i.CategoryId
                              join u in _context.MstBannercategoryLang on i.CategoryId equals u.CategoryId
                              join a in _context.MstBanneractiontype on o.ActionType equals a.ActionTypeId
                              join al in _context.MstBanneractiontypeLang on a.ActionTypeId equals al.ActionTypeId
                              join b in _context.MstBannertype on o.BannerOrNotification equals b.BannerTypeId
                              join bl in _context.MstBannertypeLang on b.BannerTypeId equals bl.BannerTypeId
                              join l in _context.TblBannersLocationMapping on o.BannerId equals l.BannerId
                              where

                                (SelectedStates.Count == 0 || SelectedStates.Contains(l.StateCodeI))
                                
                              &&

                              p.MstLangId == selectedLanguage && u.MstLangId == selectedLanguage && al.MstLangId == selectedLanguage && bl.MstLangId == selectedLanguage
                              &&
                              (SelectedBannerType == 0 || o.BannerOrNotification == SelectedBannerType)
                              && (o.ValidFrom >= fromDate && o.ValidTo <= toDate)
                              group o by new
                              {
                                  o.BannerId,
                                  al.ActionTypeName,
                                  al.ActionTypeId,
                                  o.ActionTypeTarget,
                                  o.BannerImage
                              ,
                                  p.BannerTitle,
                                  u.CategoryName,
                                  p.NotificationText,
                                  o.BannerOrNotification,
                                  o.ValidFrom,
                                  o.ValidTo,
                                  o.ActiveflagC,
                                  bl.BannerTypeName
                              } into grouped
                              //&& u.MST_LANG_ID == languageID
                              select new BannerData
                              {
                                  BannerId = grouped.Key.BannerId,
                                  ActionType = grouped.Key.ActionTypeName,
                                  ActionTypeId = grouped.Key.ActionTypeId,
                                  Actiontext = grouped.Key.ActionTypeTarget,
                                  BannerImage = grouped.Key.BannerImage,
                                  Title = grouped.Key.BannerTitle,
                                  Category = grouped.Key.CategoryName,
                                  NotificationText = grouped.Key.NotificationText,
                                  BannerOrNotification = (int)grouped.Key.BannerOrNotification,
                                  //ValidFrom = o.Valid_From.HasValue ? o.Valid_From.ToString() : "0",
                                  //ValidTo = o.Valid_To.HasValue ? o.Valid_To.ToString() : "0",
                                  ValidFrom = (DateTime)grouped.Key.ValidFrom,
                                  ValidTo = (DateTime)grouped.Key.ValidTo,
                                  Status = grouped.Key.ActiveflagC,
                                  BannerType = grouped.Key.BannerTypeName
                                  //StateList=GetBannerStateList(p.BANNER_ID,1)                                              
                              }).ToList();


            foreach (var item in bannerData)
            {

                BannerData bannerDatas = new BannerData();
                bannerDatas.BannerId = item.BannerId;
                bannerDatas.ActionType = item.ActionType;
                bannerDatas.BannerImage = item.BannerImage;
                bannerDatas.Title = item.Title;
                bannerDatas.Category = item.Category;
                bannerDatas.NotificationText = item.NotificationText;
                bannerDatas.BannerOrNotification = item.BannerOrNotification;
                bannerDatas.Actiontext = "";
                bannerDatas.ActionLink = "";
                bannerDatas.ActionTypeId = item.ActionTypeId;

                if (bannerDatas.ActionTypeId == (int)ActionType.HTML || bannerDatas.ActionTypeId == (int)ActionType.Text)
                {
                    bannerDatas.Actiontext = item.Actiontext;
                }

                if (bannerDatas.ActionTypeId == (int)ActionType.Image || bannerDatas.ActionTypeId == (int)ActionType.File || bannerDatas.ActionTypeId == (int)ActionType.Link)
                {
                    bannerDatas.ActionLink = item.Actiontext;
                }

             

                bannerDatas.fromdate = item.ValidFrom.ToShortDateString();
                bannerDatas.todate = item.ValidTo.ToShortDateString();

                bannerDatas.Status = item.Status;
                bannerDatas.BannerType = item.BannerType;
                bannerDatas.ModelList = GetBannerModelList(item.BannerId, searchModel.selectedLanguage);
                bannerDatas.StateList = GetBannerStateList(item.BannerId, searchModel.selectedLanguage);
                bannerDatas.UserCount = GetUserCount(item.BannerId, searchModel.selectedLanguage);
                Bannerlist.Add(bannerDatas);
            }

            return Bannerlist;

        }
        public int BannerCount(AddNewBanner NewBanner)
        {
            int bannercount = 0;

            try
            {
                if (NewBanner.SelectedStates == null)
                {
                    NewBanner.SelectedStates = new List<string>();
                }
                if (NewBanner.languageModel.selectedApplicableLanguage == null)
                {
                    NewBanner.languageModel.selectedApplicableLanguage = new List<int>();
                }
                if (NewBanner.SelectedDistricts == null)
                {
                    NewBanner.SelectedDistricts = new List<string>();
                }

              
                var bannerlist = (

                                        from p in _context.TblBannersLang
                                        join o in _context.TblBanners on p.BannerId equals o.BannerId
                                        join l in _context.TblBannersLocationMapping on o.BannerId equals l.BannerId
                                        where
                                      p.ActiveflagC == "A" &&
                                      o.ActiveflagC == "A" &&
                                     o.Category != 1 &&
                                      (NewBanner.SelectedStates.Contains(l.StateCodeI) ||
                                      NewBanner.SelectedDistricts.Contains(l.DistrictCodeVc)) &&
                                      (NewBanner.languageModel.selectedApplicableLanguage.Contains(p.MstLangId))
                                     

                                        group p by new { p.BannerId } into grouped
                                        
                                        select new
                                        {
                                            userid = grouped.Key.BannerId
                                        }


                                        ).ToList();

                /*Udhay code*/

                var locationBannerCount = (from p in _context.TblBannersLocationMapping
                                           where NewBanner.SelectedStates.Contains(p.StateCodeI)
                                           || NewBanner.SelectedDistricts.Contains(p.DistrictCodeVc)
                                           select p.BannerId).Distinct().Count();


                /*Udhay code*/


                bannercount = bannerlist.ToList().Count;
            }
            catch (Exception ex)
            {

            }
            return bannercount;

        }


        //Get Tip of the category list
        public IEnumerable<CategorySelectList> GetCategoryList(int? languageID)
        {
            
                var CategoryList = (from p in _context.MstBannercategoryLang
                                    join o in _context.MstBannercategory on p.CategoryId equals o.CategoryId
                                    where p.ActiveflagC == "A"
                                    && o.ActiveflagC == "A"
                                    && (languageID == null || p.MstLangId == languageID)
                                    select new CategorySelectList
                                    {
                                        CategoryID = o.CategoryId,
                                        CategoryName = p.CategoryName
                                    }).ToList();
                return CategoryList;
          

        }
        public int AddBanner(AddNewBanner NewBanner, int? languageID,string Host)
        {
            //string Host = "";
            int BannerId = 0;
            try
            {
                
                //Host = System.Web.HttpContext.Current.Request.Url.Scheme + "://" + System.Web.HttpContext.Current.Request.Url.Authority + "/";

              
                //Date Manipulation
                var Dates = NewBanner.Validity.Split('-');

                DateTime fromDate = new DateTime();
                DateTime toDate = new DateTime();

                if (DateTime.TryParseExact(Dates[0].Trim(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fromDate))
                {
                    if (DateTime.TryParseExact(Dates[1].Trim(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out toDate))
                    {

                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }


                //tbl_banners
              
                var banner = new TblBanners();
                banner.ActionType = NewBanner.SelectedBannerAction;

                if (banner.ActionType == (int)ActionType.HTML || banner.ActionType == (int)ActionType.Text)
                {
                    banner.ActionTypeTarget = NewBanner.ActionTypeTarget;
                }
                else if (banner.ActionType == (int)ActionType.Link)
                {
                    banner.ActionTypeTarget = NewBanner.ActionLink;
                }
                else
                {
                    banner.ActionTypeTarget = NewBanner.ActionTypeTarget;
                }

                if (NewBanner.BannerType == 1)
                {
                    banner.Category = NewBanner.SelectedCategory;
                }

                banner.ValidFrom = fromDate;
                banner.ValidTo = toDate;
                banner.ActiveflagC = "A";
                banner.CreateddtD = DateTime.Now;
                banner.BannerOrNotification = NewBanner.BannerType;

                if (NewBanner.BannerType == 2)
                {
                    banner.ActionType = (int)ActionType.HTML;
                }


                _context.TblBanners.Add(banner);

                int result = _context.SaveChanges();

                if (result > 0)
                {
                    BannerId = banner.BannerId;

                    TblBanners objbanner =_context.TblBanners.Single(v => v.BannerId == BannerId);


                    string FileName4Banner = BannerId + "_Banner" + ".png";


                    string ActualBannerImageName = "";
                    if (!string.IsNullOrEmpty(NewBanner.BannerImageURL))
                    {
                     

                        ActualBannerImageName = SaveImage(NewBanner.BannerImageURL, VirtualPath4Banner, FileName4Banner);
                        
                        objbanner.BannerImage = Host + ActualPath4Banner + ActualBannerImageName;
                        
                    }


                    string BannerActionFileName = "";

                    if (NewBanner.ActionFile != null)
                    {
                        string FileName4ActionFile = BannerId + "_Banner";
                        BannerActionFileName = UploadImage(NewBanner.ActionFile, FileName4ActionFile, VirtualPath4Banner);
                   
                        objbanner.ActionTypeTarget = Host + ActualPath4Banner + BannerActionFileName;

                        if (Path.GetExtension(NewBanner.ActionFile.FileName) == ".pdf")
                        {
                            objbanner.ActionSubType = (int)SubActionType.PDF;
                        }
                        else
                        {
                            objbanner.ActionSubType = (int)SubActionType.Video;
                        }
 
                    }
                    

                    if (banner.ActionType == (int)ActionType.Image || banner.ActionType == (int)ActionType.Text || banner.ActionType == (int)ActionType.File)
                    {
                        string FileName4BannerAction = BannerId + "_BannerAction" + ".png";
                        if (!string.IsNullOrEmpty(NewBanner.ActionImageURL))
                        {
      

                            string ActionImageName = SaveImage(NewBanner.ActionImageURL, VirtualPath4BannerAction, FileName4BannerAction);
                            objbanner.ActionTypeTarget = Host + ActualPath4BannerAction + ActionImageName;
                        }
                    }


                    _context.SaveChanges();

                    if (NewBanner.languageModel.selectedApplicableLanguage == null)
                    {
                        var bannerlang = new TblBannersLang();
                        bannerlang.BannerTitle = NewBanner.Subject;
                        bannerlang.ActiveflagC = "A";
                        bannerlang.CreateddtD = DateTime.Now;
                        bannerlang.MstLangId= 1;
                        bannerlang.ActiveflagC = "A";
                        bannerlang.CreateddtD = DateTime.Now;
                        bannerlang.BannerId = BannerId;
                        bannerlang.NotificationText = NewBanner.Notificationtext;
                        _context.TblBannersLang.Add(bannerlang);
                    }
                    else
                    {
                        foreach (int itm in NewBanner.languageModel.selectedApplicableLanguage)
                        {
                            //for tip of the day language

                            //tbl_banners
                            var bannerlang = new TblBannersLang();
                            bannerlang.BannerTitle = NewBanner.Subject;
                            bannerlang.ActiveflagC = "A";
                            bannerlang.CreateddtD = DateTime.Now;
                            bannerlang.MstLangId = itm;
                            bannerlang.ActiveflagC = "A";
                            bannerlang.CreateddtD = DateTime.Now;
                            bannerlang.NotificationText = NewBanner.Notificationtext;
                            bannerlang.BannerId = BannerId;
                            _context.TblBannersLang.Add(bannerlang);


                        }
                    }

                    //For each states
                    if (NewBanner.SelectedStates != null)
                    {
                        foreach (var itm in NewBanner.SelectedStates)
                        {
                            var StateMapping = new TblBannersLocationMapping();
                            StateMapping.BannerId = banner.BannerId;
                            StateMapping.StateCodeI = itm;
                            _context.TblBannersLocationMapping.Add(StateMapping);

                        }

                    }
                    //For each districts
                    if (NewBanner.SelectedDistricts != null)
                    {
                        foreach (var itm in NewBanner.SelectedDistricts)
                        {
                            var DistrictMapping = new TblBannersLocationMapping();
                            DistrictMapping.BannerId = banner.BannerId;
                            DistrictMapping.DistrictCodeVc = itm;

                            _context.TblBannersLocationMapping.Add(DistrictMapping);
                        }
                    }

                    if (NewBanner.SelectedModel != null)
                    {
                        //For each Models
                        foreach (var itm in NewBanner.SelectedModel)
                        {
                            var modelMapping = new  TblBannersModelMapping();
                            modelMapping.BannerId = banner.BannerId;
                            modelMapping.ModelcodeVc = itm;
                            _context.TblBannersModelMapping.Add(modelMapping);
                        }
                    }
                    result = _context.SaveChanges();


                    //if (result > 0)
                    //{
                    //    ViewBag.BannerId = "'" + banner.BANNER_ID + "'";
                    //    return true;
                    //}
                    //else
                    //{
                    //    ViewBag.BannerId = "'0'";
                    //    return false;
                    //}
                }
                else
                {
                    //ViewBag.BannerId = "'0'";
                    return 0;
                }

            }
            catch (Exception e)
            {
                //ViewBag.BannerId = "'0'";
                return 0;
            }
           return BannerId;
        }

        //function to save image in a path
        public string SaveImage(string base64String, string filepath, string filename)
        {
            try
            {

                //IHostingEnvironment Environment;
                //Path.Combine(Environment.web, "Uploads");

                //Path.Combine(Environment.WebRootPath, filepath);



                //bool exists = System.IO.Directory.Exists(HttpContext.Current.Server.MapPath(filepath));
                //if (!exists)
                //{
                //    System.IO.Directory.CreateDirectory(HttpContext.Current.Server.MapPath(filepath));
                //}
                //var fullpath = HttpContext.Current.Server.MapPath(filepath);


                //string Actualpath = Path.Combine(Environment.WebRootPath, filepath);



              

                bool exists = System.IO.Directory.Exists(Path.GetFullPath(filepath).Replace("~\\", ""));
                if (!exists)
                {
                    System.IO.Directory.CreateDirectory(Path.GetFullPath(filepath).Replace("~\\", ""));
                }
                var fullpath = Path.Combine(Path.GetFullPath(filepath).Replace("~\\", ""));

                string base64 = base64String.Substring(base64String.IndexOf(',') + 1);
                var bytess = Convert.FromBase64String(base64);

                using (var imageFile = new FileStream(fullpath + filename, FileMode.Create))
                {
                    imageFile.Write(bytess, 0, bytess.Length);
                    imageFile.Flush();
                }



                return filename;


            }
            catch (Exception ex)
            {
                throw new ApplicationException("while saving image: " + ex.Message);

            }
        }
        public string UploadImage(IFormFile Image, string filename, string ImageVirtualPath)
        {
            string ActualVirtualPath = "";
            try
            {
                ActualVirtualPath = ImageVirtualPath;
                ImageVirtualPath = "~/" + ImageVirtualPath;
                string ActualImageName = filename + Path.GetExtension(Image.FileName);
                string filePath = ImageVirtualPath;



                //bool exists = System.IO.Directory.Exists(Server.MapPath(ImageVirtualPath));
                //if (!exists)
                //{
                //    System.IO.Directory.CreateDirectory(Server.MapPath(ImageVirtualPath));
                //}

                //var fullpath = HttpContext.Server.MapPath(filePath);

                bool exists = System.IO.Directory.Exists(Path.GetFullPath(ImageVirtualPath).Replace("~\\", ""));
                if (!exists)
                {
                    System.IO.Directory.CreateDirectory(Path.GetFullPath(ImageVirtualPath).Replace("~\\", ""));
                }
                var fullpath = Path.Combine(Path.GetFullPath(ImageVirtualPath).Replace("~\\", ""));


                if (System.IO.File.Exists(fullpath + ActualImageName))
                {
                    System.IO.File.Delete(fullpath + ActualImageName);
                }
                //Image.co
                //Image.SaveAs(fullpath + ActualImageName);

                using (var fileStream = new FileStream(fullpath + ActualImageName, FileMode.Create))
                {
                    Image.CopyToAsync(fileStream);
                }
                //return path + ActualVirtualPath + ActualImageName;
                return ActualImageName;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public int UserCount(UserCount userCount)
        {
            int Count = 0;
            try
            {

                if ((userCount.SelectedDistricts == null) && (userCount.SelectedStates == null) && (userCount.selectedApplicableLanguage == null))
                {
                    Count = 0;
                }
                else
                {
                    if (userCount.SelectedStates == null)
                    {
                        userCount.SelectedStates = new List<string>();
                    }
                    if (userCount.selectedApplicableLanguage == null)
                    {
                        userCount.selectedApplicableLanguage = new List<int>();
                    }
                    if (userCount.SelectedDistricts == null)
                    {
                        userCount.SelectedDistricts = new List<string>();
                    }

                 

                        var Userlist = (
                                        from s in _context.MstState
                                        join d in _context.MstDistrict on s.StateCodeI equals d.StateCodeI

                                        join t in _context.MstTehsil on d.DistrictCodeVc equals t.DistrictCodeVc

                                        join v in _context.MstVillage on t.TehsilCodeVc equals v.TehsilCodeVc
                                        join v1 in _context.MstVillageLang on v.VillageCodeVc equals v1.VillageCodeVc

                                        join u in _context.MstCustprofile on v.VillageCodeVc equals u.VillageCodeVc

                                        where

                                         (userCount.SelectedStates.Contains(s.StateCodeI) ||
                                          userCount.SelectedDistricts.Contains(d.DistrictCodeVc)) &&
                                          userCount.selectedApplicableLanguage.Any(i => i == u.LanguagePreference)

                                        group u by new { u.CustCodeVc } into grouped

                                        select new
                                        {
                                            userid = grouped.Key.CustCodeVc
                                        }


                                        ).ToList();



                        Count = Userlist.ToList().Count;
                    }
                



            }
            catch (Exception ex)
            {

            }

            return Count;
        }
        public bool CheckDefaultBannerExists(UpdateBannerStatus Status, int SelectedLanguage = 1)
        {
            int activecount = 0;
            int statecount = 0;
            int districtcount = 0;
            bool Defaultbannerexists = false;
            try
            {

                var statesList = _global.GetStatesBylanguageID(SelectedLanguage).ToList();
               

                var districtList = _global.GetDistrictsBylanguageID(SelectedLanguage).ToList();

                statecount = statesList.ToList().Count;
                districtcount = districtList.ToList().Count;

              
                var banneractivelist = (

                                        from o in _context.TblBanners
                                        join l in _context.TblBannersLocationMapping on o.BannerId equals l.BannerId
                                        where o.ActiveflagC == "A" && o.Category == 1

                                        select new
                                        {
                                            BannerId = o.BannerId,
                                            StateCode = l.StateCodeI,
                                            DistrictCode = l.DistrictCodeVc 
                                        }).ToList();



                var bannerlist = (
                                       from o in _context.TblBanners
                                       where o.ActiveflagC == "A" && o.Category == 1 && o.BannerId != Status.BannerId

                                       select new
                                       {
                                           BannerId = o.BannerId
                                       }).ToList();

                foreach (var item in bannerlist)
                {
                    var banneractivedistrict = banneractivelist.Where(i => i.DistrictCode != null && i.BannerId == item.BannerId).ToList();
                    var banneractivedistate = banneractivelist.Where(i => i.StateCode != null && i.BannerId == item.BannerId).ToList();
                    if ((banneractivedistate.Count == statecount) && (banneractivedistrict.Count == districtcount))
                    {
                        Defaultbannerexists = true;
                        break;
                    }

                }

            }
            catch (Exception ex)
            {

            }
            return Defaultbannerexists;
        }
        public string UpdateStatus(UpdateBannerStatus Status)
        {
            string status = "";
            bool checkbannerexists = true;
            string Statusmsg = "";
            try
            { 
            if (Status.IsActive == "Inactive")
            {
                status = "A";
            }
            else
            {
                status = "I";
            }
            TblBanners tbl_Banners = _context.TblBanners.Single(v => v.BannerId == Status.BannerId);
            if (tbl_Banners.Category == 1 && Status.IsActive == "Active")
            {
                checkbannerexists = CheckDefaultBannerExists(Status, 1);
            }
            if (checkbannerexists == true)
            {
                tbl_Banners.ActiveflagC = status;
                _context.SaveChanges();
                Statusmsg = "Success";
            }
            else
            {
                Statusmsg = "Atleast one Defaut Banner should be active";
            }
            }
            catch(Exception ex)
            {

            }


            return Statusmsg;
        }

        //Get Model list
        public IEnumerable<ModelSelectList> GetModelList(int? languageID)
        {
           
                var ModelList = (from p in _context.MstTpdhModel
                                 join o in _context.MstTpdhModelLang on p.ModelcodeVc equals o.ModelcodeVc
                                 where p.ActiveflagC == "A"
                                    && o.ActiveflagC == "A"
                                    && (languageID == null || o.MstLangId == languageID)
                                 select new ModelSelectList
                                 {
                                     MODELCODE_VC = o.ModelcodeVc,
                                     MODELNAME_VC = o.ModelnameVc
                                 }).ToList();

                return ModelList;
            

        }

        //Get Banner Action list
        public IEnumerable<BannerActionSelectList> GetBannerActionList(int? languageID)
        {
          
                var bannerActionSelectList = (from a in _context.MstBanneractiontype
                                              join al in _context.MstBanneractiontypeLang on a.ActionTypeId equals al.ActionTypeId
                                              where a.ActiveflagC == "A"
                                              && a.ActiveflagC == "A"
                                              && (languageID == null || al.MstLangId== languageID)
                                              select new BannerActionSelectList
                                              {
                                                  ActionTypeID = al.ActionTypeId,
                                                  ActionTypeName = al.ActionTypeName
                                              }).ToList();

        
                return bannerActionSelectList.OrderBy(x => x.ActionTypeID).ToList();


           

        }


    }
}
