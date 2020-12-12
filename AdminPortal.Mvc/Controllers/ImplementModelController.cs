using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.ImplementModel;
using AdminPortal.Mvc.Services;
using Microsoft.AspNetCore.Http;

namespace AdminPortal.Mvc.Controllers
{
    public class ImplementModelController : Controller
    {
        private readonly IImplementModelService _implementmodel;

        private readonly IGlobalService _global;

        public ImplementModelController(IImplementModelService implementmodel, IGlobalService Global)
        {
            _implementmodel = implementmodel;
            _global = Global;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ImplementModel()
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1;

            try
            {

                ViewBag.ImplementMlist = _implementmodel.GetAll(langid);
                HttpContext.Session.SetString("Dlangid", "");                
                return View();

            }
            catch (Exception ex)
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult ImplementModel(IFormCollection formCollection)
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1; // default english
            long type = 0;
            if (formCollection.ContainsKey("cmbimglang"))
            {
                langid = Convert.ToInt32(formCollection["cmbimglang"]);
            }

           
            try
            {
                ViewBag.ImplementMlist = _implementmodel.GetByType(langid);
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
