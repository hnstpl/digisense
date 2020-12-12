using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.Implements;
using AdminPortal.Mvc.GlobalProvider;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Globalization;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;




namespace AdminPortal.Mvc.Services
{
    public class ImplementService:IImplements
    {

        private readonly dev_encrypted_generalcustomerappContext _context;

        private readonly IGlobalService _global;
        private readonly IImplements _Implements;

        private string VirtualPath4Model = "";
        private string VirtualPath4Thump = "";
        private string ActualPath4Model = "";
        private string ActualPath4Thump = "";
        private string DefaultModelImage = "";

        public IConfiguration _configuration { get; }

        public ImplementService(dev_encrypted_generalcustomerappContext Context, IConfiguration configuration, IGlobalService Global)
        {
            _context = Context;
            _global = Global;
            _configuration = configuration;
            VirtualPath4Model = _configuration.GetValue<string>("Implement:VirtualPath4IpdhModel");
            VirtualPath4Thump = _configuration.GetValue<string>("Implement:VirtualPath4IpdhThump");
            ActualPath4Model = _configuration.GetValue<string>("Implement:ActualPath4IpdhModel");
            ActualPath4Thump = _configuration.GetValue<string>("Implement:ActualPath4IpdhThump");
            DefaultModelImage = _configuration.GetValue<string>("Implement:DefaultModelImage");

        }

        public IEnumerable<ImpCategory> GetCategoryList(int LanguageID = 1)
        {

            {
                List<ImpCategory> result = new List<ImpCategory>();

                try
                {

                    var ImpCategoryList = (from p in _context.MstIpdhModelgroup
                                           join o in _context.MstIpdhModelgroupLang on p.IgcodeVc equals o.IgcodeVc
                                           where p.ActiveFlagC == "A"
                                           && o.ActiveflagC == "A"
                                           && o.MstLangId == LanguageID
                                           select new ImpCategory
                                           {
                                               IGCode_VC = o.IgcodeVc,
                                               IGName_VC = o.IgnameVc
                                           }).ToList();
                   
                    result = ImpCategoryList;
                    return result;
                }
                catch (Exception ex)
                {
                    return result;
                }

            }
        }

        
        public IEnumerable<Implements> GetImplementModelListBySearch(int languageID, List<string> SelectedCategory)
        {
                List<Implements> implements = new List<Implements>();
                var ModelsList = (from p in _context.MstIpdhModel
                                  join o in _context.MstIpdhModelLang on p.ModelcodeVc equals o.ModelcodeVc
                                  where o.MstLangId == languageID
                                  && (SelectedCategory.Count == 0 || SelectedCategory.Contains(p.IgcodeVc))
                                  select new Implements
                                  {
                                      ModelCode = o.ModelcodeVc,
                                      ModelName = o.ModelnameVc,
                                      ModelImage = (p.ImagePathVc == null ? "" : p.ImagePathVc),
                                      LanguageId = languageID
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
                return implements;

        }

       public IEnumerable<Implements> GetImplementModelList(int languageID, int CategoryId = 0)
        {
                List<Implements> implements = new List<Implements>();
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
                return implements;

        }

        public Boolean UpdateImplementsConfiguration(ImplementConfiguration implementConfiguration,string Host)
        {

            string ActualThumpImagePath = "";
            string ActualModelImagePath = "";
            string ThumpImageName = "";
            string ModelImageName = "";
            bool retstatus = false;
            var fullpath = Path.Combine(Path.GetFullPath(VirtualPath4Thump).Replace("~\\", ""));
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
                            // ActualModelImagePath = Server.MapPath(VirtualPath4Model) + ModelImageName;
                            ActualModelImagePath = fullpath + ModelImageName;
                        }



                        ActualModelImageName = SaveImage(implementConfiguration.ImageURL, VirtualPath4Model, FileName4Model);


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

                            
                            ActualThumpImagePath = fullpath + ThumpImageName;
                        }



                        ActualThumpImageName = SaveImage(implementConfiguration.ThumpImageURL, VirtualPath4Thump, FileNamethump);


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
                retstatus = true;
             

            }
            catch (Exception ex)
            {
                retstatus = false;
            }
            return retstatus;

        }

        //function to save image in a path
        public string SaveImage(string base64String, string filepath, string filename)
        {
            try
            {

            
                bool exists = System.IO.Directory.Exists(Path.GetFullPath(filepath).Replace("~\\", ""));
                if (!exists)
                {
                    System.IO.Directory.CreateDirectory(Path.GetFullPath(filepath).Replace("~\\", ""));
                }
                var fullpath = Path.Combine(Path.GetFullPath(filepath).Replace("~\\", ""));

                string base64 = base64String.Substring(base64String.IndexOf(',') + 1);
                var bytess = Convert.FromBase64String(base64);

                using (var imageFile = new FileStream(fullpath + filename, FileMode.Create))
                {
                    imageFile.Write(bytess, 0, bytess.Length);
                    imageFile.Flush();
                }

                return filename;


            }
            catch (Exception ex)
            {
                throw new ApplicationException("while saving image: " + ex.Message);

            }
        }


        public IEnumerable<Benefits> GetBenefitsList(string ModelId, int LanguageId = 0)
               {
           
                var BenefitsList = (from p in _context.MstIpdhModelBenefits
                                    join o in _context.MstIpdhModelBenefitsLang on p.BenefitsId equals o.BenefitsId
                                    where o.MstLangId == LanguageId && p.IpdhModelcodeVc == ModelId
                                    select new Benefits
                                    {
                                        BenefitsId = p.BenefitsId,
                                        BenefitsName = o.BenefitsName,
                                        BenefitsValue = o.FeatureValue
                                    }).Distinct().ToList();

                return BenefitsList;
            }

        public IEnumerable<Features> GetfeatureList(string ModelId, int LanguageId = 0)
        {
                var FeatureList = (from p in _context.MstIpdhModelFeatures
                                   join o in _context.MstIpdhModelFeaturesLang on p.FeatureId equals o.FeatureId
                                   where o.MstLangId == LanguageId && p.IpdhModelcodeVc == ModelId
                                   select new Features
                                   {
                                       FeatureId = p.FeatureId,
                                       FeatureName = o.FeatureName,
                                       FeatureValue = o.FeatureValue
                                   }).Distinct().ToList();

                return FeatureList;

        }

        public IEnumerable<Specification> GetSpecificationList(string ModelId, int LanguageId = 0)
        {
                var SpecificationList = (from p in _context.MstIpdhModelSpecification
                                         join o in _context.MstIpdhModelSpecificationLang on p.SpecificationId equals o.SpecificationId
                                         where o.MstLangId == LanguageId && p.IpdhModelcodeVc == ModelId
                                         select new Specification
                                         {
                                             SpecificationId = p.SpecificationId,
                                             SpecificationName = o.SpecificationName,
                                             SpecififcationValue = o.SpecificationValue
                                         }).Distinct().ToList();

                return SpecificationList;

        }


        public UpdateImplementsDetails UpdateImplementDetails(string ModelId, int LanguageId)
        {
            UpdateImplementsDetails updateImplementsDetails = new UpdateImplementsDetails();
            updateImplementsDetails.benefits = GetBenefitsList(ModelId, LanguageId).ToList();
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



        public string UploadImage(IFormFile Image, string filename, string ImageVirtualPath)
        {
            string ActualVirtualPath = "";
            try
            {
                ActualVirtualPath = ImageVirtualPath;
                ImageVirtualPath = "~/" + ImageVirtualPath;
                string ActualImageName = filename + Path.GetExtension(Image.FileName);
                string filePath = ImageVirtualPath;



                bool exists = System.IO.Directory.Exists(Path.GetFullPath(ImageVirtualPath).Replace("~\\", ""));
                if (!exists)
                {
                    System.IO.Directory.CreateDirectory(Path.GetFullPath(ImageVirtualPath).Replace("~\\", ""));
                }
                var fullpath = Path.Combine(Path.GetFullPath(ImageVirtualPath).Replace("~\\", ""));


                if (System.IO.File.Exists(fullpath + ActualImageName))
                {
                    System.IO.File.Delete(fullpath + ActualImageName);
                }
               
                using (var fileStream = new FileStream(fullpath + ActualImageName, FileMode.Create))
                {
                    Image.CopyToAsync(fileStream);
                }
                return ActualImageName;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }



    }
}
