using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.TipofCatgeory;
using AdminPortal.Mvc.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminPortal.Mvc.Controllers
{
    public class TipofCatgeoryController : Controller
    {


        private readonly ITipofCatgeoryService _tipofCategory;

        private readonly IGlobalService _global;

        public TipofCatgeoryController(ITipofCatgeoryService TipofCategory, IGlobalService Global)
        {
            _tipofCategory = TipofCategory;
            _global = Global;
        }

        public IActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public IActionResult TipofCatgeory()
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1;
            List<TipofCatgeory> result = new List<TipofCatgeory>();

            try
            {
                result = _tipofCategory.GetAll(langid).ToList();
                ViewBag.TipofCatgeorylist = result;
                HttpContext.Session.SetString("Dlangid", "");
                return View();
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult TipofCatgeory(IFormCollection formCollection)
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1; // default english
            if (formCollection.ContainsKey("cmblang"))
            {
                langid = Convert.ToInt32(formCollection["cmblang"]);
            }
            List<TipofCatgeory> result = new List<TipofCatgeory>();

            try
            {
                result = _tipofCategory.GetAll(langid).ToList();
                ViewBag.TipofCatgeorylist = result;
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
