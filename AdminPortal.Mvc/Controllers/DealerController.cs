using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminPortal.Mvc.Models.Dealer;
using AdminPortal.Mvc.Services;
using Microsoft.AspNetCore.Http;

namespace AdminPortal.Mvc.Controllers
{
    public class DealerController : Controller
    {
        private readonly IDealerService _dealer;

        private readonly IGlobalService _global;

        public DealerController(IDealerService Dealer, IGlobalService Global)
        {
            _dealer = Dealer;
            _global = Global;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DealerMaster()
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1;

            try
            {

                ViewBag.Dealerlist = _dealer.GetAll(langid);
                HttpContext.Session.SetString("Dlangid", "");
                HttpContext.Session.SetString("type", "0");
                return View();

            }
            catch (Exception ex)
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult DealerMaster(IFormCollection formCollection)
        {
            ViewBag.LangListItem = _global.GetLanguagedata();
            int langid = 1; // default english
            long type = 0;
            if (formCollection.ContainsKey("cmblang"))
            {
                langid = Convert.ToInt32(formCollection["cmblang"]);
            }

            if (formCollection.ContainsKey("cmbtype"))
            {
                type = Convert.ToInt64(formCollection["cmbtype"]);
            }

            try
            {
                ViewBag.Dealerlist = _dealer.GetByType(langid, (int)type);
                HttpContext.Session.SetString("Dlangid", langid.ToString());
                HttpContext.Session.SetString("type", type.ToString());
                return View();

            }
            catch (Exception ex)
            {
                return View();
            }


        }

        [HttpPost]
        public ContentResult Updatedealer(IFormCollection formCollection)
        {
            string message = "sucess";
            try
            {

                int langid = Convert.ToInt32(formCollection["langid"]);
                string dealercode = formCollection["dealercode"];
                string branccode = formCollection["branchcode"];
                //  string zone = formCollection["zone"];
                string active = formCollection["active"];
                int languagecode = Convert.ToInt32(formCollection["languagecode"]);
                string user = HttpContext.Session.GetString("User");

                var UpdateStatus = _dealer.UpdateByID(dealercode, user, active, languagecode, branccode);

                return Content(message);
            }
            catch (Exception e)
            {
                message = "error";
                return Content(message);
            }


        }

    }
}
