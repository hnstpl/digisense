using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.Global;
using AdminPortal.Mvc.Models.Language;
using System.Globalization;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Text;

namespace AdminPortal.Mvc.Services
{
    public class GlobalService : IGlobalService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        public GlobalService(dev_encrypted_generalcustomerappContext entityContext)
        {
            _context = entityContext;
        }


        public IEnumerable<Language> GetLanguagedata()
        {
            List<Language> result = new List<Language>();

            using (var entities = new dev_encrypted_generalcustomerappContext())
            {
                try
                {

                    List<Language> data = (from l in _context.MstLanguage
                                           orderby l.Id ascending
                                           select new Language
                                           {
                                               Languageid = l.Id,
                                               Languagename = l.LanguageName
                                           }).ToList();

                    result = data;
                    return result;
                }
                catch (Exception ex)
                {
                    return result;
                }
            }
        }

        public IEnumerable<LanguageInfo> GetLanguageAlldata()
        {
            List<LanguageInfo> Language = (from vc in _context.MstLanguage
                                       orderby vc.Id ascending
                                       select new LanguageInfo
                                       {
                                           MLanguageID = vc.Id,
                                           MLanguage_Name = vc.LanguageName,
                                           MTranslate_Name = vc.TranslateName,
                                           MACTIVEFLAG_C = (vc.ActiveflagC == "A" ? "Active" : "In Active")
                                       }).OrderBy(x => x.MLanguageID).ToList();

            return Language;
        }

        public IEnumerable<MstStateLang> GetStatesBylanguageID(int LanguageID)
        {
            return _context.MstStateLang.Where(x => x.ActiveflagC == "A" && x.MstLangId == LanguageID).Distinct().OrderBy(x => x.StateNameVc);
        }
        public IEnumerable<MstDistrictLang> GetDistrictsBylanguageID(int LanguageID)
        {
            return _context.MstDistrictLang.Where(x => x.ActiveflagC == "A" && x.MstLangId == LanguageID).Distinct().OrderBy(x=> x.DistrictNameVc);
        }
        public IEnumerable<MstTipofthedayCategoryLang> GetTipCategoryByLanguageID(int LanguageID)
        {
            return _context.MstTipofthedayCategoryLang.Where(x => x.ActiveflagC == "A" && x.MstLangId == LanguageID).Distinct();
        }

        public DateTime? ConvertStringtoDatetime(string dateTime)
        {
            try
            {
                DateTime OutDateTime = new DateTime();

                if (DateTime.TryParseExact(dateTime.Trim(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out OutDateTime))
                {
                    return OutDateTime;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception e)
            {
                return null;
            }
        }


        //function to save image in a path
        public string SaveImage(string base64String, string filepath, string filename)
        {
            try
            {

                //IHostingEnvironment Environment;
                //Path.Combine(Environment.web, "Uploads");

                //Path.Combine(Environment.WebRootPath, filepath);



                //bool exists = System.IO.Directory.Exists(HttpContext.Current.Server.MapPath(filepath));
                //if (!exists)
                //{
                //    System.IO.Directory.CreateDirectory(HttpContext.Current.Server.MapPath(filepath));
                //}
                //var fullpath = HttpContext.Current.Server.MapPath(filepath);


                //string Actualpath = Path.Combine(Environment.WebRootPath, filepath);





                bool exists = System.IO.Directory.Exists(Path.GetFullPath(filepath).Replace("~\\", ""));
                if (!exists)
                {
                    System.IO.Directory.CreateDirectory(Path.GetFullPath(filepath).Replace("~\\", ""));
                }
                var fullpath = Path.Combine(Path.GetFullPath(filepath).Replace("~\\", ""));

                string base64 = base64String.Substring(base64String.IndexOf(',') + 1);
                var bytess = Convert.FromBase64String(base64);

                using (var imageFile = new FileStream(fullpath + filename, FileMode.Create))
                {
                    imageFile.Write(bytess, 0, bytess.Length);
                    imageFile.Flush();
                }



                return filename;


            }
            catch (Exception ex)
            {
                throw new ApplicationException("while saving image: " + ex.Message);

            }
        }
        public string UploadImage(IFormFile Image, string filename, string ImageVirtualPath)
        {
            string ActualVirtualPath = "";
            try
            {
                ActualVirtualPath = ImageVirtualPath;
                //ImageVirtualPath = ImageVirtualPath;
                string ActualImageName = filename + Path.GetExtension(Image.FileName);
                string filePath = ImageVirtualPath;



                //bool exists = System.IO.Directory.Exists(Server.MapPath(ImageVirtualPath));
                //if (!exists)
                //{
                //    System.IO.Directory.CreateDirectory(Server.MapPath(ImageVirtualPath));
                //}

                //var fullpath = HttpContext.Server.MapPath(filePath);

                bool exists = System.IO.Directory.Exists(Path.GetFullPath(ImageVirtualPath).Replace("~\\", ""));
                if (!exists)
                {
                    System.IO.Directory.CreateDirectory(Path.GetFullPath(ImageVirtualPath).Replace("~\\", ""));
                }
                var fullpath = Path.Combine(Path.GetFullPath(ImageVirtualPath).Replace("~\\", ""));


                if (System.IO.File.Exists(fullpath + ActualImageName))
                {
                    System.IO.File.Delete(fullpath + ActualImageName);
                }
                //Image.co
                //Image.SaveAs(fullpath + ActualImageName);

                using (var fileStream = new FileStream(fullpath + ActualImageName, FileMode.Create))
                {
                    Image.CopyToAsync(fileStream);
                }
                //return path + ActualVirtualPath + ActualImageName;
                return ActualImageName;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public string DecryptString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }
            var obj = new DigisenseCyphering();

            var decryptedvalue = obj.decipher(input.Trim());

            var interValue = System.Convert.FromBase64String(decryptedvalue);

            return Encoding.UTF8.GetString(interValue);

        }
    }
}
