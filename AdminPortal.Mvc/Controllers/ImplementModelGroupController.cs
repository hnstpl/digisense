using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AdminPortal.Mvc.Models.ImplementModelGroup;
using AdminPortal.Mvc.Services;

namespace AdminPortal.Mvc.Controllers
{
    public class ImplementModelGroupController : Controller
    {
        private readonly IImplementModelGroupService _implementModelGroup;

        private readonly IGlobalService _global;


        public ImplementModelGroupController(IImplementModelGroupService ImplementModelGroup, IGlobalService Global)
        {
            _implementModelGroup = ImplementModelGroup;
            _global = Global;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ImplementModelGroup()
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1;
            List<ImplementModelGroup> result = new List<ImplementModelGroup>();

            try
            {

                List<ImplementModelGroup> ImplementModelGroup = _implementModelGroup.GetByLanguageID(langid).ToList();

                result = ImplementModelGroup;
                ViewBag.ImplementGlist = result;
                HttpContext.Session.SetString("Dlangid", "");
                return View();

            }
            catch (Exception ex)
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult ImplementModelGroup(IFormCollection formCollection)
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1; // default english
            if (formCollection.ContainsKey("cmbimglang"))
            {
                langid = Convert.ToInt32(formCollection["cmbimglang"]);
            }
            List<ImplementModelGroup> result = new List<ImplementModelGroup>();

            try
            {

                List<ImplementModelGroup> ImplementModelGroup = _implementModelGroup.GetByLanguageID(langid).ToList();

                result = ImplementModelGroup;
                ViewBag.ImplementGlist = result;
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
