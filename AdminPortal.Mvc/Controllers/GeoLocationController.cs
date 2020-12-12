using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.GlobalProvider;
using AdminPortal.Mvc.Services;
using Microsoft.AspNetCore.Http;

namespace AdminPortal.Mvc.Controllers
{
    public class GeoLocationController : Controller
    {
        private readonly IGeoLocationService _geoLocation;

        private readonly IGlobalService _global;

        public GeoLocationController(IGeoLocationService GeoLocation, IGlobalService Global)
        {
            _geoLocation = GeoLocation;
            _global = Global;
        }

        public IActionResult Index()
        {
            return View();
        }

        private dev_encrypted_generalcustomerappContext db = new dev_encrypted_generalcustomerappContext();
        // GET: GeoLocation

        //GET
        [HttpGet]
        public IActionResult GeoMaster()
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1;
            ViewBag.StateListItem = _geoLocation.GetAllStates(langid);
            ViewBag.DistrictListItem = _geoLocation.GetAllDistricts(langid);
            ViewBag.TehsilListItem = _geoLocation.GetAllTehsils(langid);
            HttpContext.Session.SetString("langid", "");
            return View();
        }



        //POST
        [HttpPost]
        public ActionResult GeoMaster(IFormCollection formCollection)
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1; // default english
            if (formCollection.ContainsKey("cmblang"))
            {
                langid = Convert.ToInt32(formCollection["cmblang"]);
            }

            ViewBag.StateListItem = _geoLocation.GetAllStates(langid);
            ViewBag.DistrictListItem = _geoLocation.GetAllDistricts(langid);
            ViewBag.TehsilListItem = _geoLocation.GetAllTehsils(langid);
            HttpContext.Session.SetString("langid", langid.ToString());
            return View();
        }

    }
}
