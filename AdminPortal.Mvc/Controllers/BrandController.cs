using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.Brand;
using AdminPortal.Mvc.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminPortal.Mvc.Controllers
{
    public class BrandController : Controller
    {

        private readonly IBrandService _brand;

        private readonly IGlobalService _global;


        public BrandController(IBrandService Brand, IGlobalService Global)
        {
            _brand = Brand;
            _global = Global;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Brand()
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1;
            List<Brand> result = new List<Brand>();

            try
            {
                result = _brand.GetAll(langid).ToList();
                ViewBag.Brandlist = result;
                HttpContext.Session.SetString("Dlangid", "");
                return View();

            }
            catch (Exception ex)
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Brand(IFormCollection formCollection)
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1; // default english
            if (formCollection.ContainsKey("cmbmanlang"))
            {
                langid = Convert.ToInt32(formCollection["cmbmanlang"]);
            }
            List<Brand> result = new List<Brand>();

            try
            {
                result = _brand.GetAll(langid).ToList();
                ViewBag.Brandlist = result;
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
