using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Services;
using Microsoft.AspNetCore.Mvc;
using AdminPortal.Mvc.Models.SpecificationCategory;
using Microsoft.AspNetCore.Http;

namespace AdminPortal.Mvc.Controllers
{
    public class SpecificationCategoryController : Controller
    {
        private readonly ISpecificationCategoryService _specificationCategory;

        private readonly IGlobalService _global;


        public SpecificationCategoryController(ISpecificationCategoryService SpecificationCategory, IGlobalService Global)
        {
            _specificationCategory = SpecificationCategory;
            _global = Global;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SpecificationCategory()
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1;
            List<SpecificationCategory> result = new List<SpecificationCategory>();

            try
            {
                result = _specificationCategory.GetAll(langid).ToList();
                ViewBag.SpecCatlist = result;
                HttpContext.Session.SetString("Dlangid", "");
                return View();

            }
            catch (Exception ex)
            {
                return View();
            }
        }


        [HttpPost]
        public IActionResult SpecificationCategory(IFormCollection formCollection)
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1; // default english
            if (formCollection.ContainsKey("cmbimglang"))
            {
                langid = Convert.ToInt32(formCollection["cmbimglang"]);
            }
            List<SpecificationCategory> result = new List<SpecificationCategory>();

            try
            {
                result = _specificationCategory.GetAll(langid).ToList();
                ViewBag.SpecCatlist = result;
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
