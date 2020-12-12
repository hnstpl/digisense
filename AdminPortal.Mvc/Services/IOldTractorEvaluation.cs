using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.OldTractorEvaluation;

namespace AdminPortal.Mvc.Services
{
    public interface IOldTractorEvaluation
    {
        IEnumerable<OldTractorEvaluation> GetOldTractordata(int langid);
        IEnumerable<OldTractorEvaluation> GetOldTractordatabySearch(int langid, DateTime fromdate, DateTime todate, int enqtype, int prodtype);
        IEnumerable<ModelData> GetModeldata();
        Boolean Updateenquiry(int enquiryid, string active, string updateduser);
        IEnumerable<Language> GetLanguagedata();
    }
}
