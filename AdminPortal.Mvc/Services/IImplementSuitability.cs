using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.ImplementSuitability;

namespace AdminPortal.Mvc.Services
{
    public interface IImplementSuitability
    {
        IEnumerable<TractorModel> GetTractordata();
        IEnumerable<TractorModel> GetTractorDataByBrand(string Brandcode);
        IEnumerable<TractorModel> GetBrandList();
        IEnumerable<ImplementModel> GetImplementdata();
        IEnumerable<ImplementModel> GetAvailableImplementdata(string Tractorcode);
        IEnumerable<AvailableAssignment> GetAssignedImplementdata(string Tractorcode);
        Boolean UpdateInActive(string[] TractorcodeArr, string User);
        Boolean AddNewImplementAssignment(string[] TractorcodeArr, string[] implemtassigncodeArr, string User);


    }
}
