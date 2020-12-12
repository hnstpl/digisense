using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.Global;
using AdminPortal.Mvc.Models.Language;
using AdminPortal.Mvc.DataProvider;
using Microsoft.AspNetCore.Http;

namespace AdminPortal.Mvc.Services
{
    public interface IGlobalService
    {
        IEnumerable<Language> GetLanguagedata();
        IEnumerable<LanguageInfo> GetLanguageAlldata();
        IEnumerable<MstStateLang> GetStatesBylanguageID(int LanguageID);
        IEnumerable<MstDistrictLang> GetDistrictsBylanguageID(int LanguageID);
        IEnumerable<MstTipofthedayCategoryLang> GetTipCategoryByLanguageID(int LanguageID);
        DateTime? ConvertStringtoDatetime(string dateTime);

        public string SaveImage(string base64String, string filepath, string filename);
        public string UploadImage(IFormFile Image, string filename, string ImageVirtualPath);

        string DecryptString(string input);
    }
}
