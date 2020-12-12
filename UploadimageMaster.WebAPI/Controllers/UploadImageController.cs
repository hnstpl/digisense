using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UploadimageMaster.WebAPI.Services;
using UploadimageMaster.WebAPI.Models.Error;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using Microsoft.AspNetCore.Hosting;
using System.Globalization;
using System.IO;
using System.Web;


namespace UploadimageMaster.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadImageController : ControllerBase
    {
        private readonly IUploadimageService _UploadImage;
        private readonly IGlobalService _global;
        public UploadImageController(IUploadimageService UploadImage, IGlobalService Global)
        {
            _UploadImage = UploadImage;
            _global = Global;
        }
        

        [HttpPost]
        [Authorize]
        public IActionResult Uploadimage()
        {

            ErrResponse err = new ErrResponse();

            try
            {
                if (User.Identity.IsAuthenticated)
                {
                   
                    string customerCode = _global.GetCustomerCode();

                    IFormFile postedFile = null;
                    int counter = 0;
                    string extenstion = string.Empty;
                    string savedFilePath = string.Empty;

                    foreach (IFormFile postedFile1 in Request.Form.Files)
                    {
                        
                        counter = 0;
                        if (postedFile1 != null && postedFile1.Length > 0)
                        {
                        
                            counter = 0;
                            var PathFromConfigFile = ConfigurationManager.AppSettings["UploadPath"];
                            var filePath = Path.Combine(Path.GetFullPath(PathFromConfigFile).Replace("~\\", ""));

                            var saveasPath = Path.Combine(filePath, postedFile.FileName);
                            extenstion = Path.GetExtension(saveasPath);
                            saveasPath = Path.ChangeExtension(saveasPath, null);

                            while (System.IO.File.Exists(saveasPath + counter + extenstion))
                            {
                                counter++;
                            }
                           
                            using (var fileStream = new FileStream(saveasPath + counter + extenstion, FileMode.Create))
                            {
                                postedFile.CopyToAsync(fileStream);
                            }

                        }
                    }
                   
                    var savedFilePathFromConfig = ConfigurationManager.AppSettings["savedFilePath"];
                    var location = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}");
                    string hostName = location.Scheme + "://" + location.Host + ":" + location.Port + "/";
                    savedFilePath = hostName + savedFilePathFromConfig + Path.ChangeExtension(postedFile.FileName, null) + counter + extenstion;



                    if (string.IsNullOrEmpty(savedFilePath))
                    {
                        err.Message = "Unable to upload image";
                        return BadRequest(err);
                    }

                    savedFilePath =  _UploadImage.Uploadimage(savedFilePath);

                    err.Message = savedFilePath;
                    return Ok(err);
                }
                else
                {
                    err.Message = "Unauthorized entry";
                    return Unauthorized(err);
                }

                //foreach(MultipartFileData file in provider.FileData)
                //{
                //    filename = file.LocalFileName;
                //}

            }
            catch (Exception e)
            {
                return BadRequest(err);
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
    }
}
