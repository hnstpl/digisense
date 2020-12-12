using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.HP;
using AdminPortal.Mvc.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminPortal.Mvc.Controllers
{
    public class HPController : Controller
    {

        private readonly IHPService _hp;

        private readonly IGlobalService _global;

        public HPController(IHPService HP, IGlobalService Global)
        {
            _hp = HP;
            _global = Global;
        }

        public IActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public IActionResult HPMaster()
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1;
            List<HP> result = new List<HP>();

            try
            {
                result = _hp.GetAll(langid).ToList();
                ViewBag.HPlist = result;
                HttpContext.Session.SetString("Dlangid", "");
                return View();
            }
            catch (Exception ex)
            {
                return View();
            }
        }


        [HttpPost]
        public IActionResult HPMaster(IFormCollection formCollection)
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1; // default english
            if (formCollection.ContainsKey("cmbhplang"))
            {
                langid = Convert.ToInt32(formCollection["cmbhplang"]);
            }
            List<HP> result = new List<HP>();

            try
            {
                result = _hp.GetAll(langid).ToList();
                ViewBag.HPlist = result;
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
