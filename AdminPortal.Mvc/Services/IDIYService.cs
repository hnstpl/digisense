using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.DIY;
using Microsoft.AspNetCore.Http;

namespace AdminPortal.Mvc.Services
{
    public interface IDIYService
    {
        IEnumerable<MstDiyVideo> GetAll();
        IEnumerable<MstDiyVideoCategoryLang> GetCategoryByLanguageID(int LanguageID);
        MstDiyVideo CreateMasterVideo(MstDiyVideo Record);
        IEnumerable<VideoProperties> GetVideoProperties(int VategoryID, int LanguageID);
        public DIY GetDIYVideos(int Search, SearchFilters searchFilters);
        public AddNewDIY AddDIYVideos(int Id);
        public int Add(AddNewDIY input);
        public MstDiyVideo GetVideoID(int CategoryID);
        public string GetVideoURL(int VideoId, int IsUpdate, int LanguageId, string Host, IFormFile DIYVideo, string FileName4Video);
    }
}
