using BannersAndNotification.WebAPI.DataProvider;
using BannersAndNotification.WebAPI.Models.Banners;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Text.Json;

namespace BannersAndNotification.WebAPI.Services
{
    public class BannersService:IBannersService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);


        private readonly IGlobalService _global;

        string moduleName = "";
        public BannersService(dev_encrypted_generalcustomerappContext dataContext, IGlobalService Global)
        {
            _context = dataContext;
            _global = Global;
        }

        public HomePageModel GetBanners(string LanguageCode, string customerCode)
        {

            HomePageModel homepageModel = new HomePageModel();


         
                //Get Languages
                List<MstLanguage> languages = _global.GetLanguageList(LanguageCode, customerCode);

                var customerLocation = (from p in _context.MstCustprofile
                                        join o in _context.MstVillage on p.VillageCodeVc equals o.VillageCodeVc
                                        join i in _context.MstTehsil on o.TehsilCodeVc equals i.TehsilCodeVc
                                        join u in _context.MstDistrict on i.DistrictCodeVc equals u.DistrictCodeVc
                                        join y in _context.MstState on u.StateCodeI equals y.StateCodeI
                                        where p.CustCodeVc == customerCode
                                        select new
                                        {
                                            u.DistrictCodeVc,
                                            y.StateCodeI
                                        }).FirstOrDefault();



                List<HomePage> homepageList = new List<HomePage>();
                foreach (var Language in languages)
                {
                HomePage homePage = new HomePage
                {
                    languagecode = Language.LanguageCode,
                    bannerlist = new BannersList
                    {
                        banners = (from p in _context.TblBannersLang
                                   join o in _context.TblBanners on p.BannerId equals o.BannerId
                                   join i in _context.MstBannertype on o.BannerOrNotification equals i.BannerTypeId
                                   join u in _context.MstBannertypeLang on i.BannerTypeId equals u.BannerTypeId
                                   join y in _context.MstBanneractiontype on o.ActionType equals y.ActionTypeId
                                   join t in _context.MstBanneractiontypeLang on y.ActionTypeId equals t.ActionTypeId
                                   join r in _context.TblBannersLocationMapping on o.BannerId equals r.BannerId
                                   join e in _context.MstBannercategory on o.Category equals e.CategoryId
                                   join w in _context.MstBannercategoryLang on e.CategoryId equals w.CategoryId
                                   //from x in _context.TblNotificationTracker.Where(notification => notification.NotificationId == p.BannerId && notification.CustCodeVc == customerCode).DefaultIfEmpty()
                                   where p.ActiveflagC == "A" && o.ActiveflagC == "A"


                                   && dev_encrypted_generalcustomerappContext.TruncateTime(o.ValidFrom) <= dev_encrypted_generalcustomerappContext.TruncateTime(DateTime.Now)
                                   && dev_encrypted_generalcustomerappContext.TruncateTime(o.ValidTo) >= dev_encrypted_generalcustomerappContext.TruncateTime(DateTime.Now)


                                   //&& DbFunctions(o.ValidFrom) <= DbFunctions.TruncateTime(DateTime.Now)
                                   //&& DbFunctions.TruncateTime(o.ValidTo) >= DbFunctions.TruncateTime(DateTime.Now)
                                   && p.MstLangId == Language.Id
                                   && w.MstLangId == Language.Id
                                   && t.MstLangId == Language.Id
                                   && u.MstLangId == Language.Id
                                   && o.Category == 1
                                   && ((/*y.StateCode_I != null && */r.StateCodeI == customerLocation.StateCodeI) || (/*y.DistrictCode_VC != null &&*/ r.DistrictCodeVc == customerLocation.DistrictCodeVc))
                                   select new Banners
                                   {
                                       bannerid = o.BannerId,
                                       bannertitle = p.BannerTitle,
                                       bannertypeid = o.BannerOrNotification.Value,
                                       bannercategoryid = e.CategoryId,
                                       bannercategory = w.CategoryName,
                                       bannertypevalue = u.BannerTypeName,
                                       bannerimageurl = o.BannerImage,
                                       notificationtext = p.NotificationText,
                                       actiontypeid = o.ActionType.Value,
                                       actiontypevalue = t.ActionTypeName,
                                       actiontypetarget = o.ActionTypeTarget,
                                       banneractionsubtypeid = o.ActionSubType,
                                       //readstatus = (x != null ? x.ReadStatus.Value == 1 ? true : false : false),
                                       notificationtitle = p.BannerTitle
                                   }).Distinct().Take(5).ToList()
                    },
                    tipslist = new TipsList
                    {
                        tips = (from p in _context.TblTipofthedayLang
                                join o in _context.TblTipoftheday on p.TipId equals o.TipId
                                join i in _context.MstTipofthedayCategory on o.CategoryId equals i.TipCategoryId
                                join u in _context.MstTipofthedayCategoryLang on i.TipCategoryId equals u.TipCategoryId
                                join y in _context.TblTipofthedayLocationMapping on o.TipId equals y.TipId
                                where p.ActiveflagC == "A" && o.ActiveflagC == "A" //&& i.ACTIVEFLAG_C == "A"

                                && dev_encrypted_generalcustomerappContext.TruncateTime(o.ValidFrom) <= dev_encrypted_generalcustomerappContext.TruncateTime(DateTime.Now)
                                && dev_encrypted_generalcustomerappContext.TruncateTime(o.ValidThru) >= dev_encrypted_generalcustomerappContext.TruncateTime(DateTime.Now)


                                //&& DbFunctions.TruncateTime(o.ValidFrom) <= DbFunctions.TruncateTime(DateTime.Now)
                                //&& DbFunctions.TruncateTime(o.ValidThru) >= DbFunctions.TruncateTime(DateTime.Now)

                                && p.MstLangId == Language.Id
                                //&& u.MST_LANG_ID == Language.ID
                                && ((/*y.StateCode_I != null && */y.StateCodeI == customerLocation.StateCodeI) || (/*y.DistrictCode_VC != null &&*/ y.DistrictCodeVc == customerLocation.DistrictCodeVc))
                                select new Tips
                                {
                                    tipid = o.TipId,
                                    tipcategory = u.CategoryName,
                                    tiptitle = p.TipTitle,
                                    tiptext = p.TipText,
                                    validfrom = o.ValidFrom.HasValue ? dev_encrypted_generalcustomerappContext.DiffSeconds(o.ValidFrom.Value, epoch) : 0,
                                    validthru = o.ValidThru.HasValue ? dev_encrypted_generalcustomerappContext.DiffSeconds(o.ValidThru.Value, epoch) : 0
                                }).Distinct().ToList()
                    }
                };


                //Get custom banners
                List<Banners> customBannersAndNotification = (from p in _context.TblBannersLang
                                                              join o in _context.TblBanners on p.BannerId equals o.BannerId
                                                              join i in _context.MstBannertype on o.BannerOrNotification equals i.BannerTypeId
                                                              join u in _context.MstBannertypeLang on i.BannerTypeId equals u.BannerTypeId
                                                              join y in _context.MstBanneractiontype on o.ActionType equals y.ActionTypeId
                                                              join t in _context.MstBanneractiontypeLang on y.ActionTypeId equals t.ActionTypeId
                                                              join r in _context.TblBannersLocationMapping on o.BannerId equals r.BannerId
                                                              join e in _context.MstBannercategory on o.Category equals e.CategoryId
                                                              join w in _context.MstBannercategoryLang on e.CategoryId equals w.CategoryId
                                                              join q in _context.TblNotificationTracker on p.BannerId equals q.NotificationId into LF
                                                              from x in LF.DefaultIfEmpty()
                                                                  //from x in _context.TblNotificationTracker.Where(notification => notification.NotificationId == p.BannerId && notification.CustCodeVc == customerCode).DefaultIfEmpty()
                                                              where p.ActiveflagC == "A" && o.ActiveflagC == "A"
                                                              //&& DbFunctions.TruncateTime(o.ValidFrom) <= DbFunctions.TruncateTime(DateTime.Now)
                                                              //&& DbFunctions.TruncateTime(o.ValidTo) >= DbFunctions.TruncateTime(DateTime.Now)

                                                              && dev_encrypted_generalcustomerappContext.TruncateTime(o.ValidFrom) <= dev_encrypted_generalcustomerappContext.TruncateTime(DateTime.Now)
                                                              && dev_encrypted_generalcustomerappContext.TruncateTime(o.ValidTo) >= dev_encrypted_generalcustomerappContext.TruncateTime(DateTime.Now)

                                                              && p.MstLangId == Language.Id
                                                              && w.MstLangId == Language.Id
                                                              && u.MstLangId == Language.Id
                                                              && t.MstLangId == Language.Id
                                                              && (o.Category != 1 || o.Category == null)
                                                              && ((/*y.StateCode_I != null && */r.StateCodeI == customerLocation.StateCodeI) || (/*y.DistrictCode_VC != null &&*/ r.DistrictCodeVc == customerLocation.DistrictCodeVc))
                                                              select new Banners
                                                              {
                                                                  bannerid = o.BannerId,
                                                                  bannertitle = p.BannerTitle,
                                                                  bannertypeid = o.BannerOrNotification.Value,
                                                                  bannercategoryid = e.CategoryId,
                                                                  bannercategory = w.CategoryName,
                                                                  bannertypevalue = u.BannerTypeName,
                                                                  bannerimageurl = o.BannerImage,
                                                                  notificationtext = p.NotificationText,
                                                                  actiontypeid = o.ActionType.Value,
                                                                  actiontypevalue = t.ActionTypeName,
                                                                  actiontypetarget = o.ActionTypeTarget,
                                                                  banneractionsubtypeid = o.ActionSubType,
                                                                  validfrom = o.ValidFrom.HasValue ? dev_encrypted_generalcustomerappContext.DiffSeconds(o.ValidFrom.Value, epoch) : 0,
                                                                  validthru = o.ValidTo.HasValue ? dev_encrypted_generalcustomerappContext.DiffSeconds(o.ValidTo.Value, epoch) : 0,
                                                                  //readstatus=false,
                                                                  readstatus = x.ReadStatus.Value,
                                                                  //(from p in _context.TblNotificationTracker.Where(x => x.NotificationId == p.BannerId && x.CustCodeVc == customerCode && x.ActiveflagC == "A") select p).ToList().Count>0 ?true:false,
                                                                  notificationtitle = p.BannerTitle
                                                              }).Distinct().ToList();


                customBannersAndNotification.ForEach(
                    x => x.readstatus =x.readstatus==1 ?true:false

                );

                    homePage.bannerlist.banners.AddRange(customBannersAndNotification);
                    homePage.bannerlist.totalrecords = homePage.bannerlist.banners.Count;
                    homePage.tipslist.totalrecords = homePage.tipslist.tips.Count;


                    homepageList.Add(homePage);
                }

            homepageModel.homepagemodel = homepageList;
            return homepageModel;

        }
    }
}
