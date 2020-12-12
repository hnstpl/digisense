using AdminPortal.Mvc.Models.Tractors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Services
{
   public interface ITractorsService
    {
        public TractorsMaster GetTractors(int IsSearch, TractorModelSearch tractorModelSearch);
        public IEnumerable<Tractors> GetTractorModelList(int languageID = 1, int CategoryId = 0);
        public string GetThumpImage(string ModelId, int LanguageId);
        public bool Is360Exists(string Modelcode);
        public bool IsDIYExists(string Modelcode, int LanguageId);
        public bool IsBrochureExists(string Modelcode);
        public List<Tractors> GetTractorModelListBySearch(TractorModelSearch tractorModelSearch);
        public IEnumerable<TpdhModels> GetModelList(int LanguageID = 1);
        public IEnumerable<TpdhBrand> GetBrandList(int LanguageID = 1);
        public IEnumerable<TpdhHP> GetHPList(int LanguageID = 1);
        public IEnumerable<VideoLanguages> Languages4Video(int VideoId);
        public IEnumerable<DIYVideosList> GetDIYVideosList4Category(int CategoryId, int LanguageID = 1);
        public UpdateTractorDetails GetUpdateTractorDetails(string ModelId, int LanguageId = 0);
        public IEnumerable<DIYVideoMapping> GetDIYMappingList(string ModelCode, int VideoId);
        public bool UpdateTractorConfiguration(TractorConfiguration tractorConfiguration, string Host);
    }

}
