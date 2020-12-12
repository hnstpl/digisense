using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mandi.WebAPI.Models.MandiModel;
using Mandi.WebAPI.DataProvider;
using Microsoft.EntityFrameworkCore;

namespace Mandi.WebAPI.Services
{
    public class MandiService : IMandiService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        public DateTime epoch = new DateTime(1970, 01, 01);

        public MandiService(dev_encrypted_generalcustomerappContext Context)
        {
            _context = Context;
        }

        public IEnumerable<int?> GetCropSelection(string CustomerCode)
        {
            var cropselection = (from p in _context.TblCutomerCropMapping
                                 where p.ActiveflagC == "A" && p.CustCodeVc == CustomerCode
                                 select p.CropId).Distinct().ToList();

            return cropselection;
        }

        public IEnumerable<int?> GetMandiSelection(string CustomerCode)
        {
            var mandiselection = (from p in _context.TblCutomerMandiMapping
                                  where p.ActiveflagC == "A" && p.CustCodeVc == CustomerCode
                                  select p.MandiId).Distinct().ToList();

            return mandiselection;
        }

        public IEnumerable<MandiModel> GetMandiDataByLanguage(MstLanguage Language, List<int?> MandiList, List<int?> CropList, int DefaultLanguageID)
        {
            //Get list of Mandi
            List<MandiModel> mandi = (from p in _context.MstMandiListLang
                                      join o in _context.MstMandiList on p.MandiId equals o.MandiId
                                      where p.MstLangId == Language.Id
                                      && p.ActiveflagC == "A"
                                      && o.ActiveflagC == "A"
                                     && (MandiList ==null || MandiList.Count == 0 || MandiList.Contains(o.MandiId))
                                      select new MandiModel
                                      {
                                          mandid = p.MandiId,
                                          mandiname = p.MandiName,
                                          districtcode = o.DistrictCodeVc,
                                          districtname = (from i in _context.MstDistrictLang
                                                          where i.ActiveflagC == "A"
                                                          && i.DistrictCodeVc == o.DistrictCodeVc
                                                          && i.MstLangId == Language.Id
                                                          select i.DistrictNameVc).FirstOrDefault() == null ?
                                                                      (from i in _context.MstDistrictLang
                                                                       where i.ActiveflagC == "A"
                                                                       && i.DistrictCodeVc == o.DistrictCodeVc
                                                                       && i.MstLangId == DefaultLanguageID
                                                                       select i.DistrictNameVc).FirstOrDefault() :
                                                                       (from i in _context.MstDistrictLang
                                                                        where i.ActiveflagC == "A"
                                                                        && i.DistrictCodeVc == o.DistrictCodeVc
                                                                        && i.MstLangId == Language.Id
                                                                        select i.DistrictNameVc).FirstOrDefault(),
                                          statecode = o.StateCodeI,
                                          statename = (from i in _context.MstStateLang
                                                       where i.ActiveflagC == "A"
                                                       && i.StateCodeI == o.StateCodeI
                                                       && i.MstLangId == Language.Id
                                                       select i.StateNameVc).FirstOrDefault() == null ?
                                                                  (from i in _context.MstStateLang
                                                                   where i.ActiveflagC == "A"
                                                                   && i.StateCodeI == o.StateCodeI
                                                                   && i.MstLangId == DefaultLanguageID
                                                                   select i.StateNameVc).FirstOrDefault() :
                                                                   (from i in _context.MstStateLang
                                                                    where i.ActiveflagC == "A"
                                                                    && i.StateCodeI == o.StateCodeI
                                                                    && i.MstLangId == Language.Id
                                                                    select i.StateNameVc).FirstOrDefault(),
                                          createdate = o.CreateddtD.HasValue ? dev_encrypted_generalcustomerappContext.DiffSeconds(o.CreateddtD.Value, epoch) : 0,
                                          modifieddate = o.ModifieddtD.HasValue ? dev_encrypted_generalcustomerappContext.DiffSeconds(o.ModifieddtD.Value, epoch) : 0,
                                      }).Distinct().ToList();

            return mandi;
        }

        public IEnumerable<Crop> GetCropForMandi(MstLanguage Language, List<int?> CropsSelection, int MandiID)
        {
            List<Crop> crop= (from p in _context.MstMandiCropMappingLang
                              join o in _context.MstMandiCropMapping on p.MappingId equals o.Id
                              join c in _context.MstMandiCropList on o.CropId equals c.CropId
                              join cl in _context.MstMandiCropListLang on c.CropId equals cl.CropId
                              where p.MstLangId == Language.Id
                              && cl.MstLangId == Language.Id
                              && p.ActiveflagC == "A"
                              && o.ActiveflagC == "A"
                              && o.MandiId == MandiID
                              && (CropsSelection == null || CropsSelection.Count == 0 || CropsSelection.Contains(o.CropId))
                              select new Crop
                              {
                                  cropid = cl.CropId,
                                  cropcode = c.CropCode,
                                  cropname = cl.CropName,
                                  categoryid = c.CategoryId,
                                  categoryname = (p.CategoryName == null ? "" : p.CategoryName),
                                  //arrivaldate = o.Arrival_Date,
                                  arrivaldate = o.ArrivalDate.HasValue ? dev_encrypted_generalcustomerappContext.DiffSeconds(o.ArrivalDate.Value, epoch) : 0,
                                  minprice = o.MinPrice,
                                  maxprice = o.MaxPrice,
                                  imageurl = c.ImageUrl,
                                  lastupdateddate = o.CreateddtD.HasValue ? dev_encrypted_generalcustomerappContext.DiffSeconds(o.CreateddtD.Value, epoch) : 0,
                              }).Distinct().ToList();

            return crop;
        }

        public decimal GetContentVersion(string moduleName)
        {
            var contentversion = (from p in _context.TblVersionController
                                              where p.ActiveflagC == "A"
                                              && p.ModuleName == moduleName
                                              select p.Version.Value).FirstOrDefault();

            return contentversion;

        }
    }
}
