using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.Implements;

namespace AdminPortal.Mvc.Services
{
    public interface IImplements
    {
        IEnumerable<ImpCategory> GetCategoryList(int LanguageID = 1);
        IEnumerable<Implements> GetImplementModelListBySearch(int languageID, List<string> SelectedCategory);
        IEnumerable<Implements> GetImplementModelList(int languageID, int CategoryId = 0);
        Boolean UpdateImplementsConfiguration(ImplementConfiguration implementConfiguration,string Host);
        public string SaveImage(string base64String, string filepath, string filename);
        IEnumerable<Benefits> GetBenefitsList(string ModelId, int LanguageId = 0);
        IEnumerable<Features> GetfeatureList(string ModelId, int LanguageId = 0);
        IEnumerable<Specification> GetSpecificationList(string ModelId, int LanguageId = 0);

        public UpdateImplementsDetails UpdateImplementDetails(string ModelId, int LanguageId);


    }
}

