using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.Implements;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Services
{
    public class ImplementsService:IImplementsService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        private readonly IGlobalService _global;


        private string VirtualPath4Model = "";
        private string VirtualPath4Thump = "";
        
        private string ActualPath4Model = "";
        private string ActualPath4Thump = "";

        private string DefaultModelImage = "";




        public IConfiguration _configuration { get; }
        public ImplementsService(dev_encrypted_generalcustomerappContext Context, IConfiguration configuration, IGlobalService Global)
        {
            _context = Context;
            _global = Global;
            _configuration = configuration;
            VirtualPath4Model = _configuration.GetValue<string>("Implements:VirtualPath4IpdhModel");
            VirtualPath4Thump = _configuration.GetValue<string>("Implements:VirtualPath4IpdhThump");            
            ActualPath4Model = _configuration.GetValue<string>("Implements:ActualPath4IpdhModel");
            ActualPath4Thump = _configuration.GetValue<string>("Implements:ActualPath4IpdhThump");


        }
        public ImplementMaster GetImplementMaster(int IsSearch, ImplementModelSearch implementModelSearch)
        {


            var languages = _global.GetLanguagedata().ToList();

            ImplementMaster implementMaster = new ImplementMaster();

            
            if (IsSearch == 1)
            {
                implementMaster.implementModelSearch = new ImplementModelSearch();
                implementMaster.implementModelSearch = implementModelSearch;
                implementMaster.implementModelSearch.ModelCategoryList = new SelectList(GetCategoryList(), "IGCode_VC", "IGName_VC");
                implementMaster.implementModelSearch.LanguageList = new SelectList(languages, "Languageid", "Languagename");                
                implementMaster.ImplementData = GetImplementModelListBySearch(implementModelSearch.selectedLanguage, implementModelSearch.SelectedCategory).ToList();
            }
            else
            {
                implementMaster.implementModelSearch = new ImplementModelSearch();
                implementMaster.implementModelSearch.ModelCategoryList = new SelectList(GetCategoryList(), "IGCode_VC", "IGName_VC");
                implementMaster.implementModelSearch.LanguageList = new SelectList(languages, "Languageid", "Languagename");
                implementMaster.implementModelSearch.selectedLanguage = 1;
                implementMaster.ImplementData = GetImplementModelList(implementMaster.implementModelSearch.selectedLanguage).ToList();
            }


            return implementMaster;
        }


        public IEnumerable<Implements> GetImplementModelListBySearch(int languageID, List<string> SelectedCategory)
        {
          
                List<Implements> implements = new List<Implements>();
            try
            { 
                var ModelsList = (from p in _context.MstIpdhModel
                                  join o in _context.MstIpdhModelLang on p.ModelcodeVc equals o.ModelcodeVc              
                                  where o.MstLangId == languageID
                                  //&& (CategoryId == 0 || p.ImplementCategory_ID == CategoryId)
                                  && (SelectedCategory.Count == 0 || SelectedCategory.Contains(p.IgcodeVc))
                                  select new Implements
                                  {
                                      ModelCode = o.ModelcodeVc,
                                      ModelName = o.ModelnameVc,
                                      ModelImage = (p.ImagePathVc == null ? "" : p.ImagePathVc),
                                      LanguageId = languageID

                                      //CategoryId=Convert.ToInt32(p.ImplementCategory_ID),
                                      //CategoryName=o1.ImpCategoryName
                                  }).ToList();

                foreach (var item in ModelsList)
                {
                    Implements implement = new Implements();
                    implement.ModelCode = item.ModelCode;
                    implement.ModelName = item.ModelName;
                    implement.LanguageId = item.LanguageId;
                    implement.DefaultModelImage = DefaultModelImage;

                    if (string.IsNullOrEmpty(item.ModelImage) == true)
                    {
                        implement.ModelImage = "";
                    }
                    else
                    {                        
                        implement.ModelImage = item.ModelImage;
                    }
                    implements.Add(implement);
                }
            }
            catch(Exception ex)
            {

            }
                return implements;


            
        }

        public IEnumerable<ImpCategory> GetCategoryList(int LanguageID = 1)
        {
            List<ImpCategory> ImpCategoryList = new List<ImpCategory>();
            try
            { 
            ImpCategoryList = (from p in _context.MstIpdhModelgroup
                                       join o in _context.MstIpdhModelgroupLang on p.IgcodeVc equals o.IgcodeVc
                                       where p.ActiveFlagC == "A"
                                       && o.ActiveflagC == "A"
                                       && o.MstLangId == LanguageID
                                       select new ImpCategory
                                       {
                                           IGCode_VC = o.IgcodeVc,
                                           IGName_VC = o.IgnameVc
                                       }).ToList();
            }
            catch(Exception ex)
            {

            }
                return ImpCategoryList;
            

        }

        public IEnumerable<Implements> GetImplementModelList(int languageID, int CategoryId = 0)
        {
        
                List<Implements> implements = new List<Implements>();
            try
            { 
                var ModelsList = (from p in _context.MstIpdhModel
                                  join o in _context.MstIpdhModelLang on p.ModelcodeVc equals o.ModelcodeVc 
                                  where o.MstLangId == languageID
                                  && (CategoryId == 0 || p.ImplementCategoryId == CategoryId)
                                  select new Implements
                                  {
                                      ModelCode = o.ModelcodeVc,
                                      ModelName = o.ModelnameVc,
                                      ModelImage = (p.ImagePathVc == null ? "" : p.ImagePathVc),
                                      LanguageId = languageID

                                      //CategoryId=Convert.ToInt32(p.ImplementCategory_ID),
                                      //CategoryName=o1.ImpCategoryName
                                  }).ToList();

                foreach (var item in ModelsList)
                {
                    Implements implement = new Implements();
                    implement.ModelCode = item.ModelCode;
                    implement.ModelName = item.ModelName;
                    implement.LanguageId = item.LanguageId;
                    implement.DefaultModelImage = DefaultModelImage;

                    if (string.IsNullOrEmpty(item.ModelImage) == true)
                    {
                        implement.ModelImage = "";
                    }
                    else
                    {
                        //implement.ModelImage = ModelImagePath + item.ModelImage.Substring(item.ModelImage.LastIndexOf("/") + 1);
                        implement.ModelImage = item.ModelImage;
                    }
                    implements.Add(implement);
                }
            }
            catch(Exception ex)
            {

            }
                return implements;


            
        }
        public Boolean UpdateImplementConfigDetails(ImplementConfiguration implementConfiguration, string Host)
        {
            string ActualThumpImagePath = "";
            string ActualModelImagePath = "";
            string ThumpImageName = "";
            string ModelImageName = "";
            bool UpdateStatus = false;
            try
            {
              

                
                MstIpdhModel mst_Ipdh_Model = _context.MstIpdhModel.Single(x => x.ModelcodeVc == implementConfiguration.Modelcode);

                if (!string.IsNullOrEmpty(implementConfiguration.SelectedIGCode_VC))
                {
                    mst_Ipdh_Model.IgcodeVc = implementConfiguration.SelectedIGCode_VC;
                }



                if (implementConfiguration.ModelImageUpdated == 1)
                {
                    if (string.IsNullOrEmpty(implementConfiguration.ImageURL) == false)
                    {

                        if (mst_Ipdh_Model.ImagePathVersion == null)
                        {
                            mst_Ipdh_Model.ImagePathVersion = 1;
                        }
                        else
                        {
                            mst_Ipdh_Model.ImagePathVersion = mst_Ipdh_Model.ImagePathVersion + 1;
                        }

                        string FileName4Model = implementConfiguration.Modelcode + "_IpdhModel_" + mst_Ipdh_Model.ImagePathVersion + ".png";
                        string ActualModelImageName = "";

                        if (mst_Ipdh_Model.ImagePathVc != null)
                        {
                            ModelImageName = mst_Ipdh_Model.ImagePathVc.Substring(mst_Ipdh_Model.ImagePathVc.LastIndexOf("/") + 1);
                           

                            var fullpath = Path.Combine(Path.GetFullPath(VirtualPath4Model).Replace("~\\", ""));
                            ActualModelImagePath = fullpath + ModelImageName;
                        }


                        //ActualModelImageName = UploadImage(implementConfiguration.ModelImage, FileName4Model, VirtualPath);
                        ActualModelImageName = _global.SaveImage(implementConfiguration.ImageURL, VirtualPath4Model, FileName4Model);


                        //mst_Ipdh_Model.ImagePath_VC = ModelImagePath + ActualModelImageName;
                        mst_Ipdh_Model.ImagePathVc = Host + ActualPath4Model + ActualModelImageName;

                        mst_Ipdh_Model.ModifieddtD = DateTime.Now;

                        if (System.IO.File.Exists(ActualModelImagePath))
                        {
                            System.IO.File.Delete(ActualModelImagePath);
                        }
                    }
                    else
                    {
                        mst_Ipdh_Model.ImagePathVc = "";
                    }
                }


                if (implementConfiguration.ThumpImageUpdated == 1)
                {
                    if (string.IsNullOrEmpty(implementConfiguration.ThumpImageURL) == false)
                    {
                        if (mst_Ipdh_Model.ThumpImageVersion == null)
                        {
                            mst_Ipdh_Model.ThumpImageVersion = 1;
                        }
                        else
                        {
                            mst_Ipdh_Model.ThumpImageVersion = mst_Ipdh_Model.ThumpImageVersion + 1;
                        }

                        string FileNamethump = implementConfiguration.Modelcode + "_IpdhThump_" + mst_Ipdh_Model.ThumpImageVersion + ".png";
                        string ActualThumpImageName = "";


                        if (mst_Ipdh_Model.ThumpImage != null)
                        {
                            ThumpImageName = mst_Ipdh_Model.ThumpImage.Substring(mst_Ipdh_Model.ThumpImage.LastIndexOf("/") + 1);
                            //ActualThumpImagePath = Server.MapPath(VirtualPath4Thump) + ThumpImageName;

                            var fullpath1 = Path.Combine(Path.GetFullPath(VirtualPath4Thump).Replace("~\\", ""));
                            ActualThumpImagePath = fullpath1 + ThumpImageName;
                        }


                        //ActualModelImageName = UploadImage(implementConfiguration.ModelImage, FileName4Model, VirtualPath);
                        ActualThumpImageName = _global.SaveImage(implementConfiguration.ThumpImageURL, VirtualPath4Thump, FileNamethump);

                        //mst_Ipdh_Model.ImagePath_VC = ModelImagePath + ActualModelImageName;
                        mst_Ipdh_Model.ThumpImage = Host + ActualPath4Thump + ActualThumpImageName;

                        mst_Ipdh_Model.ModifieddtD = DateTime.Now;

                        if (System.IO.File.Exists(ActualThumpImagePath))
                        {
                            System.IO.File.Delete(ActualThumpImagePath);
                        }
                    }
                    else
                    {
                        mst_Ipdh_Model.ThumpImage = "";
                    }
                }

          

                if (implementConfiguration.Status == true)
                {
                    mst_Ipdh_Model.ActiveflagC = "A";
                }
                else
                {
                    mst_Ipdh_Model.ActiveflagC = "I";
                }

                _context.SaveChanges();

                UpdateStatus = true;

            }
            catch (Exception ex)
            {
                UpdateStatus = false;
            }
            return UpdateStatus;
        }
        public IEnumerable<Features> GetfeatureList(string ModelId, int LanguageId = 0)
        {
            List<Features> FeatureList = new List<Features>();
            try
            { 
            

                 FeatureList = (from p in _context.MstIpdhModelFeatures
                                   join o in _context.MstIpdhModelFeaturesLang on p.FeatureId equals o.FeatureId
                                   where o.MstLangId == LanguageId && p.IpdhModelcodeVc == ModelId
                                   select new Features
                                   {
                                       FeatureId = p.FeatureId,
                                       FeatureName = o.FeatureName,
                                       FeatureValue = o.FeatureValue
                                   }).Distinct().ToList();

                


            
            }
            catch(Exception ex)
            {

            }
            return FeatureList;
        }
        public IEnumerable<Benefits> GetBenefitsList(string ModelId, int LanguageId = 0)
        {
            List<Benefits> benefitsListt = new List<Benefits>();
          
            try
            {
                benefitsListt = (from p in _context.MstIpdhModelBenefits
                                    join o in _context.MstIpdhModelBenefitsLang on p.BenefitsId equals o.BenefitsId
                                    where o.MstLangId == LanguageId && p.IpdhModelcodeVc == ModelId
                                    select new Benefits
                                    {
                                        BenefitsId = p.BenefitsId,
                                        BenefitsName = o.BenefitsName,
                                        BenefitsValue = o.FeatureValue
                                    }).Distinct().ToList();




            }
            catch(Exception ex)
            {

            }
            return benefitsListt;
        }
        public IEnumerable<Specification> GetSpecificationList(string ModelId, int LanguageId = 0)
        {
            List<Specification> SpecificationList = new List<Specification>();
           
            try
            { 
                SpecificationList = (from p in _context.MstIpdhModelSpecification
                                         join o in _context.MstIpdhModelSpecificationLang on p.SpecificationId equals o.SpecificationId
                                         where o.MstLangId == LanguageId && p.IpdhModelcodeVc == ModelId
                                         select new Specification
                                         {
                                             SpecificationId = p.SpecificationId,
                                             SpecificationName = o.SpecificationName,
                                             SpecififcationValue = o.SpecificationValue
                                         }).Distinct().ToList();
                
            }
            catch(Exception ex)
            {

            }

            return SpecificationList;

        }

        public UpdateImplementsDetails GetUpdateImplementDetails(string ModelId, int LanguageId)
        {
            string ModelImageName = "";
            string ThumpImageName = "";
            UpdateImplementsDetails updateImplementsDetails = new UpdateImplementsDetails();
            updateImplementsDetails.benefits =GetBenefitsList(ModelId, LanguageId).ToList();
            updateImplementsDetails.features = GetfeatureList(ModelId, LanguageId).ToList();
            updateImplementsDetails.specifications = GetSpecificationList(ModelId, LanguageId).ToList();
            updateImplementsDetails.implementConfiguration = new ImplementConfiguration();
            updateImplementsDetails.implementConfiguration.ModelCategoryList = new SelectList(GetCategoryList(), "IGCode_VC", "IGName_VC");
            updateImplementsDetails.implementConfiguration.Modelcode = ModelId;
            updateImplementsDetails.implementConfiguration.ThumpImageUpdated = 0;
            updateImplementsDetails.implementConfiguration.ModelImageUpdated = 0;

            var languages = _global.GetLanguagedata().ToList();

            updateImplementsDetails.LanguageList = new SelectList(languages, "Languageid", "Languagename");

            updateImplementsDetails.selectedLanguage = LanguageId;


            var item = _context.MstIpdhModel.Where(v => v.ModelcodeVc == ModelId).FirstOrDefault();
            if (item != null)
            {
                updateImplementsDetails.implementConfiguration.SelectedIGCode_VC = item.IgcodeVc;
                updateImplementsDetails.implementConfiguration.ModelImagePath = item.ImagePathVc;
                updateImplementsDetails.implementConfiguration.ThumpImagePath = item.ThumpImage;

                if (item.ActiveflagC == "A")
                {
                    updateImplementsDetails.implementConfiguration.Status = true;
                }
                else
                {
                    updateImplementsDetails.implementConfiguration.Status = false;
                }


            }
            var itemCategory = _context.MstIpdhModelgroupLang.Where(v => v.IgcodeVc == updateImplementsDetails.implementConfiguration.SelectedIGCode_VC).FirstOrDefault();
            if (itemCategory != null)
            {
                updateImplementsDetails.implementConfiguration.CategoryName = itemCategory.IgnameVc;
            }

            var item1 = _context.MstIpdhModelLang.Where(v => v.ModelcodeVc == ModelId && v.MstLangId == LanguageId).FirstOrDefault();
            if (item1 != null)
            {
                
                updateImplementsDetails.implementConfiguration.ModelName = item1.ModelnameVc;
            }

            if (string.IsNullOrEmpty(updateImplementsDetails.implementConfiguration.ModelImagePath) == true)
            {
                updateImplementsDetails.implementConfiguration.ModelImagePath = "";
            }
           
            if (string.IsNullOrEmpty(updateImplementsDetails.implementConfiguration.ThumpImagePath) == true)
            {
                updateImplementsDetails.implementConfiguration.ThumpImagePath = "";
            }
          

            updateImplementsDetails.implementConfiguration.DefaultModelImage = DefaultModelImage;
            return updateImplementsDetails;
        }
    }
}
