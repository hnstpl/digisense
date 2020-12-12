using BannersAndNotification.WebAPI.Models.BannerActionMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BannersAndNotification.WebAPI.Services
{
   public interface IBannerActionMasterService
    {
        public MastersModel GetBannerActionTypes(string LanguageCode, string customerCode);
    }
}
