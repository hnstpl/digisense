using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TractorMasters.WebAPI.DataProvider;
using TractorMasters.WebAPI.Models.ProductMasterInfo;
using System.Configuration;

namespace TractorMasters.WebAPI.Services
{
    public class ProductMasterInfoService:IProductMasterInfoService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        //private readonly AppSettings _appSettings;

        //private readonly IOptions<AppSettings> _appSet;

        private readonly IConfiguration _config;
        private readonly IGlobalService _global;

        string moduleName = "";
        public ProductMasterInfoService(dev_encrypted_generalcustomerappContext dataContext, IConfiguration config, IGlobalService Global)
        {
            _context = dataContext;
            _config = config;
            _global = Global;

            //Get Module name from config to get the content version
            moduleName = _config.GetValue<string>("TractorMasters:TractorMasters");
        }

        public MastersModel GetProductMasterInfo(string LanguageCode, string customerCode)
        {


            MastersModel masterModel = new MastersModel();

            List<MstLanguage> languages = _global.GetLanguageList(LanguageCode, customerCode);



                List<ProductMasterInfo> masterList = new List<ProductMasterInfo>();
                foreach (var Language in languages)
                {
                    ProductMasterInfo master = new ProductMasterInfo
                    {
                        contentversion = (from p in _context.TblVersionController
                                          where p.ActiveflagC == "A"
                                          && p.ModuleName == moduleName
                                          select p.Version.Value).FirstOrDefault(),
                        languagecode = Language.LanguageCode,
                        manufacturerslist = new ManufacturersList
                        {
                            manufacturers = (from p in _context.MstTpdhManufacturerLang
                                             join o in _context.MstTpdhManufacturer on p.MstTpdhManufacturercode equals o.MstTpdhManufacturercode into pmt
                                             from o in pmt.DefaultIfEmpty()
                                             join i in _context.MstLanguage on p.MstLangId equals i.Id into umt
                                             from i in umt.DefaultIfEmpty()
                                             where p.ActiveflagC == "A" && o.ActiveflagC == "A" && i.ActiveflagC == "A"
                                             && i.LanguageCode == Language.LanguageCode
                                             select new Manufacturers
                                             {
                                                 manufacturercode = p.MstTpdhManufacturercode,
                                                 manufacturername = p.MstTpdhManufacturername
                                             }).ToList()
                        },
                        brandslist = new BrandsList
                        {
                            brands = (from p in _context.MstTpdhBrandLang
                                      join o in _context.MstTpdhBrand on p.BrandcodeVc equals o.BrandcodeVc into pmt
                                      from o in pmt.DefaultIfEmpty()
                                      join i in _context.MstLanguage on p.MstLangId equals i.Id
                                      where p.ActiveflagC == "A" && o.ActiveflagC == "A" && i.ActiveflagC == "A"
                                      && i.LanguageCode == Language.LanguageCode
                                      select new Brands
                                      {
                                          brandcode = p.BrandcodeVc,
                                          brandname = p.BrandnameVc
                                      }).ToList()
                        },
                        hplist = new HPList
                        {
                            hp = (from p in _context.MstTpdhHpLang
                                  join o in _context.MstTpdhHp on p.HpcodeVc equals o.HpcodeVc into pmt
                                  from o in pmt.DefaultIfEmpty()
                                  join i in _context.MstLanguage on p.MstLangId equals i.Id
                                  where p.ActiveflagC == "A" && o.ActiveflagC == "A" && i.ActiveflagC == "A"
                                  && i.LanguageCode == Language.LanguageCode
                                  select new HP
                                  {
                                      hpcode = p.HpcodeVc,
                                      hpname = p.HpnameVc
                                  }).ToList()
                        }

                    };
                    masterList.Add(master);
                }

                masterList.ForEach(x =>
                {
                    x.manufacturerslist.totalrecords = x.manufacturerslist.manufacturers.Count;
                    x.brandslist.totalrecords = x.brandslist.brands.Count;
                    x.hplist.totalrecords = x.hplist.hp.Count;
                });

            masterModel.masters = masterList;

            return masterModel;
            
        }

    }
}
