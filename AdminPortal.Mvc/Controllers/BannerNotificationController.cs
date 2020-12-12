using AdminPortal.Mvc.Models.Banner;
using AdminPortal.Mvc.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

namespace AdminPortal.Mvc.Controllers
{
    public class BannerNotificationController : Controller
    {
        private readonly IBannerNotificationService _bannermodel;

        private readonly IGlobalService _global;

        
        public BannerNotificationController(IBannerNotificationService bannermodel, IGlobalService Global)
        {
            _bannermodel = bannermodel;
            _global = Global;
        }

        public IActionResult ManageBannerNotification(int SelectedLanguage = 1)
        {

                List<string> States = new List<string>();
                
                var languages=  _global.GetLanguagedata().ToList();
                var statesList = _global.GetStatesBylanguageID(SelectedLanguage).ToList();
                

                BannerModel bannerModel = new BannerModel();


                bannerModel.SearchModel = new BannerSearchModel
                {
                    LanguageList = new SelectList(languages, "Languageid", "Languagename"),
                    selectedLanguage = SelectedLanguage,
                    StateList = new SelectList(statesList, "StateCodeI", "StateNameVc")


                };

                bannerModel.bannerSearch = new BannerSearch()
                {
                    StateList = new SelectList(statesList, "StateCodeI", "StateNameVc")

                };
                List<BannerData> Bannerlist = new List<BannerData>();


             
                int Search = Convert.ToInt32(TempData["Search"]);

                
                if (Search == 1)
                {

 

                if (TempData["SelectedStates"] != null)
                {

                    States = ((IEnumerable<string>)TempData["SelectedStates"]).ToList();

                   
                }

                Bannerlist = _bannermodel.GetBannerListBySearch(States, TempData["Validity"].ToString(), Convert.ToInt32(TempData["selectedLanguage"]), Convert.ToInt32(TempData["SelectedBannerType"])).ToList();
                bannerModel.SearchModel = new BannerSearchModel();


      
                     bannerModel.SearchModel.LanguageList = new SelectList(languages, "Languageid", "Languagename");
                     bannerModel.SearchModel.selectedLanguage =Convert.ToInt32(TempData["selectedLanguage"]);                    
                    bannerModel.SearchModel.SelectedBannerType = Convert.ToInt32(TempData["SelectedBannerType"]);
                    bannerModel.SearchModel.Validity = TempData["Validity"].ToString();
                    bannerModel.SearchModel.StateList = new SelectList(statesList, "StateCodeI", "StateNameVc", 1);


                    ViewData["StateList"] = TempData["SelectedStates"];

                }
                else
                {
                    Bannerlist = _bannermodel.GetBannerList(SelectedLanguage).ToList();
                }


                bannerModel.bannerData = Bannerlist;
                bannerModel.BannerListCount = 11;
                ViewBag.BannerList = bannerModel.bannerData;

                ViewBag.DataCount = bannerModel.bannerData.Count();




                int StatusChange = Convert.ToInt32(TempData["StatusChange"]);

                if (StatusChange == 1)
                {

                    bool Status = false;
                    if (TempData["Status"] != null) Status = Convert.ToBoolean(TempData["Status"]);


                    string StatusChangeMessage = Convert.ToString(TempData["StatusChangeMessage"]);

                    if (!Status)
                    {
                        ViewBag.Status = "'Failed'";
                        ViewBag.Error = "'Unable to insert Banner Status'";
                    }
                    else
                    {
                        ViewBag.Status = StatusChangeMessage;
                    }

                }



                int IsNewBanner = Convert.ToInt32(TempData["AddNewBanner"]);

                if (IsNewBanner >= 1)
                {

                    bool Status = false;
                    if (TempData["Status"] != null)
                    {
                        Status = Convert.ToBoolean(TempData["Status"]);
                    }

                
                    if (!Status)
                    {
                        ViewBag.Status = "'Failed'";
                        ViewBag.Error = "'Unable to insert New Banner'";
                        ViewBag.BannerId = "'0'";

                    }
                    else
                    {
                        ViewBag.Status = "'Success'";
                        ViewBag.BannerId = TempData["BannerId"];
                    }

                }
                else
                {
                    ViewBag.Status = "'Load'";
                    ViewBag.BannerId = "'0'";
                }

                return View(bannerModel);
            

        }

        [HttpGet]
        public IActionResult AddBannerNotification(int SelectedLanguage = 1)
        {




            var BannerCategoryList =_bannermodel.GetCategoryList(SelectedLanguage).ToList();

            var statesList = _global.GetStatesBylanguageID(SelectedLanguage).ToList();

            var districtList = _global.GetDistrictsBylanguageID(SelectedLanguage).ToList();

            var BannerActionlist = _bannermodel.GetBannerActionList(SelectedLanguage).ToList();

            var ModelList =_bannermodel.GetModelList(SelectedLanguage).ToList();

           


            var languages = _global.GetLanguagedata().ToList();



            ApplicableLanguageModel languageModel = new ApplicableLanguageModel
            {
                LanguageList = new SelectList(languages, "Languageid", "Languagename"),
                selectedApplicableLanguage = null 
            };
            AddNewBanner NewBanner = new AddNewBanner();
            NewBanner.BannerCategoryList = new SelectList(BannerCategoryList, "CategoryID", "CategoryName");
            NewBanner.StateList = new SelectList(statesList, "StateCodeI", "StateNameVc");
            NewBanner.DistrictList = new SelectList(districtList, "DistrictCodeVc", "DistrictNameVc");
            NewBanner.BannerActionList = new SelectList(BannerActionlist, "ActionTypeID", "ActionTypeName");
            NewBanner.ModelList = new SelectList(ModelList, "MODELCODE_VC", "MODELNAME_VC");
            NewBanner.languageModel = languageModel;
            NewBanner.BannerType = 2;

            int AddNewBanner = Convert.ToInt32(TempData["AddNewBanner"]);
            //TempData["Status"]
            if (AddNewBanner == 1)
            {
               
                AddNewBanner NewBannerFail = new AddNewBanner();

                if(TempData["BannerType"]!=null)
                {
                    NewBanner.BannerType = Convert.ToInt32(TempData["BannerType"]);
                }
                if (TempData["SelectedBannerAction"] != null)
                {
                    NewBanner.SelectedBannerAction = Convert.ToInt32(TempData["SelectedBannerAction"]);
                }
                if (TempData["Validity"] != null)
                {
                    NewBanner.Validity = TempData["Validity"].ToString();
                }
                if (TempData["BannerImage"] != null)
                {
                    NewBanner.BannerImage = (IFormFile)TempData["BannerImage"];
                }

                if (TempData["SelectedCategory"] != null)
                {
                    NewBanner.SelectedCategory = Convert.ToInt32(TempData["SelectedCategory"]);
                }
                if (TempData["Notificationtext"] != null)
                {
                    NewBanner.Notificationtext = TempData["Notificationtext"].ToString();
                }
                if (TempData["Subject"] != null)
                {
                    NewBanner.Subject = TempData["Subject"].ToString();
                }
                if (TempData["ActionFile"] != null)
                {
                    NewBanner.ActionFile = (IFormFile)TempData["ActionFile"];
                }
               
                if(TempData["ActionTypeTarget"]!=null)
                {
                    NewBanner.ActionTypeTarget = TempData["ActionTypeTarget"].ToString();
                }
                if (TempData["ActionLink"] != null)
                {
                    NewBanner.ActionLink = TempData["ActionLink"].ToString();
                }
               
                ViewBag.Status = "'Failed'";
                //ViewBag.Error = "'Unable to insert Banner Status'";
                ViewBag.BannerId = "'0'";
                ViewBag.Errormsg = TempData["Errormsg"];

            }
            else
            {
                ViewBag.Status = "'Load'";
                ViewBag.BannerId = "'0'";
                ViewBag.Errormsg = "'0'";
            }


            return View(NewBanner);
        }


        [HttpPost]
        //[ValidateInput(false)]

        public IActionResult AddNewBanner(AddNewBanner NewBanner, int? languageID)
        {
            int BannerId = 0;
            int bannercount = 0;
            bool Status = false;
            string Host = "";
            try
            {
               
                //Host = System.Web.HttpContext.Current.Request.Url.Scheme + "://" + System.Web.HttpContext.Current.Request.Url.Authority + "/";
                //sHost = GetCurrentContext().Request.Scheme + "://" + GetCurrentContext().Request.Path + "/";
                Host = "";
                var location = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}");
                Host = location.Scheme + "://" + location.Host + ":" + location.Port + "/";

                ViewBag.Errormsg = "";
                if(NewBanner.BannerType==1)
                {
                    bannercount = 0;
                }
                else
                {
                    bannercount = _bannermodel.BannerCount(NewBanner);
                }
              
                //bannercount = 0;
                if (bannercount <= 5)
                {
                    BannerId =_bannermodel.AddBanner(NewBanner, languageID, Host);
                    if (BannerId==0)
                    {
                        Status = false;
                        ViewBag.Errormsg = "'Unable to insert Banner Status'";
                    }
                    else
                    {
                        ViewBag.BannerId = "'" + BannerId + "'";
                        Status = true;
                    }
                }
                else
                {
                    ViewBag.Status = "'Failed'";
                    //ViewBag.Error = "'Unable to insert Banner Status'";
                    ViewBag.BannerId = "'0'";
                    ViewBag.Errormsg = "'Banner Limit exceeded'";
                    Status = false;
                }
            }
            catch (Exception e)
            {
                ViewBag.Errormsg = "'Unable to insert Banner Status'";
                Status = false;
            }

            //ViewBag.Errormsg = "'Unable to insert Banner Status'";

            TempData["Status"] = Status;
            TempData["BannerId"] = ViewBag.BannerId;
            TempData["AddNewBanner"] = 1;

            if (Status == true)
            {
                return RedirectToAction("ManageBannerNotification");
            }
            else
            {
                //TempData["NewBanner"] = JsonConvert.SerializeObject(NewBanner);

                TempData["BannerType"] = NewBanner.BannerType;
                TempData["SelectedBannerAction"] = NewBanner.SelectedBannerAction;
                TempData["Validity"] = NewBanner.Validity;
                TempData["BannerImage"] = NewBanner.BannerImage;
                TempData["SelectedCategory"] = NewBanner.BannerType;
                TempData["SelectedCategory"] = NewBanner.SelectedCategory;
                TempData["SelectedDistricts"] = NewBanner.SelectedDistricts;
                TempData["SelectedStates"] = NewBanner.SelectedStates;
                TempData["SelectedModel"] = NewBanner.SelectedModel;
                TempData["Notificationtext"] = NewBanner.Notificationtext;
                TempData["Subject"] = NewBanner.Subject;
                TempData["ActionFile"] = NewBanner.ActionFile;
                TempData["ActionTypeTarget"] = NewBanner.ActionTypeTarget;
                TempData["ActionLink"] = NewBanner.ActionLink;         

                TempData["Errormsg"] = ViewBag.Errormsg;
                return RedirectToAction("AddBannerNotification");
            }
        }


        [HttpPost]
        public IActionResult UserCount(UserCount userCount)
        {
            int Count = 0;
            try
            {


                Count = _bannermodel.GetUserList(userCount);



            }
            catch (Exception ex)
            {

            }
            return Json(new { message = "User Count : " + Count, success = true });
        }

        [HttpPost]
        public IActionResult UpdateStatus(UpdateBannerStatus Status)
        {

            string Statusmsg = "";

            Statusmsg= _bannermodel.UpdateStatus(Status);


            return Json(Statusmsg);
        }
        [HttpPost]
        public ActionResult SearchBanner(BannerModel bannerModel)
        {
           
            TempData["Search"] = 1;
            //TempData["SearchModel"] = bannerModel;

            TempData["selectedLanguage"] = bannerModel.SearchModel.selectedLanguage;
            TempData["SelectedStates"] = bannerModel.SearchModel.SelectedStates;
            TempData["SelectedBannerType"] = bannerModel.SearchModel.SelectedBannerType;
            TempData["Validity"] = bannerModel.SearchModel.Validity;            


            return RedirectToAction("ManageBannerNotification");
        }
    }
}
