using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Services;
using Microsoft.AspNetCore.Mvc;
using AdminPortal.Mvc.Models.VideoCategory;
using Microsoft.AspNetCore.Http;

namespace AdminPortal.Mvc.Controllers
{
    public class VideoCategoryController : Controller
    {
        private readonly IVideoCategoryService _videoCategory;

        private readonly IGlobalService _global;

        public VideoCategoryController(IVideoCategoryService VideoCategory, IGlobalService Global)
        {
            _videoCategory = VideoCategory;
            _global = Global;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult VideoCategory()
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1;
            List<VideoCategory> result = new List<VideoCategory>();

            try
            {
                result = _videoCategory.GetAll(langid).ToList();
                ViewBag.VideoCatlist = result;
                HttpContext.Session.SetString("Dlangid", "");
                return View();
            }
            catch (Exception ex)
            {
                return View();
            }
        }


        [HttpPost]
        public ActionResult VideoCategory(IFormCollection formCollection)
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1; // default english
            if (formCollection.ContainsKey("cmbimglang"))
            {
                langid = Convert.ToInt32(formCollection["cmbimglang"]);
            }
            List<VideoCategory> result = new List<VideoCategory>();

            try
            {
                result = _videoCategory.GetAll(langid).ToList();
                ViewBag.VideoCatlist = result;
                HttpContext.Session.SetString("Dlangid", langid.ToString());
                return View();

            }
            catch (Exception ex)
            {
                return View();
            }


        }
    }
}
