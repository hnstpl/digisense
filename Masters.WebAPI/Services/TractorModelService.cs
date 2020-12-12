using System;
using System.Collections.Generic;
using System.Linq;
using Masters.WebAPI.Helpers;
using Masters.WebAPI.Models;
using Masters.WebAPI.Models.TractorModels;
//using Masters.WebAPI.DataProvider;
//using Masters.WebAPI.GlobalProvider;
using Microsoft.Extensions.Configuration;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Configuration;
using Microsoft.Extensions.Options;
//using Masters.WebAPI.Helpers;

namespace Masters.WebAPI.Services
{
    public class TractorModelService : ITractorModelService
    {
        //private readonly DataContext _context;
        //public ModelService(DataContext dataContext)
        //{
        //    _context = dataContext;
        //}

        //private readonly dev1_generalcustomerappContext _context;

        private readonly AppSettings _appSettings;

        private readonly IOptions<AppSettings> _appSet;

        private readonly IConfiguration _config;

        //public TractorModelService(dev1_generalcustomerappContext dataContext, IConfiguration config)
        //{
        //    _context = dataContext;
        //    _config = config;
        //}

        //public MstTpdhModelLang GetById(int Id)
        //{
        //    return _context.MstTpdhModelLang.SingleOrDefault(m => m.ModelcodeVc == Id.ToString());
        //}

        //public IEnumerable<MstTpdhModel> GetModels()
        //{
        //    return _context.MstTpdhModel.ToList();
        //}


        //public IEnumerable<MstTpdhModel> GetAll()
        //{
        //    return _context.MstTpdhModel.ToList();
        //}


        //public MastersModel GetByLanguage(string LanguageCode)
        //{
        //    //Get the module name to fetch the content version
        //    var moduleName = _config.GetValue<string>("AppSettings:TractorMaster"); //_appSettings.TractorMaster;

        //    List <TPDHModelGroups> TPDHModelList = new List<TPDHModelGroups>();

        //    TPDHModelGroups master = new TPDHModelGroups
        //    {
        //        contentversion = Global.GetContentVersion(moduleName).Version.Value,
        //        languagecode = LanguageCode,
        //        tractormodelgrouplist = new TPDHModelGroupsList
        //        {
        //            tractormodelgroup = (from p in _context.MstTpdhModelgroupLang
        //                                 join o in _context.MstTpdhModelgroup on p.ModelgroupcodeVc equals o.ModelgroupcodeVc into pmt
        //                                 from o in pmt.DefaultIfEmpty()
        //                                 join i in _context.MstLanguage on p.MstLangId equals i.Id
        //                                 where p.ActiveflagC == "A" && o.ActiveflagC == "A" && i.ActiveflagC == "A"
        //                                 && i.LanguageCode == LanguageCode
        //                                 select new TPDHModelGroup
        //                                 {
        //                                     //languagecode = i.LANGUAGE_CODE,
        //                                     groupcode = p.ModelgroupcodeVc,
        //                                     groupname = p.ModelgroupnameVc,
        //                                     tractormodelslist = new TPDHModelsList
        //                                     {
        //                                         tractormodels = (from u in _context.MstTpdhModelLang
        //                                                          join y in _context.MstTpdhModel on u.ModelcodeVc equals y.ModelcodeVc
        //                                                          join t in _context.MstTpdhBrand on y.BrandcodeVc equals t.BrandcodeVc
        //                                                          join r in _context.MstTpdhBrandLang on t.BrandcodeVc equals r.BrandcodeVc
        //                                                          join e in _context.MstTpdhHp on y.HpcodeVc equals e.HpcodeVc
        //                                                          join w in _context.MstTpdhHpLang on e.HpcodeVc equals w.HpcodeVc
        //                                                          where r.MstLangId == i.Id
        //                                                          && u.MstLangId == i.Id
        //                                                          && w.MstLangId == i.Id
        //                                                          && y.ModelgroupcodeVc == p.ModelgroupcodeVc
        //                                                          select new TPDHModels
        //                                                          {
        //                                                              brand = r.BrandnameVc,
        //                                                              hprange = w.HpnameVc,
        //                                                              modelcode = y.ModelcodeVc,
        //                                                              modelname = u.ModelnameVc,
        //                                                              tractormodelspecificationlist = new TPDHModelSpecsList
        //                                                              {
        //                                                                  tractormodelspecifications = (from t in _context.TblTpdhModelSpecificationMappingLang
        //                                                                                                join r in _context.TblTpdhModelSpecificationMapping on t.MappingId equals r.MappingId
        //                                                                                                join e in _context.MstTpdhModelSpecificationLang on r.SpecificationId equals e.SpecificationId
        //                                                                                                where r.ModelcodeVc == y.ModelcodeVc
        //                                                                                                && t.ActiveflagC == "A" && r.ActiveflagC == "A"
        //                                                                                                && t.MstLangId == i.Id
        //                                                                                                && e.MstLangId == i.Id
        //                                                                                                select new TPDHModelSpecs
        //                                                                                                {
        //                                                                                                    specid = r.SpecificationId.Value,
        //                                                                                                    specname = e.SpecificationName,
        //                                                                                                    specvalue = t.SpecificationValue
        //                                                                                                }).ToList()
        //                                                              }
        //                                                          }).ToList()
        //                                     }
        //                                 }).ToList()
        //        }
        //    };

        //    TPDHModelList.Add(master);

        //    var MasterModel = new MastersModel
        //    {
        //        masters = TPDHModelList
        //    };

        //    return MasterModel;
        //}

    }
}
