using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminPortal.Mvc.Services;
using AdminPortal.Mvc.Models.Manufacturer;
using Microsoft.AspNetCore.Http;

namespace AdminPortal.Mvc.Controllers
{
    public class ManufacturerController : Controller
    {
        private readonly IManufacturerService _manufacturer;

        private readonly IGlobalService _global;

        public ManufacturerController(IManufacturerService Manufacturer, IGlobalService Global)
        {
            _manufacturer = Manufacturer;
            _global = Global;
        }

        public IActionResult Index()
        {
            return View();
        }


        //GET
        [HttpGet]
        public IActionResult Manufacturer()
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1;
            List<Manufacturer> result = new List<Manufacturer>();

            try
            {
                result = _manufacturer.GetAll(langid).ToList();
                ViewBag.Manufacturerlist = result;
                HttpContext.Session.SetString("Dlangid", "");
                return View();
            }
            catch (Exception ex)
            {
                return View();
            }


        }


        [HttpPost]
        public IActionResult Manufacturer(IFormCollection formCollection)
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1; // default english
            if (formCollection.ContainsKey("cmbmanlang"))
            {
                langid = Convert.ToInt32(formCollection["cmbmanlang"]);
            }
            List<Manufacturer> result = new List<Manufacturer>();

            try
            {
                result = _manufacturer.GetAll(langid).ToList();
                ViewBag.Manufacturerlist = result;
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
