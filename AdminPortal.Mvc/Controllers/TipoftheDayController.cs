using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminPortal.Mvc.Services;
using AdminPortal.Mvc.Models.TipoftheDay;
using Microsoft.AspNetCore.Mvc.Rendering;
using AdminPortal.Mvc.DataProvider;
using Microsoft.Extensions.Configuration;
using AdminPortal.Mvc.Extensions;
using Microsoft.AspNetCore.Http;

namespace AdminPortal.Mvc.Controllers
{
    public class TipoftheDayController : Controller
    {
        private readonly IGlobalService _global;

        private readonly ITipoftheDay _tipoftheday;

        private readonly IGeoLocationService _geolocation;


        public IConfiguration _configuration { get; }

        public TipoftheDayController(IGlobalService Global, ITipoftheDay TipoftheDay, IGeoLocationService GeoLocation, IConfiguration configuration)
        {
            _global = Global;
            _tipoftheday = TipoftheDay;
            _geolocation = GeoLocation;
            _configuration = configuration;
        }

        //GET Tips
        public IActionResult Index()
        {
            return View();
        }

        //Get Tips
        public IActionResult ManageTipoftheDay()
        {
            var languages = _global.GetLanguageAlldata().ToList();

            //Default Language is English == 1
            var tipCategoryList = _tipoftheday.GetCategoryByLanguageID(1).ToList();

            var statesList = _geolocation.GetAllStates(1).ToList();

            var districtList = _geolocation.GetAllDistricts(1).ToList();

            var tipModel = _tipoftheday.GetTipoftheDayModel(1);

            var tipData = _tipoftheday.GetByLanguageID(1, 0, false, null, null);

            //Assign Viewbag properties
            ViewBag.TipsList = tipData;
            ViewBag.Status = "'Load'";
            ViewBag.TipID = "'0'";
            ViewBag.DataCount = tipData.Count();

            return View(tipModel);
        }

        //POST
        [HttpPost]
        public IActionResult ManageTipoftheDay(TipoftheDayModel tip)
        {
            try
            {
                var languages = _global.GetLanguagedata().ToList();

                var submitFlag = Request.Form["NewTipSubmit"].ToString();

                int languageID = tip.searchFilters.SelectedLanguage; //Convert.ToInt32(Request.Form["Languagelist"]);

                Boolean insertStatus = false;

                //If submitted add new tip
                if (!string.IsNullOrEmpty(submitFlag))
                {
                    int? NewTipID = null;

                    insertStatus = _tipoftheday.BuildAndAddNewTip(tip, ref NewTipID);

                    if (!insertStatus && ViewBag.Status == null)
                    {
                        ViewBag.Status = "'Failed'";
                        ViewBag.Error = "'Unable to insert New Tip'";
                    }
                    else if (ViewBag.Status == null)
                    {
                        tip.NewTip.TipText = null;
                        tip.NewTip.TipTitle = null;
                        tip.NewTip.SelectedCategory = 0;
                        //tip.NewTip.SelectedDistricts = 0;
                        //tip.NewTip.SelectedStates = 0;
                        ViewBag.Status = "'Success'";
                        ViewBag.TipID = "'" + NewTipID + "'";
                        ModelState.Clear();
                    }
                }

                var tipCategoryList = _tipoftheday.GetCategoryByLanguageID(languageID).ToList();

                var statesList = _geolocation.GetAllStates(languageID);

                var districtList = _geolocation.GetAllDistricts(languageID);

                //Build model
                TipoftheDayModel tipModel = _tipoftheday.GetTipoftheDayModel(languageID);

                //Date Manipulation
                var Dates = tip.searchFilters.SelectedDateRange.Split('-');

                DateTime? fromDate = _global.ConvertStringtoDatetime(Dates[0]);
                DateTime? toDate = _global.ConvertStringtoDatetime(Dates[1]);

                if (fromDate == null || toDate == null)
                {
                    return View();
                }

                List<TipoftheDayData> tipData = _tipoftheday.GetByLanguageID(languageID, tip.searchFilters.SelectedCategory, !string.IsNullOrEmpty(submitFlag), fromDate, toDate).ToList();

                tipData.ForEach(x => { if (x.validthru.Value.Date < DateTime.Now.Date) { x.status = "E"; } });

                ViewBag.TipsList = tipData;
                if (string.IsNullOrEmpty(ViewBag.TipID))
                {
                    ViewBag.TipID = "'0'";
                }
                ViewBag.DataCount = tipData.Count();

                if (string.IsNullOrEmpty(ViewBag.Status))
                {
                    ViewBag.Status = "''";
                }

                return View(tipModel);

            }
            catch (Exception e)
            {
                ViewBag.Status = "'Failed'";
                ViewBag.Error = "'Somthing went wrong!'";
                return View();
            }

        }


        [HttpPost]
        public JsonResult ChangeTipStatus(ChangeTipStatusData input)
        {
            try
            {
                var status = string.Empty;

                if (input.TipStatus == 0)
                {
                    status = "I";
                }
                else
                {
                    status = "A";
                }

                var isChanged = _tipoftheday.ChangeStatusByID(input.TipID, status);

                if (isChanged) return Json("Success");
                else return Json("Faled");
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }
    }
}
