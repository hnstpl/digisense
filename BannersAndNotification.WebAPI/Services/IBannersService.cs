using BannersAndNotification.WebAPI.Models.Banners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BannersAndNotification.WebAPI.Services
{
   public interface IBannersService
    {
        public HomePageModel GetBanners(string LanguageCode, string customerCode);
    }
}
