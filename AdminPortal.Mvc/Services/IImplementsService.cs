using AdminPortal.Mvc.Models.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Services
{
   public interface IImplementsService
    {
        public ImplementMaster GetImplementMaster(int IsSearch, ImplementModelSearch implementModelSearch);
        public IEnumerable<Implements> GetImplementModelListBySearch(int languageID, List<string> SelectedCategory);
        public IEnumerable<Implements> GetImplementModelList(int languageID, int CategoryId = 0);
        public IEnumerable<ImpCategory> GetCategoryList(int LanguageID = 1);        
        public Boolean UpdateImplementConfigDetails(ImplementConfiguration implementConfiguration, string Host);
        public UpdateImplementsDetails GetUpdateImplementDetails(string ModelId, int LanguageId);
        public IEnumerable<Specification> GetSpecificationList(string ModelId, int LanguageId = 0);
        public IEnumerable<Benefits> GetBenefitsList(string ModelId, int LanguageId = 0);
        public IEnumerable<Features> GetfeatureList(string ModelId, int LanguageId = 0);
    }
}
