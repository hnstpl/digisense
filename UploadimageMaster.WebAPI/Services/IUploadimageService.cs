using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UploadimageMaster.WebAPI.Services
{
    public interface IUploadimageService
    {
        public string Uploadimage(string savedFilePath);
    }
}
