using DIYMaster.WebAPI.Models.DIY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIYMaster.WebAPI.Services
{
   public interface IDIYService
    {
        public MastersModel GetDIY(string LanguageCode, string customerCode);
    }
}
