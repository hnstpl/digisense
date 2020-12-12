using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ServiceHistoryMaster.WebAPI.Models.ServiceHistory
{

    public class ServiceHistoryList
    {
        public List<ServiceHistoryMasterList> servicehistorylist { get; set; }
        public int totalrecords { get; set; }
    }

    public class ServiceHistoryMasterList
    {
        public string languagecode { get; set; }
        public string vinnumber { get; set; }
        public string jobcardnumber { get; set; }
        public double servicedate { get; set; }
        public string servicetype { get; set; }
        public string servicesubtype { get; set; }
        public string serviceadvisor { get; set; }
        public string customercomplaints { get; set; }
        public decimal? estimatedcost { get; set; }
        public string technicianname { get; set; }
        public string jobtype { get; set; }
        public string invoicetype { get; set; }
        public string invoicenumber { get; set; }
        public double invoicedate { get; set; }
        public decimal? partamount { get; set; }
        public decimal? oilamount { get; set; }
        public decimal? labourmmount { get; set; }
        public decimal? subletamount { get; set; }
        public decimal? miscamount { get; set; }
        public decimal? totalinvoiceamount { get; set; }
        public string serviceappointmentno { get; set; }
        public string jobcardstatus { get; set; }
        public double servicestartdate { get; set; }
        public string personbrought { get; set; }
        public string broughtby { get; set; }
        public decimal? kmreading { get; set; }
        public string dealerbranchcode { get; set; }
        public double promisseddeliverydate { get; set; }
        public string hoursreading { get; set; }
        public double nextservicedate { get; set; }
        public decimal? nextservicehours { get; set; }
    }
}
