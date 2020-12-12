using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnquiryMasters.WebAPI.DataProvider;
using EnquiryMasters.WebAPI.Models.Enquiry;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using EnquiryMasters.WebAPI.Models.Error;
using EnquiryMasters.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace EnquiryMasters.WebAPI.Services
{
    public class EnquiryService : IEnquiryService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;
        private readonly IConfiguration _config;
        private readonly IGlobalService _global;

        string moduleName = "";
        public EnquiryService(dev_encrypted_generalcustomerappContext dataContext, IConfiguration config, IGlobalService Global)
        {
            _context = dataContext;
            _config = config;
            _global = Global;

            //Get Module name from config to get the content version
            moduleName = _config.GetValue<string>("Enquiry:Enquiry");
        }


        public string Submit_Enquiry(Enquiry input)

        {

            ErrResponse err = new ErrResponse();

            try
            {
                string customerCode = _global.GetCustomerCode();

                //Validate for General Enquiry
                if (
                    input.enquirytype == EnquiryType.GeneralEnquiry
                    && (
                    string.IsNullOrEmpty(input.name)
                    || string.IsNullOrEmpty(input.villagecode)
                    || string.IsNullOrEmpty(input.mobile)
                    || (input.mobile.Length != 10 && input.isSec == false)
                    || string.IsNullOrEmpty(input.dealerbranchcode)
                    || (input.productflag != ProductFlag.Tractor && input.productflag != ProductFlag.Implements)
                    || string.IsNullOrEmpty(input.modelcode)
                    || string.IsNullOrEmpty(input.remarks)
                    ))
                {
                    throw new ArgumentException("Insufficient User Information");
                }
                //Validate for Referral Enquiry
                else if (
                    input.enquirytype == EnquiryType.ReferralEnquiry
                    && (
                    string.IsNullOrEmpty(input.referralname)
                    || string.IsNullOrEmpty(input.referralvillagecode)
                    || string.IsNullOrEmpty(input.referralmobile)
                    || (input.referralmobile.Length != 10 && input.isSec == false)
                    || string.IsNullOrEmpty(input.dealerbranchcode)
                    || (input.productflag != ProductFlag.Tractor && input.productflag != ProductFlag.Implements)
                    || string.IsNullOrEmpty(input.modelcode)
                    || string.IsNullOrEmpty(input.remarks)
                    ))
                {
                    throw new ArgumentException("Insufficient Referral Information");
                }
                //Validate Exchange Enquiry
                else if (
                    input.enquirytype == EnquiryType.TractorEvaluationAndExchange
                    && (string.IsNullOrEmpty(input.tractorbrand)
                    || (input.productflag != ProductFlag.Tractor && input.productflag != ProductFlag.Implements)
                    || string.IsNullOrEmpty(input.modelcode)
                    || string.IsNullOrEmpty(input.yearofmanufacturing)
                    || (input.interestedproduct != InterestedProduct.Tractor && input.interestedproduct != InterestedProduct.Implements && input.interestedproduct != InterestedProduct.None)
                    || string.IsNullOrEmpty(input.interestedmodelcode)
                    || string.IsNullOrEmpty(input.remarks)
                    ))
                {
                    throw new ArgumentException("Insufficient Exchange Information");
                }

                //decrypt if encrypted
                if (input.isSec)
                {
                    //input.villagecode = _global.DecryptString(input.villagecode);
                    //input.referralname = _global.DecryptString(input.referralname);
                    //input.referralmobile = _global.DecryptString(input.referralmobile);
                    //input.referralvillagecode = _global.DecryptString(input.referralvillagecode);
                }


                //using (var entities = new dev_generalcustomerappEntities())
                //{

                    var EnquiryRecord = new TblEnquiry
                    {
                        EnqTypeId = (int)input.enquirytype,
                        CustCodeVc = customerCode,
                        DealerBranchCodeVc = !string.IsNullOrEmpty(input.dealerbranchcode) ? input.dealerbranchcode : null,
                        VillageCodeVc = input.villagecode,
                        ProductNimplement = (int)input.productflag,
                        ReferralName = input.referralname,
                        ReferralVillageCodeVc = input.referralvillagecode,
                        ReferralMobileNoVc = input.referralmobile,
                        EnqStatus = "Open",
                        TpdhModelcodeVc = input.productflag == ProductFlag.Tractor ? input.modelcode : null,
                        CreatedbyVc = customerCode,
                        CreateddtD = DateTime.Now,
                        IpdhModelcodeVc = input.productflag == ProductFlag.Implements ? input.modelcode : null,
                        Tractorbrand = input.tractorbrand,
                        Isrcavailable = input.rcavailability ? "Y" : "N",
                        YearOfManufacture = input.yearofmanufacturing,
                        IntrestedIn = (int)input.interestedproduct,
                        IntrestedInTpdhModelcodeVc = input.interestedproduct == InterestedProduct.Tractor ? input.interestedmodelcode : null,
                        IntrestedInIpdhModelcodeVc = input.interestedproduct == InterestedProduct.Implements ? input.interestedmodelcode : null,
                        EnqRemarks = input.remarks
                    };

                       _context.TblEnquiry.Add(EnquiryRecord);

                    if (input.imagelist != null && input.imagelist.images != null)
                    {
                        input.imagelist.images.ForEach(x =>
                        {
                            var EnquiryImageRecord = new TblEnquiryImageMapping
                            {
                                EnqId = EnquiryRecord.EnqId,
                                ImagePath = x,
                                ActiveflagC = "A",
                                CreatedbyVc = customerCode,
                                CreateddtD = DateTime.Now
                            };

                            _context.TblEnquiryImageMapping.Add(EnquiryImageRecord);
                        });
                    }

                    var result = _context.SaveChanges();

                    if (result == 0)
                    {
                    // err.Message = "Unable to submit the Enquiry";
                    //return Request.CreateResponse(HttpStatusCode.BadRequest, err);
                    err.Message = "0";
                    }


                    //err.Message = "Enquiry successfully submitted!";
                    err.Message = EnquiryRecord.EnqId.ToString();
                   // return Request.CreateResponse(HttpStatusCode.OK, err);
               // }
            }
            catch (Exception e)
            {
                //err.Message = e.Message;
                //return Request.CreateResponse(HttpStatusCode.BadRequest, err);
                err.Message = "-1";
            }

            return err.Message;
        }

    }
}
