using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminPortal.Mvc.Models;
using AdminPortal.Mvc.Services;
using Microsoft.Extensions.Configuration;
using AdminPortal.Mvc.DataProvider;
using Microsoft.AspNetCore.Http;
using AdminPortal.Mvc.Models.DIY;

namespace AdminPortal.Mvc.Controllers
{
    public class DIYController : Controller
    {

        private readonly IGlobalService _global;

        private readonly IDIYService _diy;


        public IConfiguration _configuration;

        public DIYController(IGlobalService Global, IDIYService DIY, IConfiguration Configuration)
        {
            _global = Global;
            _diy = DIY;
            _configuration = Configuration;
        }

        public ActionResult Index()
        {
            DIY diy = new DIY();
            SearchFilters searchFilters = new SearchFilters();

        

                int Search = Convert.ToInt32(TempData["Search"]);




                if (Search == 1)
                {
 

                    if (TempData["SelectedCategory"] != null)
                    {
                        searchFilters.SelectedCategory = Convert.ToInt32(TempData["SelectedCategory"]);
                       
                    }

                    if (TempData["SelectedLanguage"] != null)
                    {
                        searchFilters.SelectedLanguage = Convert.ToInt32(TempData["SelectedLanguage"]);

                    }

                }

                diy = _diy.GetDIYVideos(Search, searchFilters);

                ViewBag.Status = "''";
                ViewBag.message = "''";

                string Status = Convert.ToString(TempData["Status"]);

                if (Status != "")
                {
                    ViewBag.Status = "'" + Status + "'";
                    ViewBag.message = "'" + Convert.ToString(TempData["Message"]) + "'";

                }


                return View(diy);
            
        }

        [HttpGet]
        public ActionResult Add()
        {
            AddNewDIY addNewDIY = new AddNewDIY();
            try
            {
               

                    
                    int Id = Convert.ToInt32(TempData["Id"]);

                addNewDIY = _diy.AddDIYVideos(Id);


            }
            catch (Exception ex)
            {

            }
            return View(addNewDIY);
        }
        [HttpPost]
        //[ValidateInput(false)]
        public ActionResult Add(AddNewDIY input)
        {
            int VideoId = 0;
            try
            {
                VideoId = _diy.Add(input);

            }
            catch (Exception ex)
            {

            }
            TempData["Status"] = "Success";
            TempData["Message"] = "DIY Video has been Updated and Video ID is " + input.VideoID + ".";
            return RedirectToAction("Index", "DIY");
        }
        [HttpPost]
        public JsonResult GenerateVideoID(int CategoryID)
        {
            try
            {

                return Json(_diy.GetVideoID(CategoryID));
                    //if (Result > 0)
                    //{
                        //return Json(Record);
                    //}
                    //else
                    //{
                       // throw new InvalidOperationException("Error while generating video ID");
                    //}                
            }
            catch (Exception e)
            {
                return Json(e);
            }

        }



        public ActionResult ApplyFilters(DIY input)
        {            
            try
            {                
                TempData["Search"] = 1;                
                TempData["SelectedCategory"] = input.searchFilters.SelectedCategory;
                TempData["SelectedLanguage"] = input.searchFilters.SelectedLanguage;
                         
            }
            catch (Exception ex)
            {

            }
            //return View("Index", input);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult SaveDiYVideo()
        {                    
            string FileName4Video = "";
            string VideoURL = "";
            int VideoId = 0;            
            int IsUpdate = 0;
            int LanguageId = 0;
            string Host = "";
            try
            {

                VideoId = Convert.ToInt32(Request.Form["VideoId"]);
                //OrderId= Convert.ToInt32(Request["OrderId"]);
                IsUpdate = Convert.ToInt32(Request.Form["IsUpdate"]);
                LanguageId = Convert.ToInt32(Request.Form["LanguageId"]);
                VideoURL = Convert.ToString(Request.Form["VideoURL"]);

                if (VideoURL == "")
                {

                    var location = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}");
                    Host = location.Scheme + "://" + location.Host + ":" + location.Port + "/";

                    FileName4Video = VideoId + "_TpdhVideo";
                    if (IsUpdate == 1)
                    {
                        FileName4Video = VideoId + "_TpdhVideo_" + LanguageId;
                    }


               
                        IFormFile DIYVideo = Request.Form.Files[0];
                   

                    VideoURL =_diy.GetVideoURL(VideoId,IsUpdate,LanguageId, Host,DIYVideo, FileName4Video);
                }
                return Json(new { VideoURL = VideoURL });
            }
            catch (Exception ex)
            {
                return Json(new { message = ex.Message, Success = true }, new Newtonsoft.Json.JsonSerializerSettings());
            }
        }

        public IActionResult Edit(int Id)
        {
            TempData["Id"] = Id;
            return RedirectToAction("Add");
        }
    }
}
