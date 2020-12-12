using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using AdminPortal.Mvc.Models.ImplementSuitability;
using AdminPortal.Mvc.Services;
using Microsoft.AspNetCore.Http;


namespace AdminPortal.Mvc.Controllers
{
    public class ImplementSuitabilityController : Controller
    {

        private readonly IImplementSuitability _ImplementSuitability;

        private readonly IGlobalService _global;

        public ImplementSuitabilityController(IImplementSuitability ImplementSuitability, IGlobalService Global)
        {
            _ImplementSuitability = ImplementSuitability;
            _global = Global;
        }

        // GET: ImplementSuitability
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ImplementSuitability()
        {
            ViewBag.Tractorlist = _ImplementSuitability.GetTractordata();
            ViewBag.Brandlist = _ImplementSuitability.GetBrandList();
            ViewBag.Implementlist = _ImplementSuitability.GetImplementdata();
            string Tractorcode = string.Empty;
            if (HttpContext.Session.GetString("AssignImplementFlag") != null)
            { 
                 Tractorcode = HttpContext.Session.GetString("AssignImplementFlag").ToString();
            }
            
            ViewBag.AvailImplementlist = _ImplementSuitability.GetAvailableImplementdata(Tractorcode);
            ViewBag.AssignImplementlist = _ImplementSuitability.GetAssignedImplementdata(Tractorcode);
            ViewBag.TractorBList = null;

            HttpContext.Session.SetString("Tractorcode", "");
            HttpContext.Session.SetString("Implementcode", "");
            HttpContext.Session.SetString("Type", "");
            HttpContext.Session.SetString("Brand", "");
            HttpContext.Session.SetString("Status", "");
            HttpContext.Session.SetString("SelectioninsertType", "");

            return View();
        }


        [HttpPost]
        public IActionResult ImplementSuitability(IFormCollection formCollection)
        {
            try
            {
                string SelectionType = formCollection["hdnType"].ToString();
                string SelectioninsertType = formCollection["hdninsertType"].ToString();
                string Brandcode = formCollection["cmbbrand"].ToString();
                string Tractorcode = "0";
                string user = HttpContext.Session.GetString("User");

                ViewBag.Tractorlist = _ImplementSuitability.GetTractordata();
                if (SelectioninsertType == "3" && Brandcode != "0")
                {
                    ViewBag.Tractorlist = _ImplementSuitability.GetTractorDataByBrand(Brandcode);
                }
                ViewBag.Implementlist = _ImplementSuitability.GetImplementdata();
                ViewBag.Brandlist = _ImplementSuitability.GetBrandList();
                ViewBag.TractorBList = null;
                if (formCollection.ContainsKey("cmbTractor"))
                {
                    Tractorcode = formCollection["cmbTractor"].ToString();
                }
                
                string[] AssignedImplementArr = null;
                string[] TractorArr = null;
                
                ViewBag.AvailImplementlist = _ImplementSuitability.GetAvailableImplementdata(Tractorcode);
                ViewBag.AssignImplementlist = _ImplementSuitability.GetAssignedImplementdata(Tractorcode);

                if (SelectioninsertType == "1")
                {
                    if (formCollection.ContainsKey("cmbTractor"))
                    {

                      
                        ICollection<string> Tractorcodelist = new List<string>() { formCollection["cmbTractor"] };
                        TractorArr = Tractorcodelist.ToArray();
                        string[] TractorcodeArr = TractorArr[0].Split(',');
                       
                        var UpdateStatus = _ImplementSuitability.UpdateInActive(TractorcodeArr, user);


                    }

                    if (formCollection.ContainsKey("hdnSelectedImplement"))
                    {
                        ICollection<string> Tractorcodelist = new List<string>() { formCollection["cmbTractor"] };
                        TractorArr = Tractorcodelist.ToArray();
                        string[] TractorcodeArr = TractorArr[0].Split(',');

                        ICollection<string> Implementcodelist = new List<string>() { formCollection["hdnSelectedImplement"] };
                        AssignedImplementArr = Implementcodelist.ToArray();
                        string[] implemtassigncodeArr = AssignedImplementArr[0].Split(',');
                        string checkImpcode = AssignedImplementArr[0];

                        if (checkImpcode != "")
                        {

                            var AssignmentStatus = _ImplementSuitability.AddNewImplementAssignment(TractorcodeArr, implemtassigncodeArr, user);
                        }


                    }
                    HttpContext.Session.SetString("Implementcode", AssignedImplementArr[0]);
                    HttpContext.Session.SetString("Status", "Success");
                    ViewBag.AvailImplementlist = _ImplementSuitability.GetAvailableImplementdata(Tractorcode);
                    ViewBag.AssignImplementlist = _ImplementSuitability.GetAssignedImplementdata(Tractorcode);

                }

                HttpContext.Session.SetString("Tractorcode", Tractorcode);
                HttpContext.Session.SetString("Type", SelectionType);
                HttpContext.Session.SetString("Brand", Brandcode);
                HttpContext.Session.SetString("SelectioninsertType", SelectioninsertType);

                return View();
            }
            catch (Exception e)
            {
                HttpContext.Session.SetString("Status", "Failed");
                return View();
            }

        }


        [HttpPost]
        public IActionResult GetimplementDataByTractor(IFormCollection formCollection)
        {
            ViewBag.Tractorlist = _ImplementSuitability.GetTractordata();
            ViewBag.Implementlist = _ImplementSuitability.GetImplementdata();
            ViewBag.Brandlist = _ImplementSuitability.GetBrandList();
            string Tractorcode = formCollection["Tractorcode"]; ;
            ViewBag.AvailImplementlist = _ImplementSuitability.GetAvailableImplementdata(Tractorcode);
            ViewBag.AssignImplementlist = _ImplementSuitability.GetAssignedImplementdata(Tractorcode);
            HttpContext.Session.SetString("AssignImplementFlag", Tractorcode);
            //Session["AssignImplementFlag"] = Tractorcode;
            return RedirectToAction("ImplementSuitability");
        }


    }
}