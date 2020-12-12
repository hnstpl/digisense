using AdminPortal.Mvc.Models.Implements;
using AdminPortal.Mvc.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Controllers
{
    public class ImplementsController : Controller
    {

        private readonly IImplementsService _implements;

        private readonly IGlobalService _global;


        public ImplementsController(IImplementsService implements, IGlobalService Global)
        {
            _implements = implements;
            _global = Global;
        }
        public ActionResult ManageImplements()
        {

            ImplementMaster implementMaster = new ImplementMaster();

            ImplementModelSearch implementModelSearch = new ImplementModelSearch ();
            List<string> SelectedCategory = new List<string>();
       

            int IsSearch = Convert.ToInt32(TempData["Search"]);
            if (IsSearch == 1)
            {

               
                    implementModelSearch.SelectedCategory = new List<string>();
              
                    if (TempData["SelectedCategory"] != null)
                    {
                     SelectedCategory = ((IEnumerable<string>)TempData["SelectedCategory"]).ToList();

                        implementModelSearch.SelectedCategory = SelectedCategory;
                    }                 

                    if (TempData["selectedLanguage"] != null)
                    {
                    implementModelSearch.selectedLanguage = Convert.ToInt32(TempData["selectedLanguage"]);
                    }
                    else
                    {
                    implementModelSearch.selectedLanguage = 1;
                    }

                    ViewData["SelectedCategory"] = implementModelSearch.SelectedCategory;           
                
                
            }
                implementMaster = _implements.GetImplementMaster(IsSearch, implementModelSearch);


            int UpdateImplements = Convert.ToInt32(TempData["UpdateImplements"]);

            if (UpdateImplements == 1)
            {
                bool Status = false;
                if (TempData["Status"] != null)
                {
                    Status = Convert.ToBoolean(TempData["Status"]);
                }


                if (!Status)
                {
                    ViewBag.Status = "'Failed'";
                    ViewBag.Error = "'Unable to Update Implements'";
                }
                else
                {
                    ViewBag.Status = "'Success'";
                }

            }
            else
            {
                ViewBag.Status = "'Load'";
            }

            return View(implementMaster);
        }
        [HttpPost]
        public ActionResult UpdateImplementsConfiguration(ImplementConfiguration implementConfiguration)
        {
            string Host = "";
            bool Updated = false;
            try
            {


                var location = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}");
                Host = location.Scheme + "://" + location.Host + ":" + location.Port + "/";


                Updated = _implements.UpdateImplementConfigDetails(implementConfiguration, Host);

                TempData["Status"] = Updated;
                TempData["UpdateImplements"] = 1;

            }
            catch (Exception ex)
            {
                TempData["Status"] = false;
                TempData["UpdateImplements"] = 1;
            }
            return RedirectToAction("ManageImplements");
        }
        [HttpPost]
        public ActionResult ImplementSearch(ImplementModelSearch implementModelSearch)
        {            
            TempData["Search"] = 1;           
            TempData["selectedLanguage"] = implementModelSearch.selectedLanguage;
            TempData["SelectedCategory"] = implementModelSearch.SelectedCategory;
            return RedirectToAction("ManageImplements");
        }

        public ActionResult ImplementConfigSearch(UpdateImplementsDetails updateImplementsDetails)
        {
            string ModelCode = "";
            int LanguageCode = 0;
            try
            {
                ModelCode = updateImplementsDetails.implementConfiguration.Modelcode;
                LanguageCode = updateImplementsDetails.selectedLanguage;
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("UpdateImplementDetails", new { ModelId = ModelCode, LanguageId = LanguageCode });
        }
        [HttpGet]
        public ActionResult UpdateImplementDetails(string ModelId, int LanguageId)
        {
         
            UpdateImplementsDetails updateImplementsDetails = new UpdateImplementsDetails();
            try
            {
                updateImplementsDetails = _implements.GetUpdateImplementDetails(ModelId, LanguageId);
            }
            catch(Exception ex)
            {

            }
            return View(updateImplementsDetails);
        }
    }
}
