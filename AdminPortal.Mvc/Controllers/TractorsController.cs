using AdminPortal.Mvc.Models.Tractors;
using AdminPortal.Mvc.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Controllers
{
    public class TractorsController : Controller
    {

        private readonly ITractorsService _tractorsmodel;

        private readonly IGlobalService _global;


        public TractorsController(ITractorsService tractorsmodel, IGlobalService Global)
        {
            _tractorsmodel = tractorsmodel;
            _global = Global;
        }
        public IActionResult ManageTractors()
        {

            TractorsMaster tractorsMaster = new TractorsMaster();
            TractorModelSearch tractorModelSearch = new TractorModelSearch();
            List<string> SelectedHP = new List<string>();
            List<string> SelectedModel = new List<string>();
            List<string> SelectedBrand = new List<string>();
            try
            { 

            int IsSearch = Convert.ToInt32(TempData["Search"]);

            if (IsSearch == 1)
            {

                    tractorModelSearch.SelectedHP = new List<string>();
                    tractorModelSearch.SelectedModel = new List<string>();
                    tractorModelSearch.SelectedBrand = new List<string>();

                    if (TempData["SelectedHP"]!=null)
                {
                        SelectedHP = ((IEnumerable<string>)TempData["SelectedHP"]).ToList();

                        tractorModelSearch.SelectedHP = SelectedHP;
                }
               
                if (TempData["SelectedModel"] != null)
                {                                                
                        SelectedModel = ((IEnumerable<string>)TempData["SelectedModel"]).ToList();
                        tractorModelSearch.SelectedModel = SelectedModel;
                       
                    }
               
                if (TempData["SelectedBrand"] != null)
                {
                        //tractorModelSearch.SelectedBrand = (List<string>)TempData["SelectedBrand"];

                        
                        SelectedBrand = ((IEnumerable<string>)TempData["SelectedBrand"]).ToList();
                        tractorModelSearch.SelectedBrand = SelectedBrand;
                    }
               
                if (TempData["selectedLanguage"] != null)
                {
                    tractorModelSearch.selectedLanguage =Convert.ToInt32(TempData["selectedLanguage"]);
                }
                else
                {
                    tractorModelSearch.selectedLanguage = 1;
                }

                ViewData["ModelList"] = tractorModelSearch.SelectedModel;
                ViewData["BrandList"] = tractorModelSearch.SelectedBrand;
                ViewData["HPList"] =    tractorModelSearch.SelectedHP;

            }


            tractorsMaster = _tractorsmodel.GetTractors(IsSearch, tractorModelSearch);


            int UpdateTractors = Convert.ToInt32(TempData["UpdateTractors"]);

            if (UpdateTractors == 1)
            {
                bool Status = false;
                if (TempData["Status"] != null)
                {
                    Status = Convert.ToBoolean(TempData["Status"]);
                }


                if (!Status)
                {
                    ViewBag.Status = "'Failed'";
                    ViewBag.Error = "'Unable to Update Tractors'";
                }
                else
                {
                    ViewBag.Status = "'Success'";
                }

            }
            else
            {
                ViewBag.Status = "'Load'";
            }
            }
            catch(Exception ex)
            {

            }
            return View(tractorsMaster);
        }
        [HttpPost]
        public ActionResult TractorSearch(TractorModelSearch tractorModelSearch)
        {
            TempData["Search"] = 1;
            //TempData["tractorModelSearch"] = tractorModelSearch;
            TempData["selectedLanguage"] = tractorModelSearch.selectedLanguage;
            TempData["SelectedModel"] = tractorModelSearch.SelectedModel;
            TempData["SelectedBrand"] = tractorModelSearch.SelectedBrand;
            TempData["SelectedHP"] = tractorModelSearch.SelectedHP;
            return RedirectToAction("ManageTractors");
        }
        [HttpGet]
        public ActionResult GetLanguages4Video(int VideoId)
        {
            List<VideoLanguages> videolanguagelist = new List<VideoLanguages>();
            videolanguagelist = _tractorsmodel.Languages4Video(VideoId).ToList();
            return Json(videolanguagelist, new Newtonsoft.Json.JsonSerializerSettings());

        }

        [HttpGet]
        public ActionResult GetVideoList(int CategoryId)
        {
            List<DIYVideosList> dIYVideosLists = new List<DIYVideosList>();
            try
            {
                dIYVideosLists =_tractorsmodel.GetDIYVideosList4Category(CategoryId).ToList();
            }
            catch (Exception ex)
            {
            }

            return Json(dIYVideosLists, new Newtonsoft.Json.JsonSerializerSettings());

        }
        public ActionResult TractorConfigSearch(UpdateTractorDetails updateTractorDetails)
        {
            string ModelCode = "";
            int LanguageCode = 0;
            try
            {
                ModelCode = updateTractorDetails.tractorConfiguration.Modelcode;
                LanguageCode = updateTractorDetails.selectedLanguage;
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("UpdateTractors", new { ModelId = ModelCode, LanguageId = LanguageCode });
        }
        public ActionResult UpdateTractors(string ModelId, int LanguageId = 0)
        {
          

            UpdateTractorDetails updateTractorDetails = new UpdateTractorDetails();
            try
            { 
            updateTractorDetails = _tractorsmodel.GetUpdateTractorDetails(ModelId, LanguageId);

             ViewData["Language4UserManual"] = updateTractorDetails.tractorConfiguration.Language4UserManual;
            ViewData["Language4Brochure"] = updateTractorDetails.tractorConfiguration.Language4Brochure;

            int UpdateTractors = Convert.ToInt32(TempData["UpdateTractors"]);

            if (UpdateTractors == 1)
            {
                bool Status = false;
                if (TempData["Status"] != null)
                {
                    Status = Convert.ToBoolean(TempData["Status"]);
                }


                if (!Status)
                {
                    ViewBag.Status = "'Failed'";
                    ViewBag.Error = "'Unable to Update Tractors'";
                }
                else
                {
                    ViewBag.Status = "'Success'";
                }

            }
            else
            {
                ViewBag.Status = "'Load'";
            }

            }
            catch(Exception ex)
            {

            }

            return View(updateTractorDetails);
        }

        [HttpPost]
        public ActionResult TractorConfiguration(TractorConfiguration tractorConfiguration)
        {
            string Host = "";
            bool Updated = false;
            try
            {

                var location = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}");
                Host = location.Scheme + "://" + location.Host + ":" + location.Port + "/";


                Updated = _tractorsmodel.UpdateTractorConfiguration(tractorConfiguration, Host);

        
                TempData["Status"] = true;
                TempData["UpdateTractors"] = Updated;
            }

            catch (Exception ex)
            {
                TempData["Status"] = true;
                TempData["UpdateTractors"] = Updated;

            }
            return RedirectToAction("ManageTractors");
        }
    }
}
