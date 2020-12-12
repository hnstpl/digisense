using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Services;
using Microsoft.AspNetCore.Mvc;
using AdminPortal.Mvc.Models.Global;
using Microsoft.AspNetCore.Http;
using AdminPortal.Mvc.Models.Language;

namespace AdminPortal.Mvc.Controllers
{
    public class LanguageController : Controller
    {
        private readonly IGlobalService _global;

        public LanguageController(IGlobalService Global)
        {
            _global = Global;
        }

        public IActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public ActionResult Language()
        {
            List<LanguageInfo> result = new List<LanguageInfo>();

            try
            {
                result = _global.GetLanguageAlldata().ToList();
                ViewBag.Languagelist = result;
                HttpContext.Session.SetString("Dlangid", "");

                

                return View();

            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}
