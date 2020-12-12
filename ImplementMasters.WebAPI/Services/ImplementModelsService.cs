using ImplementMasters.WebAPI.DataProvider;
using ImplementMasters.WebAPI.Models.ImplementModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace ImplementMasters.WebAPI.Services
{
    public class ImplementModelsService:IImplementModelsService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;



        private readonly IConfiguration _config;
        private readonly IGlobalService _global;

        string moduleName = "";
        public ImplementModelsService(dev_encrypted_generalcustomerappContext dataContext, IConfiguration config, IGlobalService Global)
        {
            _context = dataContext;
            _config = config;
            _global = Global;

            //Get Module name from config to get the content version
            moduleName = _config.GetValue<string>("ImplementMasters:Implements");
        }

        public MastersModel GetImplementModels(string LanguageCode, string customerCode)
        {
         
            //Get Languages
            List<MstLanguage> languages = _global.GetLanguageList(LanguageCode, customerCode); // _global.GetLanguageList(LanguageCode, customerCode);


                List<IPDHModelGroups> masterList = new List<IPDHModelGroups>();
                foreach (var Language in languages)
                {
                    IPDHModelGroups master = new IPDHModelGroups
                    {
                        contentversion = (from p in _context.TblVersionController
                                          where p.ActiveflagC == "A"
                                          && p.ModuleName == moduleName
                                          select p.Version.Value).FirstOrDefault(),
                        languagecode = Language.LanguageCode,
                        impmodelgrouplist = new IPDHModelGroupsList
                        {
                            impmodelgroups = (from p in _context.MstIpdhModelgroupLang
                                              join o in _context.MstIpdhModelgroup on p.IgcodeVc equals o.IgcodeVc
                                              where p.ActiveflagC == "A" && o.ActiveFlagC == "A"
                                              && p.MstLangId == Language.Id
                                              select new IPDHModelGroup
                                              {
                                                  impmodelgroupid = o.IgcodeVc,
                                                  impmodelgroupname = p.IgnameVc,
                                                  impmodelslist = new IPDHModelsList
                                                  {
                                                      implementmodels = (from i in _context.MstIpdhModelLang
                                                                         join u in _context.MstIpdhModel on i.ModelcodeVc equals u.ModelcodeVc
                                                                         where i.ActiveflagC == "A" && u.ActiveflagC == "A"
                                                                         && u.IgcodeVc == o.IgcodeVc
                                                                         && i.MstLangId == Language.Id
                                                                         select new IPDHModels
                                                                         {
                                                                             modelcode = u.ModelcodeVc,
                                                                             modelname = i.ModelnameVc,
                                                                             modelgroupid = o.IgcodeVc,
                                                                             modelgroupname = p.IgnameVc,
                                                                             imageurl = u.ImagePathVc
                                                                         }).ToList()
                                                  }
                                              }).ToList()
                        }
                    };


                    //Get implement specifications
                    master.impmodelgrouplist.impmodelgroups.ForEach(x => x.impmodelslist.implementmodels.ForEach(
                        y => y.impmodelspecificationslist = new IPDHSpecificationsList
                        {
                            impmodelspecifications = (from p in _context.MstIpdhModelSpecificationLang
                                                      join o in _context.MstIpdhModelSpecification on p.SpecificationId equals o.SpecificationId
                                                      where p.ActiveflagC == "A" && o.ActiveflagC == "A"
                                                      && p.MstLangId == Language.Id
                                                      && o.IpdhModelcodeVc == y.modelcode
                                                      select new IPDHSpecifications
                                                      {
                                                          specificationid = o.SpecificationId,
                                                          specificationcategory = p.SpecificationType,
                                                          specificationname = p.SpecificationName,
                                                          specificationvalue = p.SpecificationValue
                                                      }).ToList()
                        }));

                    //Get implement features
                    master.impmodelgrouplist.impmodelgroups.ForEach(x => x.impmodelslist.implementmodels.ForEach(
                        y => y.impmodelfeatureslist = new IPDHFeaturesList
                        {
                            impmodelfeatures = (from p in _context.MstIpdhModelFeaturesLang
                                                join o in _context.MstIpdhModelFeatures on p.FeatureId equals o.FeatureId
                                                where p.ActiveflagC == "A" && o.ActiveflagC == "A"
                                                && p.MstLangId == Language.Id
                                                && o.IpdhModelcodeVc == y.modelcode
                                                select new IPDHFeatures
                                                {
                                                    featureid = o.FeatureId,
                                                    featurename = p.FeatureName,
                                                    featurevalue = p.FeatureValue
                                                }).ToList()
                        }));

                    //Get implement benefits
                    master.impmodelgrouplist.impmodelgroups.ForEach(x => x.impmodelslist.implementmodels.ForEach(
                        y => y.impmodelbenefitslist = new IPDHBenefitsList
                        {
                            impmodelbenefits = (from p in _context.MstIpdhModelBenefitsLang
                                                join o in _context.MstIpdhModelBenefits on p.BenefitsId equals o.BenefitsId
                                                where p.ActiveflagC == "A" && o.ActiveflagC == "A"
                                                && o.IpdhModelcodeVc == y.modelcode
                                                && p.MstLangId == Language.Id
                                                select new IPDHBenefits
                                                {
                                                    benefitid = o.BenefitsId,
                                                    benefitname = p.BenefitsName,
                                                    benefitvalue = p.FeatureValue
                                                }).ToList()
                        }));


                    //Update the count
                    master.impmodelgrouplist.totalrecords = master.impmodelgrouplist.impmodelgroups.Count;

                    master.impmodelgrouplist.impmodelgroups.ForEach(x =>
                    {
                        x.impmodelslist.totalrecords = x.impmodelslist.implementmodels.Count;
                        x.impmodelslist.implementmodels.ForEach(y =>
                        {
                            y.impmodelfeatureslist.totalrecords = y.impmodelfeatureslist.impmodelfeatures.Count;
                            y.impmodelspecificationslist.totalrecords = y.impmodelspecificationslist.impmodelspecifications.Count;
                            y.impmodelbenefitslist.totalrecords = y.impmodelbenefitslist.impmodelbenefits.Count;
                        });
                    });


                    masterList.Add(master);
                }



                MastersModel masterModel = new MastersModel
                {
                    masters = masterList
                };

              

            masterModel.masters = masterList;

            return masterModel;

        }
    }

}
