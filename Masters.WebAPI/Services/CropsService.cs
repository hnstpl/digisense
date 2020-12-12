using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Masters.WebAPI.Models.CropsMaster;
using Masters.WebAPI.DataProvider;

namespace Masters.WebAPI.Services
{
    public class CropsService : ICropsService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        public CropsService(dev_encrypted_generalcustomerappContext Context)
        {
            _context = Context;
        }

        public CropsMaster GetCropDataByLanguage(MstLanguage Language, string ModuleName)
        {
            CropsMaster master = new CropsMaster
            {
                contentversion = (from p in _context.TblVersionController
                                  where p.ActiveflagC == "A"
                                  && p.ModuleName == ModuleName
                                  select p.Version.Value).FirstOrDefault(),
                languagecode = Language.LanguageCode,
                cropslist = new CropsList
                {
                    crops = (from p in _context.MstMandiCropListLang
                             join o in _context.MstMandiCropList on p.CropId equals o.CropId
                             join i in _context.MstMandiCropCategory on o.CategoryId equals i.CategoryId
                             join u in _context.MstMandiCropCategoryLang on i.CategoryId equals u.CategoryId
                             where p.MstLangId == Language.Id
                             && u.MstLangId == Language.Id
                             select new Crops
                             {
                                 cropid = o.CropId,
                                 cropcode = o.CropCode,
                                 cropname = p.CropName,
                                 categoryid = i.CategoryId,
                                 categoryname = u.CategoryName,
                                 imageurl = o.ImageUrl,
                                 imageversion = o.ImageUrlVr.HasValue ? o.ImageUrlVr.Value : 0
                             }).ToList()
                }
            };

            return master;
        }
    }
}
