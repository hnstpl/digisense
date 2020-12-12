using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.VideoCategory;

namespace AdminPortal.Mvc.Services
{
    public interface IVideoCategoryService
    {
        IEnumerable<VideoCategory> GetAll(int LanguageID);
    }
}
