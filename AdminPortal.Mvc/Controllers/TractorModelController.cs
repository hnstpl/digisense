using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.TractorModel;
using AdminPortal.Mvc.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminPortal.Mvc.Controllers
{
    public class TractorModelController : Controller
    {
        private readonly ITractorModelService _tractorModel;

        private readonly IGlobalService _global;


        public TractorModelController(ITractorModelService TractorModel, IGlobalService Global)
        {
            _tractorModel = TractorModel;
            _global = Global;
        }


        public IActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public IActionResult TractorModel()
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1;
            List<TractorModel> result = new List<TractorModel>();

            try
            {

                List<TractorModel> TractorModel = _tractorModel.GetByLanguageID(langid).ToList();

                result = TractorModel;
                ViewBag.TractorModellist = result;
                HttpContext.Session.SetString("Dlangid", "");
                return View();

            }
            catch (Exception ex)
            {
                return View();
            }
        }



        [HttpPost]
        public IActionResult TractorModel(IFormCollection formCollection)
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1; // default english
            if (formCollection.ContainsKey("cmbtmlang"))
            {
                langid = Convert.ToInt32(formCollection["cmbtmlang"]);
            }
            List<TractorModel> result = new List<TractorModel>();

            try
            {

                List<TractorModel> TractorModel = _tractorModel.GetByLanguageID(langid).ToList();

                result = TractorModel;
                ViewBag.TractorModellist = result;
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
