using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.Tractors;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Services
{
    public class TractorsService:ITractorsService
    {

        private readonly dev_encrypted_generalcustomerappContext _context;

        private readonly IGlobalService _global;


        private string VirtualPath4Model = "";
        private string VirtualPath4Thump = "";

        private string VirtualPath4Video = "";
        private string ActualPath4Model = "";
        private string ActualPath4Thump = "";




        public IConfiguration _configuration { get; }
        public TractorsService(dev_encrypted_generalcustomerappContext Context, IConfiguration configuration, IGlobalService Global)
        {
            _context = Context;
            _global = Global;
            _configuration = configuration;
            VirtualPath4Model = _configuration.GetValue<string>("Tractors:VirtualPath4TpdhModel");
            VirtualPath4Thump = _configuration.GetValue<string>("Tractors:VirtualPath4TpdhThump");
            VirtualPath4Video = _configuration.GetValue<string>("Tractors:VirtualPath4TpdhVideo");
            ActualPath4Model = _configuration.GetValue<string>("Tractors:ActualPath4TpdhModel");
            ActualPath4Thump = _configuration.GetValue<string>("Tractors:ActualPath4TpdhThump");


        }


        public TractorsMaster GetTractors(int IsSearch, TractorModelSearch tractorModelSearch)
        {
            TractorsMaster tractorsMaster = new TractorsMaster();
            try
            {            

            var languages = _global.GetLanguagedata().ToList();

            if (IsSearch == 1)
            {
                tractorsMaster.tractorModelSearch = new TractorModelSearch();
                tractorsMaster.tractorModelSearch = tractorModelSearch;
                tractorsMaster.TractorData = GetTractorModelListBySearch(tractorsMaster.tractorModelSearch);
                tractorsMaster.tractorModelSearch.TpdhModelList = new SelectList(GetModelList(), "MODELCODE_VC", "MODELNAME_VC");
                tractorsMaster.tractorModelSearch.TpdhBrandList = new SelectList(GetBrandList(), "BRANDCODE_VC", "BRANDNAME_VC");
                tractorsMaster.tractorModelSearch.TpdhHPList = new SelectList(GetHPList(), "HPCODE_VC", "HPNAME_VC");
                tractorsMaster.tractorModelSearch.LanguageList = new SelectList(languages, "Languageid", "Languagename");
          
            }
            else
            {
                tractorsMaster.tractorModelSearch = new TractorModelSearch();
                tractorsMaster.tractorModelSearch.TpdhModelList = new SelectList(GetModelList(), "MODELCODE_VC", "MODELNAME_VC");
                tractorsMaster.tractorModelSearch.TpdhBrandList = new SelectList(GetBrandList(), "BRANDCODE_VC", "BRANDNAME_VC");
                tractorsMaster.tractorModelSearch.TpdhHPList = new SelectList(GetHPList(), "HPCODE_VC", "HPNAME_VC");
                tractorsMaster.tractorModelSearch.LanguageList = new SelectList(languages, "Languageid", "Languagename");
                tractorsMaster.tractorModelSearch.selectedLanguage = 1;
                tractorsMaster.TractorData = GetTractorModelList().ToList();
            }


            }
            catch(Exception ex)
            {

            }
            return tractorsMaster;
        }

        public IEnumerable<Tractors> GetTractorModelList(int languageID = 1, int CategoryId = 0)
        {       
            List<Tractors> tractors = new List<Tractors>();
            try
            { 
                var ModelsList = (from p in _context.MstTpdhModel
                                  join o in _context.MstTpdhModelLang on p.ModelcodeVc equals o.ModelcodeVc                                  
                                  where o.MstLangId == languageID                                  
                                  select new Tractors
                                  {
                                      ModelCode = o.ModelcodeVc,
                                      ModelName = o.ModelnameVc,
                                      ModelImage = "",
                                      LanguageId = languageID
                                  }).ToList();

                foreach (var item in ModelsList)
                {
                    Tractors tractor = new Tractors();
                    tractor.ModelCode = item.ModelCode;
                    tractor.ModelName = item.ModelName;
                    tractor.LanguageId = item.LanguageId;
                    tractor.BrochureExists = IsBrochureExists(item.ModelCode);
                    tractor.DIYVideoExists = IsDIYExists(item.ModelCode, languageID);
                    tractor._360Exists = Is360Exists(item.ModelCode);

              
                    tractor.ModelImage = GetThumpImage(item.ModelCode, languageID);
                    tractors.Add(tractor);
                }
            }
            catch(Exception ex)
            {

            }
                return tractors;


            
        }

        public bool IsBrochureExists(string Modelcode)
        {
            bool BrochureExists = false;
            try
            {
                
                var Brochure = (from p in _context.MstTpdhModelDetails
                                where p.ActiveflagC == "A" && p.ModelcodeVc == Modelcode && p.FileTypeId == (int)TpdhModel.Brochure
                                select p
                                 ).ToList();

                if (Brochure.Count > 0)
                {
                    BrochureExists = true;
                }
            }
            catch (Exception ex)
            {

            }
            return BrochureExists;
        }

        public bool IsDIYExists(string Modelcode, int LanguageId)
        {
            bool DIYVideoExists = false;
            try
            {                
                var DIYVideo = (from p in _context.TblDiyVideoModelmapping
                                where p.ActiveflagC == "A" && p.ModelcodeVc == Modelcode && p.MstLangId == LanguageId
                                select p
                                 ).ToList();

                if (DIYVideo.Count > 0)
                {
                    DIYVideoExists = true;
                }
            }
            catch (Exception ex)
            {

            }
            return DIYVideoExists;
        }
        
        public bool Is360Exists(string Modelcode)
        {
            bool _360Exists = false;
            try
            {               
                var _360 = (from p in _context.MstTpdhModelDetails
                            where p.ActiveflagC == "A" && p.ModelcodeVc == Modelcode && p.FileTypeId == (int)TpdhModel._360
                            select p
                                 ).ToList();

                if (_360.Count > 0)
                {
                    _360Exists = true;
                }
            }
            catch (Exception ex)
            {

            }
            return _360Exists;
        }
        public string GetThumpImage(string ModelId, int LanguageId)
        {
            string ThumpImage = "";
            try
            {
               
                //ThumpImage = _context.MstTpdhModelDetails.Where(x => x.ActiveflagC == "A" && x.ModelcodeVc == ModelId
                //&& x.FileTypeId == (int)TpdhModel.ThumpImage && x.MstLangId == LanguageId).FirstOrDefault().ImageUrl;


                var thumpimagequery = (from p in _context.MstTpdhModelDetails
                                       where p.ActiveflagC == "A"
                                        && p.ModelcodeVc==ModelId
                                         && p.FileTypeId == (int)TpdhModel.ThumpImage && p.MstLangId == LanguageId
                                       select p).FirstOrDefault();
                if (thumpimagequery != null)
                {
                    ThumpImage = thumpimagequery.ImageUrl;
                }

            }
            catch (Exception ex)
            {

            }
            return ThumpImage;
        }

        public List<Features> GetfeatureList(string ModelId, int LanguageId = 0)
        {

            List<Features> featureslist = new List<Features>();
            try
            {
                featureslist = (from p in _context.MstTpdhModelFeatures
                                    join o in _context.MstTpdhModelFeaturesLang on p.FeatureId equals o.FeatureId
                                    where o.MstLangId == LanguageId && p.ModelcodeVc == ModelId
                                    select new Features
                                    {
                                        FeatureId = p.FeatureId,
                                        FeatureName = o.FeatureName,
                                        FeatureValue = o.FeatureValue
                                    }).ToList();

            }
            catch(Exception ex)
            {

            }

             return featureslist;
            
        }
        public List<Specification> GetSpecificationList(string ModelId, int LanguageId = 0)
        {
            List<Specification> Specificationlist = new List<Specification>();
            try
            {

                Specificationlist = (from p in _context.MstTpdhModelSpecification
                                         join o in _context.MstTpdhModelSpecificationLang on p.SpecificationId equals o.SpecificationId
                                         join c in _context.MstTpdhSpecificationCategory on p.SpecificationCategory equals c.SpecCategoryId
                                         join cl in _context.MstTpdhSpecificationCategoryLang on c.SpecCategoryId equals cl.SpecCategoryId
                                         join sm in _context.TblTpdhModelSpecificationMapping on p.SpecificationId equals sm.SpecificationId
                                         join sml in _context.TblTpdhModelSpecificationMappingLang on sm.MappingId equals sml.MappingId
                                     where o.MstLangId == LanguageId 
                                           && cl.MstLangId == LanguageId 
                                           && sm.ModelcodeVc == ModelId
                                           && sml.MstLangId==LanguageId

                                         select new Specification
                                         {
                                             SpecificationId = p.SpecificationId,
                                             SpecificationName = o.SpecificationName,
                                             SpecCategoryId = cl.SpecCategoryId,
                                             SpecCategoryName = cl.SpecCategoryName
                                             //SpecififcationValue = o.
                                         }).ToList();

               

            }
            catch(Exception ex)
            {

            }
            return Specificationlist;


        }
        public List<SpecificationGroup> GetSpecificationGroups(string ModelId, int LanguageId = 0)
        {
           
                var specificationsgrouplist = (from p in _context.MstTpdhModelSpecification
                                               join o in _context.MstTpdhModelSpecificationLang on p.SpecificationId equals o.SpecificationId
                                               join c in _context.MstTpdhSpecificationCategory on p.SpecificationCategory equals c.SpecCategoryId
                                               join cl in _context.MstTpdhSpecificationCategoryLang on c.SpecCategoryId equals cl.SpecCategoryId
                                               join sm in _context.TblTpdhModelSpecificationMapping on p.SpecificationId equals sm.SpecificationId
                                               where o.MstLangId == LanguageId && cl.MstLangId == LanguageId && sm.ModelcodeVc == ModelId
                                               group c by new { cl.SpecCategoryId, cl.SpecCategoryName } into grouped
                                               select new SpecificationGroup
                                               {

                                                   SpecCategoryId = grouped.Key.SpecCategoryId,
                                                   SpecCategoryName = grouped.Key.SpecCategoryName
                                                   //SpecififcationValue = o.
                                               }).ToList();

                return specificationsgrouplist;


            
        }
        public UpdateTractorDetails GetUpdateTractorDetails(string ModelId, int LanguageId = 0)
        {
            string ActiveFlag = "";
            string BrochureURLPath = "";
            string UserManualURLPath = "";

            UpdateTractorDetails updateTractorDetails = new UpdateTractorDetails();

            try
            { 
            updateTractorDetails.features = GetfeatureList(ModelId, LanguageId);
            updateTractorDetails.specifications = GetSpecificationList(ModelId, LanguageId);
            updateTractorDetails.specificationGroups = GetSpecificationGroups(ModelId, LanguageId);

            TractorConfiguration tractorConfiguration = new TractorConfiguration();
            tractorConfiguration.Modelcode = ModelId;
            tractorConfiguration.ThumpImageUpdated = 0;
            tractorConfiguration.ModelImage1Updated = 0;
            tractorConfiguration.ModelImage2Updated = 0;
            tractorConfiguration.ModelImage3Updated = 0;
            tractorConfiguration.UserManaulUpdated = 0;
            tractorConfiguration._360Updated = 0;
            tractorConfiguration.BrochureUpdated = 0;

            tractorConfiguration.LanguageId = LanguageId;





            var languages = _global.GetLanguagedata().ToList();

            updateTractorDetails.LanguageList = new SelectList(languages, "Languageid", "Languagename");


            ActiveFlag = _context.MstTpdhModel.Where(x => x.ModelcodeVc == ModelId
                            ).FirstOrDefault().ActiveflagC;
            if (ActiveFlag == "A")
            {
                tractorConfiguration.Status = true;
            }
            else
            {
                tractorConfiguration.Status = false;
            }



            try
            {
                var ThumpImage = _context.MstTpdhModelDetails.Where(v => v.ModelcodeVc == ModelId && v.FileTypeId == (int)TpdhModel.ThumpImage).FirstOrDefault();
                if (ThumpImage != null)
                {
                    tractorConfiguration.ThumpImagePath = (string.IsNullOrEmpty(ThumpImage.ImageUrl) == true ? "" : ThumpImage.ImageUrl);
                }
            }
            catch (Exception ex)
            {
                tractorConfiguration.ThumpImagePath = "";
            }



            try
            {
                var _360File = _context.MstTpdhModelDetails.Where(v => v.ModelcodeVc == ModelId && v.FileTypeId == (int)TpdhModel._360).FirstOrDefault();
                if (_360File != null)
                {
                    tractorConfiguration.Tractor360ViewURLPath = (string.IsNullOrEmpty(_360File.ImageUrl) == true ? "" : _360File.ImageUrl);
                }
            }
            catch (Exception ex)
            {
                tractorConfiguration.Tractor360ViewURLPath = "";
            }




            List<MstTpdhModelDetails> modelImages = (from a in _context.MstTpdhModelDetails.Where(x => x.ModelcodeVc == tractorConfiguration.Modelcode && x.FileTypeId == (int)TpdhModel.Image) select a).OrderBy(x => x.DetailsId).ToList();



            updateTractorDetails.tractorConfiguration = tractorConfiguration;


            List<ModelImages> modelImagesTemplate = new List<ModelImages>();
            ModelImages modelImage = new ModelImages();
            modelImage.ID = 0;
            modelImage.ImageURL = "";
            modelImagesTemplate.Add(modelImage);


            updateTractorDetails.tractorConfiguration.ModelImageslist = GetModelImagesList(ModelId, LanguageId).ToList();
            updateTractorDetails.tractorConfiguration.ModelImagesTemplate = modelImagesTemplate;
            updateTractorDetails.selectedLanguage = LanguageId;

            List<ModelImageURL> modelImageURLs = new List<ModelImageURL>();
            modelImageURLs = GetModelImagesURL(1,ModelId).ToList();

            if (modelImageURLs != null)
            {
                if (modelImageURLs.Count > (int)TpdhModelImages.Image1)
                {
                    tractorConfiguration.Model1ImagePath = modelImageURLs.ElementAt((int)TpdhModelImages.Image1).ImageURL;
                    tractorConfiguration.Model1ImagePath = tractorConfiguration.Model1ImagePath == null ? "" : tractorConfiguration.Model1ImagePath;
                }
                if (modelImageURLs.Count > (int)TpdhModelImages.Image2)
                {
                    tractorConfiguration.Model2ImagePath = modelImageURLs.ElementAt((int)TpdhModelImages.Image2).ImageURL;
                    tractorConfiguration.Model2ImagePath = tractorConfiguration.Model2ImagePath == null ? "" : tractorConfiguration.Model2ImagePath;
                }
                if (modelImageURLs.Count > (int)TpdhModelImages.Image3)
                {
                    tractorConfiguration.Model3ImagePath = modelImageURLs.ElementAt((int)TpdhModelImages.Image3).ImageURL;
                    tractorConfiguration.Model3ImagePath = tractorConfiguration.Model3ImagePath == null ? "" : tractorConfiguration.Model3ImagePath;
                }
            }

            List<int> UsermanualLanguage = new List<int>();

            var Usermanual = (from p in _context.MstTpdhModelDetails
                              where p.ActiveflagC == "A" && p.FileTypeId == (int)TpdhModel.UserManaul && p.ModelcodeVc == ModelId
                              select p
                             ).ToList();

            foreach (var usermanualitem in Usermanual)
            {

                UsermanualLanguage.Add(Convert.ToInt32(usermanualitem.MstLangId));
                UserManualURLPath = usermanualitem.ImageUrl;
            }

            List<int> BrochureLanguage = new List<int>();

            var BrochureLang = (from p in _context.MstTpdhModelDetails
                                where p.ActiveflagC == "A" && p.FileTypeId == (int)TpdhModel.Brochure && p.ModelcodeVc == ModelId
                                select p
                             ).ToList();

            foreach (var Brochureitem in BrochureLang)
            {

                BrochureLanguage.Add(Convert.ToInt32(Brochureitem.MstLangId));
                BrochureURLPath = Brochureitem.ImageUrl;

            }


            updateTractorDetails.tractorConfiguration.Language4UserManual = UsermanualLanguage;
            updateTractorDetails.tractorConfiguration.Language4Brochure = BrochureLanguage;
            updateTractorDetails.tractorConfiguration.BrochureURLPath = BrochureURLPath;
            updateTractorDetails.tractorConfiguration.UserManaulURLPath = UserManualURLPath;

         
            updateTractorDetails.tractorConfiguration.dIYVideoMappingList = GetDIYMappingList(ModelId, 0).ToList();
            updateTractorDetails.tractorConfiguration.dIYVideoMappingListOrg = GetDIYMappingList(ModelId, 0).ToList();
            updateTractorDetails.tractorConfiguration.dIYVideoMappingTemplate = new List<DIYVideoMapping>();
            updateTractorDetails.tractorConfiguration.dIYVideoMappingTemplate.Add(new DIYVideoMapping()
            {
                LanguageId = 0,
                LanguageName = "",
                MappingId = 0,
                VideoId = 0,
                VideoName = ""
            });
            DIYVideo dIYVideo = new DIYVideo();
            dIYVideo.VideoCategoryList = new SelectList(GetDIYVideoCategory(), "DIYCategoryId", "DIYCategoryName");
            dIYVideo.DIYVideosList = new SelectList(GetDIYVideosLists(), "DIY_ID", "DIY_NAME");
            dIYVideo.LanguageList = new SelectList(languages, "Languageid", "Languagename");
            updateTractorDetails.tractorConfiguration.dIYVideo = dIYVideo;


            }
            catch(Exception ex )
            {

            }
            return updateTractorDetails;
        }
        public List<Tractors> GetTractorModelListBySearch(TractorModelSearch tractorModelSearch)
        {           

                if (tractorModelSearch.SelectedHP == null)
                {
                    tractorModelSearch.SelectedHP = new List<string>();
                }
                if (tractorModelSearch.SelectedModel == null)
                {
                    tractorModelSearch.SelectedModel = new List<string>();
                }

                if (tractorModelSearch.SelectedBrand == null)
                {
                    tractorModelSearch.SelectedBrand = new List<string>();
                }

                if (tractorModelSearch.selectedLanguage == 0)
                {
                    tractorModelSearch.selectedLanguage = 1;
                }


                List<Tractors> tractors = new List<Tractors>();
                var ModelsList = (from p in _context.MstTpdhModel
                                  join o in _context.MstTpdhModelLang on p.ModelcodeVc equals o.ModelcodeVc                                  
                                  where
                                  o.MstLangId == tractorModelSearch.selectedLanguage
                                  && (tractorModelSearch.SelectedHP.Count == 0 || tractorModelSearch.SelectedHP.Contains(p.HpcodeVc))
                                  && (tractorModelSearch.SelectedModel.Count == 0 || tractorModelSearch.SelectedModel.Contains(p.ModelcodeVc))
                                  && (tractorModelSearch.SelectedBrand.Count == 0 || tractorModelSearch.SelectedBrand.Contains(p.BrandcodeVc))
                                  select new Tractors
                                  {
                                      ModelCode = o.ModelcodeVc,
                                      ModelName = o.ModelnameVc,
                                      ModelImage = "",
                                      LanguageId = tractorModelSearch.selectedLanguage
                                  }).ToList();

                foreach (var item in ModelsList)
                {
                    Tractors tractor = new Tractors();
                    tractor.ModelCode = item.ModelCode;
                    tractor.ModelName = item.ModelName;
                    tractor.LanguageId = item.LanguageId;
                    tractor.BrochureExists = IsBrochureExists(item.ModelCode);
                    tractor.DIYVideoExists = IsDIYExists(item.ModelCode, tractorModelSearch.selectedLanguage);
                    tractor._360Exists = Is360Exists(item.ModelCode);

                    if (string.IsNullOrEmpty(item.ModelImage) == true)
                    {
                        tractor.ModelImage = "";
                    }
                    else
                    {
                        tractor.ModelImage = item.ModelImage;
                    }
                    tractors.Add(tractor);
                }
                return tractors;


            
        }
        public IEnumerable<TpdhModels> GetModelList(int LanguageID = 1)
        {
            
                var TpdhModelList = (from p in _context.MstTpdhModel
                                     join o in _context.MstTpdhModelLang on p.ModelcodeVc equals o.ModelcodeVc
                                     where p.ActiveflagC == "A"
                                     && o.ActiveflagC == "A"
                                     && o.MstLangId == LanguageID
                                     select new TpdhModels
                                     {
                                         MODELCODE_VC = o.ModelcodeVc,
                                         MODELNAME_VC = o.ModelnameVc
                                     }).ToList();
                return TpdhModelList;
            

        }
        public IEnumerable<TpdhBrand> GetBrandList(int LanguageID = 1)
        {
          
                var TpdhBrandList = (from p in _context.MstTpdhBrand
                                     join o in _context.MstTpdhBrandLang on p.BrandcodeVc equals o.BrandcodeVc
                                     where p.ActiveflagC == "A"
                                     && o.ActiveflagC == "A"
                                     && o.MstLangId == LanguageID
                                     select new TpdhBrand
                                     {
                                         BRANDCODE_VC = o.BrandcodeVc,
                                         BRANDNAME_VC = o.BrandnameVc
                                     }).ToList();
                return TpdhBrandList;
            

        }


        public IEnumerable<TpdhHP> GetHPList(int LanguageID = 1)
        {
           
                var TpdhHPList = (from p in _context.MstTpdhHp
                                  join o in _context.MstTpdhHpLang on p.HpcodeVc equals o.HpcodeVc
                                  where p.ActiveflagC == "A"
                                  && o.ActiveflagC == "A"
                                  && o.MstLangId == LanguageID
                                  select new TpdhHP
                                  {
                                      HPCODE_VC = o.HpcodeVc,
                                      HPNAME_VC = o.HpnameVc
                                  }).ToList();
                return TpdhHPList;
            

        }
        public IEnumerable<VideoLanguages> Languages4Video(int VideoId)
        {

            List<VideoLanguages> videoLanguages = new List<VideoLanguages>();
            try
            {
                videoLanguages = (from p in _context.MstDiyVideoLang
                                 join v in _context.MstDiyVideo on p.DiyId equals v.DiyId
                                 where p.ActiveflagC == "A" && v.ActiveflagC == "A"
                                   && p.DiyId == VideoId
                                 select new VideoLanguages
                                 {
                                     VideoId = p.DiyId,
                                     LanguageId = p.MstLangId
                                 }).ToList();

            }
            catch(Exception)
            {

            }
            return videoLanguages;

        }
        public IEnumerable<DIYVideosList> GetDIYVideosList4Category(int CategoryId, int LanguageID = 1)
        {
            List<DIYVideosList> dIYVideosLists = new List<DIYVideosList>();
            try
            {               
                    var dIYVideos = (from p in _context.MstDiyVideo
                                     where p.ActiveflagC == "A" && p.DiyCategory == CategoryId
                                     select p
                                         ).ToList();

                    foreach (var item in dIYVideos)
                    {
                        DIYVideosList dIYVideosList = new DIYVideosList();
                        dIYVideosList.DIY_ID = item.DiyId;
                        try
                        {
                        //dIYVideosList.DIY_NAME = (_context.MstDiyVideoLang.Where(x => x.DiyId == item.DiyId && x.MstLangId == LanguageID && x.ActiveflagC == "A")).SingleOrDefault().DiyName;

                        var Diyquery = (from p in _context.MstDiyVideoLang
                                        where p.ActiveflagC == "A"
                                              && p.DiyId == item.DiyId
                                              && p.MstLangId == LanguageID
                                        select p).FirstOrDefault();
                        if (Diyquery != null)
                        {
                            dIYVideosList.DIY_NAME = Diyquery.DiyName;
                        }

                        else
                        {
                            dIYVideosList.DIY_NAME = "";
                        }

                    }
                        catch (Exception ex)
                        {
                            dIYVideosList.DIY_NAME = "";
                        }

                        if (string.IsNullOrEmpty(dIYVideosList.DIY_NAME))
                        {
                            dIYVideosList.DIY_NAME = item.DiyId + " - DIY Name Not Available";
                        }
                        else
                        {
                            dIYVideosList.DIY_NAME = item.DiyId + " - " + dIYVideosList.DIY_NAME;
                        }
                        dIYVideosLists.Add(dIYVideosList);
                    }


                
            }
            catch (Exception ex)
            {

            }
            return dIYVideosLists;
        }

        public IEnumerable<ModelImages> GetModelImagesList(string ModelCode, int LanguageId = 1)
        {
            List<ModelImages> modelImageslist = new List<ModelImages>();
            try
            {
              
                var query = (from a in _context.MstTpdhModelDetails
                             where a.ActiveflagC == "A" && a.MstLangId == LanguageId &&
                             a.FileTypeId == (int)TpdhModel.Image &&
                             a.ModelcodeVc == ModelCode
                             select a).ToList();


                foreach (var item in query)
                {
                    ModelImages modelImages = new ModelImages();
                    modelImages.ID = item.DetailsId;
                    modelImages.ImageURL = item.ImageUrl;
                    modelImages.ActiveFlag = item.ActiveflagC;
                    modelImageslist.Add(modelImages);
                }


            }
            catch (Exception ex)
            { }

            return modelImageslist;
        }


        public IEnumerable<ModelImageURL> GetModelImagesURL(int LanguageId = 1,string ModelCode=null)
        {
            List<ModelImageURL> modelImageURLs = new List<ModelImageURL>();
            try
            {              
                var query = (from a in _context.MstTpdhModelDetails
                             where a.ActiveflagC == "A" &&
                             a.FileTypeId == (int)TpdhModel.Image && a.MstLangId == LanguageId
                             && a.ModelcodeVc == ModelCode
                             //&& string.IsNullOrEmpty(a.IMAGE_URL)==false
                             orderby a.DetailsId
                             select a).ToList();


                foreach (var item in query)
                {
                    ModelImageURL modelImageURL = new ModelImageURL();
                    modelImageURL.ImageURL = item.ImageUrl;
                    modelImageURLs.Add(modelImageURL);
                }


            }
            catch (Exception ex)
            { }

            return modelImageURLs;
        }
     
        public IEnumerable<DIYVideoMapping> GetDIYMappingList(string ModelCode, int VideoId)
        {
            List<DIYVideoMapping> dIYVideoMappings = new List<DIYVideoMapping>();
            try
            {

              
                    dIYVideoMappings = (from p in _context.TblDiyVideoModelmapping
                                        join o in _context.MstDiyVideoLang on p.MstLangId equals o.MstLangId
                                        join v in _context.MstDiyVideo on o.DiyId equals v.DiyId
                                        join l in _context.MstLanguage on o.MstLangId equals l.Id
                                        where p.ActiveflagC == "A"
                                        && o.ActiveflagC == "A"
                                        && p.ModelcodeVc == ModelCode
                                        && p.DiyId == o.DiyId
                                        && ((VideoId == 0) || p.DiyId == VideoId)
                                        && ((VideoId == 0) || o.DiyId == VideoId)
                                        select new DIYVideoMapping
                                        {
                                            LanguageId = o.MstLangId,
                                            LanguageName = l.LanguageName,
                                            MappingId = p.MappingId,
                                            VideoId = o.DiyId,
                                            VideoName = o.DiyName,
                                            ActiveFlag = p.ActiveflagC

                                        }).ToList();

                
            }
            catch (Exception ex)
            {

            }
            return dIYVideoMappings;
        }

        public IEnumerable<DIYVideoCategory> GetDIYVideoCategory(int LanguageID = 1)
        {
            List<DIYVideoCategory> dIYVideoCategories = new List<DIYVideoCategory>();
            try
            {
                dIYVideoCategories = (from p in _context.MstDiyVideoCategory
                                     join o in _context.MstDiyVideoCategoryLang on p.Id equals o.DiyId
                                     where p.ActiveflagC == "A"
                                     && o.ActiveflagC == "A"
                                     && o.MstLangId == LanguageID
                                     select new DIYVideoCategory
                                     {
                                         DIYCategoryId = o.DiyId,
                                         DIYCategoryName = o.CategoryName
                                     }).ToList();
               
            }
            catch(Exception ex)
            {

            }
            return dIYVideoCategories;
        }
        public IEnumerable<DIYVideosList> GetDIYVideosLists(int LanguageID = 1)
        {
            List<DIYVideosList> dIYVideosLists = new List<DIYVideosList>();
            try
            {
              
                    var dIYVideos = (from p in _context.MstDiyVideo
                                     where p.ActiveflagC == "A"
                                     select p
                                         ).ToList();

                    foreach (var item in dIYVideos)
                    {
                        DIYVideosList dIYVideosList = new DIYVideosList();
                        dIYVideosList.DIY_ID = item.DiyId;
                        try
                        {

                        var Diyquery = (from p in _context.MstDiyVideoLang
                                        where p.ActiveflagC == "A"
                                              && p.DiyId == item.DiyId 
                                              && p.MstLangId == LanguageID
                                               select p).FirstOrDefault();
                        if (Diyquery != null)
                        {
                            dIYVideosList.DIY_NAME = Diyquery.DiyName;
                        }

                        else
                        {
                            dIYVideosList.DIY_NAME = "";
                        }
                        //dIYVideosList.DIY_NAME = (_context.MstDiyVideoLang.Where(x => x.DiyId == item.DiyId && x.MstLangId == LanguageID && x.ActiveflagC == "A")).SingleOrDefault().DiyName;
                        }
                        catch (Exception ex)
                        {
                            dIYVideosList.DIY_NAME = "";
                        }

                        if (string.IsNullOrEmpty(dIYVideosList.DIY_NAME))
                        {
                            dIYVideosList.DIY_NAME = item.DiyId + " - DIY Name Not Available";
                        }
                        else
                        {
                            dIYVideosList.DIY_NAME = item.DiyId + " - " + dIYVideosList.DIY_NAME;
                        }
                        //dIYVideosList.DIY_NAME = 
                        dIYVideosLists.Add(dIYVideosList);
                    }


                
            }
            catch (Exception ex)
            {

            }
            return dIYVideosLists;
        }

        public bool UpdateTractorConfiguration(TractorConfiguration tractorConfiguration,string Host)
        {
            string FileName4Model = "";
            string ActualModelImageName = ""; 
            string Model1ImageURL = "";
            string Model2ImageURL = "";
            string Model3ImageURL = "";
            string ThumpImageURL = "";
            string UserManualURL = "";
            string Tractor360URL = "";
            string BrochureURL = "";
            int ImageId1 = 0;
            int ImageId2 = 0;
            int ImageId3 = 0;
            string ActiveFlag = "";
            bool IsUpdated = false;
            try
            {


                if (tractorConfiguration.Status == true)
                {
                    ActiveFlag = "A";
                }
                else
                {
                    ActiveFlag = "I";
                }
                MstTpdhModel tpdh_Model = _context.MstTpdhModel.Single(x => x.ModelcodeVc == tractorConfiguration.Modelcode);
                tpdh_Model.ActiveflagC = ActiveFlag;
                tpdh_Model.ModifieddtD = DateTime.Now;
                _context.SaveChanges();


                if (tractorConfiguration.ModelImageslist != null)
                {
                    foreach (var modelimages in tractorConfiguration.ModelImageslist)
                    {
                        if ((modelimages.ID == 0) && (modelimages.ImageURL != null))
                        {
                            MstTpdhModelDetails tpthmodelImage = new MstTpdhModelDetails();
                            tpthmodelImage.ModelcodeVc = tractorConfiguration.Modelcode;
                            tpthmodelImage.ActiveflagC = "A";
                            tpthmodelImage.CreateddtD = DateTime.Now;
                            tpthmodelImage.ImageVersion = 1;
                            tpthmodelImage.ImageUrl = Model1ImageURL;
                            tpthmodelImage.FileTypeId = (int)TpdhModel.Image;
                            tpthmodelImage.MstLangId = tractorConfiguration.LanguageId;
                            _context.MstTpdhModelDetails.Add(tpthmodelImage);
                            _context.SaveChanges();
                            int ModelId = tpthmodelImage.DetailsId;
                            FileName4Model = tractorConfiguration.Modelcode + "_TpdhModel_" + ModelId + ".png";
                            if (modelimages.ImageURL != null)
                            {
                                ActualModelImageName = _global.SaveImage(modelimages.ImageURL, VirtualPath4Model, FileName4Model);
                                Model1ImageURL = Host + ActualPath4Model + ActualModelImageName;

                                MstTpdhModelDetails tpthmodelImageUpd = _context.MstTpdhModelDetails.Single(x => x.DetailsId == ModelId);
                                tpthmodelImageUpd.ImageUrl = Model1ImageURL;
                                _context.SaveChanges();
                            }
                            else
                            {
                                Model1ImageURL = "";
                            }
                        }
                        else
                        {
                            if (modelimages.ActiveFlag == "I" && modelimages.ID > 0)
                            {
                                MstTpdhModelDetails tpthmodelImageUpd = _context.MstTpdhModelDetails.Single(x => x.DetailsId == modelimages.ID);
                                tpthmodelImageUpd.ActiveflagC = modelimages.ActiveFlag;
                                tpthmodelImageUpd.MstLangId = tractorConfiguration.LanguageId;
                                _context.SaveChanges();
                            }
                        }
                    }
                }



                //=======Thump Image================
                if (tractorConfiguration.ThumpImageUpdated == 1)
                {
                    FileName4Model = tractorConfiguration.Modelcode + "_TpdthThump";
                    if (tractorConfiguration.ThumpImage != null)
                    {
                        ActualModelImageName =_global.UploadImage(tractorConfiguration.ThumpImage, FileName4Model, VirtualPath4Thump);
                        Model1ImageURL = Host + ActualPath4Thump + ActualModelImageName;
                    }
                    else
                    {
                        Model1ImageURL = "";
                    }




                    var Thumpimage = _context.MstTpdhModelDetails.Where(x => x.ModelcodeVc == tractorConfiguration.Modelcode && x.FileTypeId == (int)TpdhModel.ThumpImage && x.MstLangId == tractorConfiguration.LanguageId).FirstOrDefault();
                    if (Thumpimage != null)
                    {
                        MstTpdhModelDetails ThumpImage = _context.MstTpdhModelDetails.Single(x => x.ModelcodeVc == tractorConfiguration.Modelcode && x.FileTypeId == (int)TpdhModel.ThumpImage && x.MstLangId == tractorConfiguration.LanguageId);

                        ThumpImage.ImageUrl = Model1ImageURL;
                        ThumpImage.ModelcodeVc = tractorConfiguration.Modelcode;
                        ThumpImage.ActiveflagC = "A";
                        ThumpImage.ModifieddtD = DateTime.Now;
                        ThumpImage.FileTypeId = (int)TpdhModel.ThumpImage;
                        ThumpImage.MstLangId = tractorConfiguration.LanguageId;
                    }
                    else
                    {
                        MstTpdhModelDetails ThumpImage = new MstTpdhModelDetails();
                        ThumpImage.ModelcodeVc = tractorConfiguration.Modelcode;
                        ThumpImage.ActiveflagC = "A";
                        ThumpImage.CreateddtD = DateTime.Now;
                        ThumpImage.ImageVersion = 1;
                        ThumpImage.ImageUrl = Model1ImageURL;
                        ThumpImage.FileTypeId = (int)TpdhModel.ThumpImage;
                        ThumpImage.MstLangId = tractorConfiguration.LanguageId;
                        _context.MstTpdhModelDetails.Add(ThumpImage);
                    }
                }
                //=======User Manual================
                //if (tractorConfiguration.ModelImage1Updated == 1)
                //{
                if (tractorConfiguration.UserManaulUpdated == 1)
                {

                    if (tractorConfiguration.Language4UserManual != null)
                    {


                        foreach (int usermanuallang in tractorConfiguration.Language4UserManual)
                        {

                            FileName4Model = tractorConfiguration.Modelcode + "_TpdhUserManual_" + usermanuallang;
                            if (tractorConfiguration.UserManual != null)
                            {
                                ActualModelImageName =_global.UploadImage(tractorConfiguration.UserManual, FileName4Model, VirtualPath4Model);
                                UserManualURL = Host + ActualPath4Model + ActualModelImageName;
                            }
                            else
                            {
                                UserManualURL = "";
                            }

                            var UserManual = _context.MstTpdhModelDetails.Where(x => x.ModelcodeVc == tractorConfiguration.Modelcode && x.FileTypeId == (int)TpdhModel.UserManaul && x.MstLangId == usermanuallang).FirstOrDefault();
                            if (UserManual != null)
                            {
                                MstTpdhModelDetails TpdhUserManual = _context.MstTpdhModelDetails.Single(x => x.ModelcodeVc == tractorConfiguration.Modelcode && x.FileTypeId == (int)TpdhModel.UserManaul && x.MstLangId == usermanuallang);

                                TpdhUserManual.ImageUrl = UserManualURL;
                                TpdhUserManual.ModelcodeVc = tractorConfiguration.Modelcode;
                                if (UserManualURL == "")
                                {
                                    TpdhUserManual.ActiveflagC = "I";
                                }
                                else
                                {
                                    TpdhUserManual.ActiveflagC = "A";
                                }
                                TpdhUserManual.ModifieddtD = DateTime.Now;
                                TpdhUserManual.FileTypeId = (int)TpdhModel.UserManaul;
                                TpdhUserManual.MstLangId = usermanuallang;
                            }
                            else
                            {
                                MstTpdhModelDetails TpdhUserManual = new MstTpdhModelDetails();
                                TpdhUserManual.ModelcodeVc = tractorConfiguration.Modelcode;
                                if (UserManualURL == "")
                                {
                                    TpdhUserManual.ActiveflagC = "I";
                                }
                                else
                                {
                                    TpdhUserManual.ActiveflagC = "A";
                                }
                                TpdhUserManual.CreateddtD = DateTime.Now;
                                TpdhUserManual.ImageVersion = 1;
                                TpdhUserManual.ImageUrl = UserManualURL;
                                TpdhUserManual.FileTypeId = (int)TpdhModel.UserManaul;
                                TpdhUserManual.MstLangId = usermanuallang;
                                _context.MstTpdhModelDetails.Add(TpdhUserManual);
                            }
                        }
                    }
                }
                //=======360 View================


                if (tractorConfiguration._360Updated == 1)
                {
                    FileName4Model = tractorConfiguration.Modelcode + "_Tpdh360";
                    if (tractorConfiguration.Tractor360View != null)
                    {
                        ActualModelImageName =_global.UploadImage(tractorConfiguration.Tractor360View, FileName4Model, VirtualPath4Model);
                        Tractor360URL = Host + ActualPath4Model + ActualModelImageName;
                    }
                    else
                    {
                        Tractor360URL = "";
                    }




                    var Tractor360View = _context.MstTpdhModelDetails.Where(x => x.ModelcodeVc == tractorConfiguration.Modelcode && x.FileTypeId == (int)TpdhModel._360 && x.MstLangId == tractorConfiguration.LanguageId).FirstOrDefault();
                    if (Tractor360View != null)
                    {
                        MstTpdhModelDetails Tpdh360View = _context.MstTpdhModelDetails.Single(x => x.ModelcodeVc == tractorConfiguration.Modelcode && x.FileTypeId== (int)TpdhModel._360 && x.MstLangId == tractorConfiguration.LanguageId);

                        //Tpdh360View.C360_IMAGE_URL = Tractor360URL;
                        Tpdh360View.ModelcodeVc = tractorConfiguration.Modelcode;
                        Tpdh360View.ActiveflagC = "A";
                        Tpdh360View.ModifieddtD = DateTime.Now;
                        Tpdh360View.FileTypeId = (int)TpdhModel._360;
                        Tpdh360View.ImageUrl = Tractor360URL;
                        Tpdh360View.MstLangId = tractorConfiguration.LanguageId;
                    }
                    else
                    {
                        MstTpdhModelDetails Tpdh360View = new MstTpdhModelDetails();
                        //Tpdh360View.C360_IMAGE_URL = Tractor360URL;
                        Tpdh360View.ImageUrl = Tractor360URL;
                        Tpdh360View.ModelcodeVc = tractorConfiguration.Modelcode;
                        Tpdh360View.ActiveflagC = "A";
                        Tpdh360View.CreateddtD = DateTime.Now;
                        Tpdh360View.ImageVersion = 1;
                        //Tpdh360View.IMAGE_URL = Tractor360URL;
                        Tpdh360View.FileTypeId = (int)TpdhModel._360;
                        Tpdh360View.MstLangId = tractorConfiguration.LanguageId;
                        _context.MstTpdhModelDetails.Add(Tpdh360View);
                    }

                }
                //=======Brochure================
                if (tractorConfiguration.BrochureUpdated == 1)
                {


                    //}

                    foreach (int BrochureLang in tractorConfiguration.Language4Brochure)
                    {

                        FileName4Model = tractorConfiguration.Modelcode + "_TpdhBrochure_" + BrochureLang;
                        if (tractorConfiguration.Brochure != null)
                        {
                            ActualModelImageName = _global.UploadImage(tractorConfiguration.Brochure, FileName4Model, VirtualPath4Model);
                            BrochureURL = Host + ActualPath4Model + ActualModelImageName;
                        }
                        else
                        {
                            BrochureURL = "";
                        }

                        var Brochure = _context.MstTpdhModelDetails.Where(x => x.ModelcodeVc == tractorConfiguration.Modelcode && x.FileTypeId == (int)TpdhModel.Brochure && x.MstLangId == BrochureLang).FirstOrDefault();
                        if (Brochure != null)
                        {
                            MstTpdhModelDetails TpdhBrochure = _context.MstTpdhModelDetails.Single(x => x.ModelcodeVc == tractorConfiguration.Modelcode && x.FileTypeId == (int)TpdhModel.Brochure && x.MstLangId== BrochureLang);

                            //TpdhBrochure.BROCHURE_URL = BrochureURL;
                            TpdhBrochure.ImageUrl = BrochureURL;
                            if (BrochureURL == "")
                            {
                                TpdhBrochure.ActiveflagC= "I";
                            }
                            else
                            {
                                TpdhBrochure.ActiveflagC = "A";
                            }

                            TpdhBrochure.ModifieddtD = DateTime.Now;
                            TpdhBrochure.FileTypeId = (int)TpdhModel.Brochure;
                            TpdhBrochure.MstLangId = BrochureLang;
                        }
                        else
                        {
                            MstTpdhModelDetails TpdhBrochure = new MstTpdhModelDetails();
                            TpdhBrochure.ModelcodeVc = tractorConfiguration.Modelcode;
                            if (BrochureURL == "")
                            {
                                TpdhBrochure.ActiveflagC = "I";
                            }
                            else
                            {
                                TpdhBrochure.ActiveflagC = "A";
                            }
                            TpdhBrochure.CreateddtD= DateTime.Now;
                            TpdhBrochure.ImageVersion = 1;
                            TpdhBrochure.ImageUrl = BrochureURL;
                            TpdhBrochure.FileTypeId = (int)TpdhModel.Brochure;
                            TpdhBrochure.MstLangId = BrochureLang;
                            _context.MstTpdhModelDetails.Add(TpdhBrochure);
                        }
                    }
                }

                //=======DIY Video Mapping================
                List<DIYVideoMapping> dIYVideoMappings = tractorConfiguration.dIYVideoMappingListOrg;
                if (dIYVideoMappings == null)
                {
                    dIYVideoMappings = new List<DIYVideoMapping>();
                }



                foreach (var item in dIYVideoMappings)
                {
                    try
                    {
                        TblDiyVideoModelmapping diylangupdate1 = _context.TblDiyVideoModelmapping.Single(model => model.DiyId == item.VideoId && model.ModelcodeVc== tractorConfiguration.Modelcode && model.MstLangId == item.LanguageId);
                        item.MappingId = diylangupdate1.MappingId;
                    }
                    catch (Exception ex)
                    {
                        item.MappingId = 0;
                    }
                    if (item.MappingId == 0)
                    {
                        TblDiyVideoModelmapping diylang = new TblDiyVideoModelmapping();
                        diylang.DiyId = item.VideoId;
                        diylang.MstLangId = item.LanguageId;
                        diylang.ActiveflagC = item.ActiveFlag;
                        diylang.ModelcodeVc = tractorConfiguration.Modelcode;
                        diylang.CreateddtD = DateTime.Now;
                        _context.TblDiyVideoModelmapping.Add(diylang);
                        _context.SaveChanges();
                    }
                    else
                    {
                        TblDiyVideoModelmapping diylangupdate = _context.TblDiyVideoModelmapping.Single(model => model.MappingId == item.MappingId);
                        diylangupdate.DiyId = item.VideoId;
                        diylangupdate.MstLangId = item.LanguageId;
                        diylangupdate.ActiveflagC = item.ActiveFlag;
                        diylangupdate.ModifieddtD = DateTime.Now;
                        _context.SaveChanges();
                    }
                }


                _context.SaveChanges();
                IsUpdated = true;


            }


            catch (Exception ex)
            {
                IsUpdated = false;

            }
            return IsUpdated;
        }
    }
}
