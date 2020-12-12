using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnquiryMasters.WebAPI.DataProvider;
using EnquiryMasters.WebAPI.Models.EnquiryList;
using EnquiryMasters.WebAPI.Models.Enquiry;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using EnquiryMasters.WebAPI.Models.Error;
using EnquiryMasters.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnquiryMasters.WebAPI.Services
{
    public interface IEnquiryListService
    {
        public MasterList Get_Enquiries(string LanguageCode, Boolean isSec, long? Offset = null);
    }
}
