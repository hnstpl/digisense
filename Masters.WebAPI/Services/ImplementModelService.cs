using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Masters.WebAPI.Models;
//using Masters.WebAPI.DataProvider;
using Masters.WebAPI.Models.ImplementModels;
using Masters.WebAPI.Helpers;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;

namespace Masters.WebAPI.Services
{
    public class ImplementModelService : IImplementModelService
    {
        //private readonly dev1_generalcustomerappContext _context;

        private readonly IConfiguration _config;

        private readonly IGlobalService _global;

        //public ImplementModelService(dev1_generalcustomerappContext DataContext, IConfiguration Config, IGlobalService Global)
        //{
        //    _context = DataContext;
        //    _config = Config;
        //    _global = Global;
        //}


        //public IEnumerable<MstIpdhModelLang> GetModels()
        //{
        //    return _context.MstIpdhModelLang.Where(x => x.ActiveflagC == "A").Distinct();
        //}


        //public MstIpdhModelLang GetByCode(string Code)
        //{
        //    return _context.MstIpdhModelLang.Where(x => x.ModelcodeVc == Code && x.ActiveflagC == "A").Distinct().FirstOrDefault();
        //}


        //public MastersModel GetByLanguage(string LanguageCode)
        //{
        //    try
        //    {
        //        //Pending for Token claims
        //        //Get Customer code from token
        //        //string customerCode = Global.GetCustomerCode();

        //        //Get the module name to fetch the content version
        //        var moduleName = _config.GetValue<string>("AppSettings:TractorMaster"); //_appSettings.TractorMaster;

        //        //GetLanguage
        //        var Language = _global.GetLanguageByCode(LanguageCode);

        //        List<IPDHModelGroups> masterList = new List<IPDHModelGroups>();
        //        IPDHModelGroups master = new IPDHModelGroups
        //        {
        //            contentversion = (from p in _context.TblVersionController
        //                              where p.ActiveflagC == "A"
        //                              && p.ModuleName == moduleName
        //                              select p.Version.Value).FirstOrDefault(),
        //            languagecode = LanguageCode,
        //            impmodelgrouplist = new IPDHModelGroupsList
        //            {
        //                impmodelgroups = (from p in _context.MstIpdhModelgroupLang
        //                                  join o in _context.MstIpdhModelgroup on p.IgcodeVc equals o.IgcodeVc
        //                                  where p.ActiveflagC == "A" && o.ActiveFlagC == "A"
        //                                  && p.MstLangId == Language.Id
        //                                  select new IPDHModelGroup
        //                                  {
        //                                      impmodelgroupid = o.IgcodeVc,
        //                                      impmodelgroupname = p.IgnameVc,
        //                                      impmodelslist = new IPDHModelsList
        //                                      {
        //                                          implementmodels = (from i in _context.MstIpdhModelLang
        //                                                             join u in _context.MstIpdhModel on i.ModelcodeVc equals u.ModelcodeVc
        //                                                             where i.ActiveflagC == "A" && u.ActiveflagC == "A"
        //                                                             && u.IgcodeVc == o.IgcodeVc
        //                                                             && i.MstLangId == Language.Id
        //                                                             select new IPDHModels
        //                                                             {
        //                                                                 modelcode = u.ModelcodeVc,
        //                                                                 modelname = i.ModelnameVc,
        //                                                                 modelgroupid = o.IgcodeVc,
        //                                                                 modelgroupname = p.IgnameVc,
        //                                                                 imageurl = u.ImagePathVc
        //                                                             }).ToList()
        //                                      }
        //                                  }).ToList()
        //            }
        //        };


        //        //Get implement specifications
        //        master.impmodelgrouplist.impmodelgroups.ForEach(x => x.impmodelslist.implementmodels.ForEach(
        //            y => y.impmodelspecificationslist = new IPDHSpecificationsList
        //            {
        //                impmodelspecifications = (from p in _context.MstIpdhModelSpecificationLang
        //                                          join o in _context.MstIpdhModelSpecification on p.SpecificationId equals o.SpecificationId
        //                                          where p.ActiveflagC == "A" && o.ActiveflagC == "A"
        //                                          && p.MstLangId == Language.Id
        //                                          && o.IpdhModelcodeVc == y.modelcode
        //                                          select new IPDHSpecifications
        //                                          {
        //                                              specificationid = o.SpecificationId,
        //                                              specificationcategory = p.SpecificationType,
        //                                              specificationname = p.SpecificationName,
        //                                              specificationvalue = p.SpecificationValue
        //                                          }).ToList()
        //            }));

        //        //Get implement features
        //        master.impmodelgrouplist.impmodelgroups.ForEach(x => x.impmodelslist.implementmodels.ForEach(
        //            y => y.impmodelfeatureslist = new IPDHFeaturesList
        //            {
        //                impmodelfeatures = (from p in _context.MstIpdhModelFeaturesLang
        //                                    join o in _context.MstIpdhModelFeatures on p.FeatureId equals o.FeatureId
        //                                    where p.ActiveflagC == "A" && o.ActiveflagC == "A"
        //                                    && p.MstLangId == Language.Id
        //                                    && o.IpdhModelcodeVc == y.modelcode
        //                                    select new IPDHFeatures
        //                                    {
        //                                        featureid = o.FeatureId,
        //                                        featurename = p.FeatureName,
        //                                        featurevalue = p.FeatureValue
        //                                    }).ToList()
        //            }));

        //        //Get implement benefits
        //        master.impmodelgrouplist.impmodelgroups.ForEach(x => x.impmodelslist.implementmodels.ForEach(
        //            y => y.impmodelbenefitslist = new IPDHBenefitsList
        //            {
        //                impmodelbenefits = (from p in _context.MstIpdhModelBenefitsLang
        //                                    join o in _context.MstIpdhModelBenefits on p.BenefitsId equals o.BenefitsId
        //                                    where p.ActiveflagC == "A" && o.ActiveflagC == "A"
        //                                    && o.IpdhModelcodeVc == y.modelcode
        //                                    && p.MstLangId == Language.Id
        //                                    select new IPDHBenefits
        //                                    {
        //                                        benefitid = o.BenefitsId,
        //                                        benefitname = p.BenefitsName,
        //                                        benefitvalue = p.FeatureValue
        //                                    }).ToList()
        //            }));


        //        //Update the count
        //        master.impmodelgrouplist.totalrecords = master.impmodelgrouplist.impmodelgroups.Count;

        //        master.impmodelgrouplist.impmodelgroups.ForEach(x =>
        //        {
        //            x.impmodelslist.totalrecords = x.impmodelslist.implementmodels.Count;
        //            x.impmodelslist.implementmodels.ForEach(y =>
        //            {
        //                y.impmodelfeatureslist.totalrecords = y.impmodelfeatureslist.impmodelfeatures.Count;
        //                y.impmodelspecificationslist.totalrecords = y.impmodelspecificationslist.impmodelspecifications.Count;
        //                y.impmodelbenefitslist.totalrecords = y.impmodelbenefitslist.impmodelbenefits.Count;
        //            });
        //        });


        //        masterList.Add(master);


        //        MastersModel masterModel = new MastersModel
        //        {
        //            masters = masterList
        //        };

        //        return masterModel;

        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}
    }
}
