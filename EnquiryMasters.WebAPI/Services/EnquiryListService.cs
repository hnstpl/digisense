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
    public class EnquiryListService :IEnquiryListService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;
        private readonly IConfiguration _config;
        private readonly IGlobalService _global;
        ErrResponse err = new ErrResponse();

        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        string moduleName = "";
        public EnquiryListService(dev_encrypted_generalcustomerappContext dataContext, IConfiguration config, IGlobalService Global)
        {
            _context = dataContext;
            _config = config;
            _global = Global;

            //Get Module name from config to get the content version
            moduleName = _config.GetValue<string>("EnquiryList:EnquiryList");
        }

        public MasterList Get_Enquiries( string LanguageCode , Boolean isSec, long? Offset = null)
        {
                DateTime? dob = null;
                ErrResponse err = new ErrResponse();

                string customerCode = _global.GetCustomerCode();
                //Get Languages
                MstLanguage languages = _global.GetLanguage(LanguageCode, customerCode);

                    MasterList enquiryList = new MasterList
                    {
                        languagecode = languages.LanguageCode,
                        enquirylist = (from p in _context.TblEnquiry
                                       join i in _context.MstEnqType on p.EnqTypeId equals i.EnqTypeId
                                       join y in _context.MstCustprofile on p.CustCodeVc equals y.CustCodeVc
                                       join t in _context.MstCustprofileLang on y.CustCodeVc equals t.CustCodeVc
                                       join r in _context.MstVillage on y.VillageCodeVc equals r.VillageCodeVc
                                       where p.CustCodeVc == customerCode
                                       && (Offset == null || p.CreateddtD > dob)
                                       && t.MstLangId == languages.Id
                                       select new Enquiry
                                       {
                                           isSec = isSec,
                                           enquiryid = p.EnqId,
                                           enquirydate = p.CreateddtD.HasValue ? dev_encrypted_generalcustomerappContext.DiffSeconds(p.CreateddtD.Value, epoch) : 0,
                                           //enquirydate = Convert.ToDouble(p.CreateddtD),
                                           enquirytype = (EnquiryType)i.EnqTypeId,
                                           name = t.CustNameVc,
                                           villagecode = r.VillageCodeVc,
                                           mobile = y.MobileNoVc,
                                           referralname = p.ReferralName,
                                           referralmobile = p.ReferralMobileNoVc,
                                           referralvillagecode = p.ReferralVillageCodeVc,
                                           dealerbranchcode = p.DealerBranchCodeVc,
                                           tractorbrand = p.Tractorbrand,
                                           productflag = p.TpdhModelcodeVc == null ? (ProductFlag)2 : (ProductFlag)1,
                                           modelcode = p.TpdhModelcodeVc == null ? p.IpdhModelcodeVc : p.TpdhModelcodeVc,
                                           yearofmanufacturing = p.YearOfManufacture,
                                           rcavailability = p.Isrcavailable.ToLower().Contains("y") ? true : false,
                                           interestedproduct = p.IntrestedIn.HasValue ? (InterestedProduct)p.IntrestedIn : (InterestedProduct)3,
                                           interestedmodelcode = p.IntrestedIn == 1 ? p.IntrestedInTpdhModelcodeVc : p.IntrestedInIpdhModelcodeVc,
                                           remarks = p.EnqRemarks
                                       }).OrderBy(x => x.enquiryid).Distinct().ToList()
                    };

                    enquiryList.enquirylist.ForEach(
                        x =>
                        {
                            x.imagelist = new ImageList
                            {
                                images = (from e in _context.TblEnquiryImageMapping
                                          where e.EnqId == x.enquiryid
                                          select e.ImagePath).ToList()

                            };

                            //if isSec false
                            if (!isSec)
                            {
                                //x.name = Global.DecryptString(x.name);
                                //x.mobile = Global.DecryptString(x.mobile);

                                x.name = x.name;
                                x.mobile = x.mobile;

                            }
                            else
                            {
                                //x.villagecode = Global.EncryptString(x.villagecode);
                                //x.referralname = Global.EncryptString(x.referralname);
                                //x.referralmobile = Global.EncryptString(x.referralmobile);
                                //x.referralvillagecode = Global.EncryptString(x.referralvillagecode);

                                x.villagecode = x.villagecode;
                                x.referralname = x.referralname;
                                x.referralmobile = x.referralmobile;
                                x.referralvillagecode = x.referralvillagecode;
                            }
                        });

                    enquiryList.totalrecords = enquiryList.enquirylist.Count;

                    return enquiryList;
             
        }
    }
}
