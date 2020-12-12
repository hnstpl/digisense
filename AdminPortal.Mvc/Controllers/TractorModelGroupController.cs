using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminPortal.Mvc.Services;
using AdminPortal.Mvc.Models.TractorModelGroup;
using Microsoft.AspNetCore.Http;

namespace AdminPortal.Mvc.Controllers
{
    public class TractorModelGroupController : Controller
    {
        private readonly ITractorModelGroupService _tractorModelGroup;

        private readonly IGlobalService _global;

        public TractorModelGroupController(ITractorModelGroupService TractorModelGroup, IGlobalService Global)
        {
            _tractorModelGroup = TractorModelGroup;
            _global = Global;
        }

        public IActionResult Index()
        {
            return View();
        }




        [HttpGet]
        public IActionResult TractorModelGroup()
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1;
            List<TractorModelGroup> result = new List<TractorModelGroup>();

            try
            {

                List<TractorModelGroup> TractorModelGroup = _tractorModelGroup.GetByLanguageID(langid).ToList();

                result = TractorModelGroup;
                ViewBag.TractorModelGrouplist = result;
                HttpContext.Session.SetString("Dlangid", "");
                return View();

            }
            catch (Exception ex)
            {
                return View();
            }
        }


        [HttpPost]
        public IActionResult TractorModelGroup(IFormCollection formCollection)
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1; // default english
            if (formCollection.ContainsKey("cmbmglang"))
            {
                langid = Convert.ToInt32(formCollection["cmbmglang"]);
            }
            List<TractorModelGroup> result = new List<TractorModelGroup>();

            try
            {

                List<TractorModelGroup> TractorModelGroup = _tractorModelGroup.GetByLanguageID(langid).ToList();

                result = TractorModelGroup;
                ViewBag.TractorModelGrouplist = result;
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
