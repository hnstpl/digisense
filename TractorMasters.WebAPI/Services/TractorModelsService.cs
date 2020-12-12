using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using TractorMasters.WebAPI.DataProvider;
using TractorMasters.WebAPI.Models.TractorModels;

namespace TractorMasters.WebAPI.Services
{
    public class TractorModelsService:ITractorModelsService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        private readonly IConfiguration _config;
        private readonly IGlobalService _global;


        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        string moduleName = "";
        int NewTractorTimeLine = 0;
        public TractorModelsService(dev_encrypted_generalcustomerappContext dataContext, IConfiguration config, IGlobalService Global)
        {
            _context = dataContext;
            _config = config;
            _global = Global;

            //Get Module name from config to get the content version
            moduleName = _config.GetValue<string>("TractorMasters:TractorMaster");
            NewTractorTimeLine = _config.GetValue<int>("TractorMasters:NewTractorTimeLineInSeconds");
        }


        public MastersModel GetTractorModels(string LanguageCode, string customerCode)
        {

            MastersModel masterModel = new MastersModel();
            try
            {
              
                    //Get Languages
                    List<MstLanguage> languages = _global.GetLanguageList(LanguageCode, customerCode);

                    //get the new tractor timeline

                    //var NewTractorTimeLine = Convert.ToInt64(ConfigurationManager.AppSettings["NewTractorTimeLineInSeconds"]);

                    List<TPDHModelGroups> masterList = new List<TPDHModelGroups>();
                    foreach (var Language in languages)
                    {
                        TPDHModelGroups master = new TPDHModelGroups
                        {
                            contentversion = (from p in _context.TblVersionController
                                              where p.ActiveflagC == "A"
                                              && p.ModuleName == moduleName
                                              select p.Version.Value).FirstOrDefault(),
                            languagecode = Language.LanguageCode,
                            tractormodelgrouplist = new TPDHModelGroupsList
                            {
                                tractormodelgroup = (from p in _context.MstTpdhModelgroupLang
                                                     join o in _context.MstTpdhModelgroup on p.ModelgroupcodeVc equals o.ModelgroupcodeVc into pmt
                                                     from o in pmt.DefaultIfEmpty()
                                                     join i in _context.MstLanguage on p.MstLangId equals i.Id
                                                     where p.ActiveflagC == "A" && o.ActiveflagC == "A" && i.ActiveflagC == "A"
                                                     && i.LanguageCode == Language.LanguageCode
                                                     select new TPDHModelGroup
                                                     {
                                                         //languagecode = i.LANGUAGE_CODE,
                                                         groupcode = p.ModelgroupcodeVc,
                                                         groupname = p.ModelgroupnameVc,
                                                         tractormodelslist = new TPDHModelsList
                                                         {
                                                             tractormodels = (from u in _context.MstTpdhModelLang
                                                                              join y in _context.MstTpdhModel on u.ModelcodeVc equals y.ModelcodeVc
                                                                              join t in _context.MstTpdhBrand on y.BrandcodeVc equals t.BrandcodeVc
                                                                              join r in _context.MstTpdhBrandLang on t.BrandcodeVc equals r.BrandcodeVc
                                                                              join e in _context.MstTpdhHp on y.HpcodeVc equals e.HpcodeVc
                                                                              join w in _context.MstTpdhHpLang on e.HpcodeVc equals w.HpcodeVc
                                                                              where r.MstLangId == Language.Id
                                                                              && u.MstLangId == Language.Id
                                                                              && w.MstLangId == Language.Id
                                                                              && y.ModelgroupcodeVc == p.ModelgroupcodeVc
                                                                              select new TPDHModels
                                                                              {
                                                                                  brandid = r.BrandcodeVc,
                                                                                  brand = r.BrandnameVc,
                                                                                  hprangeid = w.HpcodeVc,
                                                                                  hprange = w.HpnameVc,
                                                                                  modelcode = y.ModelcodeVc,
                                                                                  modelname = u.ModelnameVc,

                                                                                  
                                                                                  isnew = dev_encrypted_generalcustomerappContext.DiffSeconds(y.CreateddtD, epoch) <= NewTractorTimeLine ? true : false,                                                                                  
                                                                                  //isnew = ((TimeSpan)(DateTime.Now - y.CreateddtD)).Seconds <= NewTractorTimeLine ? true : false,
                                                                                  tractormodelspecificationlist = new TPDHModelSpecsList
                                                                                  {
                                                                                      tractormodelspecifications = (from t in _context.TblTpdhModelSpecificationMappingLang
                                                                                                                    join r in _context.TblTpdhModelSpecificationMapping on t.MappingId equals r.MappingId
                                                                                                                    join e in _context.MstTpdhModelSpecificationLang on r.SpecificationId equals e.SpecificationId
                                                                                                                    where r.ModelcodeVc == y.ModelcodeVc
                                                                                                                    && t.ActiveflagC == "A" && r.ActiveflagC == "A"
                                                                                                                    && t.MstLangId == Language.Id
                                                                                                                    && e.MstLangId == Language.Id
                                                                                                                    select new TPDHModelSpecs
                                                                                                                    {
                                                                                                                        specid = r.SpecificationId.Value,
                                                                                                                        specname = e.SpecificationName,
                                                                                                                        specvalue = t.SpecificationValue
                                                                                                                    }).ToList()
                                                                                  }
                                                                              }).ToList()
                                                         }
                                                     }).ToList()
                            }

                        };

                        //var Videos = new List<VideoProp>();

                        // var Video = new VideoProp
                        //{
                        //   videoid = 1,
                        ///  videourl = "http://192.168.1.101/GeneralCustomerAdmin/Resources/Images/TpdhVideo/9_TpdhVideo.mp4",
                        // videoversion = 1
                        // };

                        // Videos.Add(Video);

                        //Get tractors images
                        master.tractormodelgrouplist.tractormodelgroup.ForEach(x => x.tractormodelslist.tractormodels.ForEach(
                            y => y.imageslist = new Image
                            {
                                _360 = (from q in _context.MstTpdhModelDetails
                                        where q.ActiveflagC == "A" //&& q.C360_IMAGE_URL != null
                                        && q.ModelcodeVc == y.modelcode
                                        && q.FileTypeId == 2
                                        select new ImageProp
                                        {
                                            imageid = q.DetailsId,
                                            imageurl = q.ImageUrl,
                                            imageversion = q.ImageVersion
                                            //modifiedon = q.MODIFIEDDT_D.HasValue ? q.MODIFIEDDT_D.Value : q.CREATEDDT_D.Value
                                        }).ToList(),
                                images = (from q in _context.MstTpdhModelDetails
                                          where q.ActiveflagC == "A" && q.ImageUrl != null
                                          && q.ModelcodeVc == y.modelcode
                                          && (q.ImageUrl != "" && q.ImageUrl != null)
                                          && q.FileTypeId == 1
                                          select new ImageProp
                                          {
                                              imageid = q.DetailsId,
                                              imageurl = q.ImageUrl,
                                              imageversion = q.ImageVersion
                                              //modifiedon = q.MODIFIEDDT_D.HasValue ? q.MODIFIEDDT_D.Value : q.CREATEDDT_D.Value
                                          }).ToList(),
                                thumbimage = (from q in _context.MstTpdhModelDetails
                                              where q.ActiveflagC == "A"
                                              && q.ImageUrl != null
                                              && q.FileTypeId == 5
                                              && q.ModelcodeVc == y.modelcode
                                              select new ImageProp
                                              {
                                                  imageid = q.DetailsId,
                                                  imageurl = q.ImageUrl,
                                                  imageversion = q.ImageVersion
                                              }).FirstOrDefault(),
                                //videos = Videos
                                videos = (from q in _context.MstTpdhModelDetails
                                          where q.ActiveflagC == "A" && q.ImageUrl != null
                                          && q.ModelcodeVc == y.modelcode
                                          && (q.ImageUrl != "" && q.ImageUrl != null)
                                          && q.FileTypeId == 6
                                          select new VideoProp
                                          {
                                              videoid = q.DetailsId,
                                              videourl = q.ImageUrl,
                                              videoversion = q.ImageVersion
                                          }).ToList()
                            }));

                        //Get tractor fetures
                        master.tractormodelgrouplist.tractormodelgroup.ForEach(x => x.tractormodelslist.tractormodels.ForEach(
                            y => y.tractormodelfeaturelist = new TPDHModelFeaturesList
                            {
                                tractormodelfeatures = (from t in _context.MstTpdhModelFeaturesLang
                                                        join r in _context.MstTpdhModelFeatures on t.FeatureId equals r.FeatureId
                                                        where t.ActiveflagC == "A" && r.ActiveflagC == "A"
                                                        && t.MstLangId == Language.Id
                                                        && r.ModelcodeVc == y.modelcode
                                                        select new TPDHModelFeatures
                                                        {
                                                            featureid = r.FeatureId,
                                                            featurename = t.FeatureName,
                                                            featurevalue = t.FeatureValue,
                                                            featureimage = r.FeatureImageUrl
                                                        }).ToList()
                            }));


                        //Get Suitable Implements
                        master.tractormodelgrouplist.tractormodelgroup.ForEach(x => x.tractormodelslist.tractormodels.ForEach(
                           y =>
                           {
                               y.implementslist = new SuitableImplementsList
                               {
                                   implements = (from p in _context.ModelImplementSuitablityNew
                                                 where p.ActiveflagC == "A"
                                                  & p.TpdhModelcodeVc == y.modelcode
                                                 select new SuitableImplements
                                                 {
                                                     implementcode = p.IpdhModelcodeVc
                                                 }).ToList()
                               };

                           }));



                        masterList.Add(master);
                    }


                    //Update the count
                    masterList.ForEach(x =>
                    {
                        x.tractormodelgrouplist.totalrecords = x.tractormodelgrouplist.tractormodelgroup.Count;
                        x.tractormodelgrouplist.tractormodelgroup.ForEach(y =>
                        {
                            y.tractormodelslist.totalrecords = y.tractormodelslist.tractormodels.Count;
                            y.tractormodelslist.tractormodels.ForEach(z =>
                            {
                                z.tractormodelfeaturelist.totalrecords = z.tractormodelfeaturelist.tractormodelfeatures.Count;
                                z.tractormodelspecificationlist.totalrecords = z.tractormodelspecificationlist.tractormodelspecifications.Count;
                            });
                        });
                    });

                masterModel.masters = masterList;
               


            }
            catch (Exception e)
            {
               
            }

            return masterModel;
        }
    }
}
