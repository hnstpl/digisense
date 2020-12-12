using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.Enquiry;

namespace AdminPortal.Mvc.Services
{
    public interface IEnquiry
    {
        IEnumerable<Enquiry> GetEnquirydata(int langid);
        IEnumerable<Enquiry> GetEnquirydatabySearch(int langid, DateTime fromdate, DateTime todate, int enqtype, int prodtype);
        Boolean Updateenquiry(int enquiryid, string active, string updateduser);
        IEnumerable<Language> GetLanguagedata();
    }
}
