using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceHistoryMaster.WebAPI.DataProvider;
using ServiceHistoryMaster.WebAPI.Models.ServiceHistory;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using ServiceHistoryMaster.WebAPI.Models.Error;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;


namespace ServiceHistoryMaster.WebAPI.Services
{
    public class ServiceHistoryService:IServiceHistoryService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;
        private readonly IConfiguration _config;
        private readonly IGlobalService _global;
        ErrResponse err = new ErrResponse();

        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        string moduleName = "";
        public ServiceHistoryService(dev_encrypted_generalcustomerappContext dataContext, IConfiguration config, IGlobalService Global)
        {
            _context = dataContext;
            _config = config;
            _global = Global;

            //Get Module name from config to get the content version
            moduleName = _config.GetValue<string>("ServiceHistory:ServiceHistory");
        }


        public ServiceHistoryList  Get_ServiceHistory()
        {

            ErrResponse err = new ErrResponse();

                string customerCode = _global.GetCustomerCode();

                    var ServiceHistoryRecords = (from p in _context.SrJobcardHdr
                                                 join o in _context.PsCusttractorDtl on p.Trsrno equals o.SerialNoVc
                                                 where p.CustCodeVc == customerCode
                                                 && p.IsDeleteC == "N"
                                                 select new ServiceHistoryMasterList
                                                 {
                                                     languagecode = (from i in _context.MstCustprofile
                                                                     join u in _context.MstLanguage on i.LanguagePreference equals u.Id
                                                                     where u.ActiveflagC == "A"
                                                                     && i.CustCodeVc == customerCode
                                                                     select u.LanguageCode).FirstOrDefault(),
                                                     vinnumber = p.Trsrno,
                                                     jobcardnumber = p.Jobcardno,
                                                     servicedate = p.JobcarddateandTime.HasValue ? dev_encrypted_generalcustomerappContext.DiffSeconds(p.JobcarddateandTime.Value, epoch) : 0,
                                                     servicetype = p.Servicetype,
                                                     servicesubtype = p.JcserviceSubTypeC,
                                                     serviceadvisor = p.Serviceadvisor,
                                                     customercomplaints = p.CustComplaintNt,
                                                     estimatedcost = p.Estimatedcost.HasValue ? p.Estimatedcost : 0,
                                                     technicianname = p.Technicianname,
                                                     jobtype = p.Jobtype,
                                                     invoicetype = p.InvoiceType,
                                                     invoicenumber = p.InvoiceNo,
                                                     invoicedate = p.Invoicedate.HasValue ? dev_encrypted_generalcustomerappContext.DiffSeconds(p.Invoicedate.Value, epoch) : 0,
                                                     partamount = p.PartAmount,
                                                     oilamount = p.TotalOilAmount,
                                                     labourmmount = p.LabourAmount,
                                                     subletamount = p.SubletAmount,
                                                     miscamount = p.MiscAmount,
                                                     totalinvoiceamount = p.PartAmount + p.LabourAmount + p.SubletAmount + p.MiscAmount,
                                                     serviceappointmentno = p.ServAppointNoVc,
                                                     jobcardstatus = p.JcstatusC,
                                                     servicestartdate = p.ServiceStartDateD.HasValue ? dev_encrypted_generalcustomerappContext.DiffSeconds(p.ServiceStartDateD.Value, epoch) : 0,
                                                     personbrought = p.PersonBroughtVc,
                                                     broughtby = p.BroughtByVc,
                                                     kmreading = p.KmReadingN,
                                                     dealerbranchcode = p.DealerBranchCodeVc, 
                                                     promisseddeliverydate = p.PromiseddelryDateD.HasValue ? dev_encrypted_generalcustomerappContext.DiffSeconds(p.PromiseddelryDateD.Value, epoch) : 0,
                                                     hoursreading = p.HoursReadingVc,
                                                     //nextservicedate = p.Jobcardclosedate.HasValue ? DbFunctions.DiffSeconds(DbFunctions.AddDays(p.Jobcardclosedate.Value, 90), epoch).Value : 0,
                                                     nextservicedate = Convert.ToDouble(p.Jobcardclosedate),
                                                     nextservicehours = p.KmReadingN.HasValue ? (p.KmReadingN.Value + 300) : 0
                                                 }).Distinct().ToList();

                    var ServiceHistoryList = new ServiceHistoryList
                    {
                        servicehistorylist = ServiceHistoryRecords,
                        totalrecords = ServiceHistoryRecords.Count
                    };

                return ServiceHistoryList;
                

        }
    }
}
