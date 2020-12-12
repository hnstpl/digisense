using EnquiryMasters.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnquiryMasters.WebAPI.Models.Enquiry;


namespace EnquiryMasters.WebAPI.Services
{
    public interface IEnquiryService
    {
        public string Submit_Enquiry(Enquiry input);
    }
}

