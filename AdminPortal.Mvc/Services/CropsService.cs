using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.Crop;

namespace AdminPortal.Mvc.Services
{
    public class CropsService : ICropsService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        public CropsService(dev_encrypted_generalcustomerappContext Context)
        {
            _context = Context;
        }

        public IEnumerable<MandiList> GetMandiByLanguageID(int? LanguageID)
        {
            var Mandilist = (from p in _context.MstMandiList
                             join o in _context.MstMandiListLang on p.MandiId equals o.MandiId
                             where p.ActiveflagC == "A"
                             && o.ActiveflagC == "A"
                             && (LanguageID == null || o.MstLangId == LanguageID)
                             select new MandiList
                             {
                                 Mandi_ID = p.MandiId,
                                 Mandi_Name = o.MandiName
                             }).ToList();

            return Mandilist;
        }

        public IEnumerable<CropData> GetCropDataByLanguageID(int LanguageID)
        {

            List<CropData> CropData = (from p in _context.MstMandiCropList
                                       join o in _context.MstMandiCropListLang on p.CropId equals o.CropId
                                       join d in _context.MstMandiCropMapping on p.CropId equals d.CropId
                                       join s in _context.MstMandiListLang on d.MandiId equals s.MandiId
                                       join c in _context.MstMandiCropCategoryLang on d.CategoryId equals c.CategoryId
                                       where o.MstLangId == LanguageID
                                       && s.MstLangId == LanguageID
                                       && c.MstLangId == LanguageID
                                       select new CropData
                                       {
                                           CropID = p.CropId,
                                           CropName = o.CropName,
                                           ImageURL = p.ImageUrl,
                                           MandiName = s.MandiName,
                                           CategoryName = c.CategoryName,
                                           ArrivalDate = d.ArrivalDate/*DbFunctions.TruncateTime*/,
                                           MinPrice = d.MinPrice,
                                           MaxPrice = d.MaxPrice,
                                           ModalPrice = d.ModalPrice,
                                           ACTIVEFLAG_C = (p.ActiveflagC == "A" ? "Active" : "In Active"),
                                           MandiID = d.MandiId,
                                           MODIFIEDDT_D = (d.ModifieddtD == null ? d.CreateddtD : d.ModifieddtD) //DbFunctions.TruncateTime
                                       }).OrderBy(x => x.CropID).Distinct().ToList();

            return CropData;
        }
    }
}
