using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.VideoCategory;

namespace AdminPortal.Mvc.Services
{
    public class VideoCategoryService : IVideoCategoryService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        public VideoCategoryService(dev_encrypted_generalcustomerappContext Context)
        {
            _context = Context;
        }

        public IEnumerable<VideoCategory> GetAll(int LanguageID)
        {
            List<VideoCategory> VideoCategory = (from vc in _context.MstDiyVideoCategory
                                                 join vclang in _context.MstDiyVideoCategoryLang on vc.Id
                                                 equals vclang.DiyId
                                                 join mlang in _context.MstLanguage on vclang.MstLangId equals mlang.Id
                                                 where (LanguageID == 0 || vclang.MstLangId == LanguageID)
                                                 orderby vclang.CategoryName ascending
                                                 select new VideoCategory
                                                 {
                                                     MdiyID = vclang.DiyId,
                                                     MCategory_Name = vclang.CategoryName,
                                                     MACTIVEFLAG_C = (vclang.ActiveflagC == "A" ? "Active" : "In Active")
                                                 }).ToList();
            return VideoCategory;
        }
    }
}
