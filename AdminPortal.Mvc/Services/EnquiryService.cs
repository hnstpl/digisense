using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.Enquiry;
using AdminPortal.Mvc.GlobalProvider;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Globalization;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;


namespace AdminPortal.Mvc.Services
{
    public class EnquiryService : IEnquiry
    {

        private readonly dev_encrypted_generalcustomerappContext _context;

        private readonly IGlobalService _global;

        DateTime fromDate;
        DateTime toDate;



        public EnquiryService(dev_encrypted_generalcustomerappContext Context, IGlobalService Global)
        {
            _context = Context;
            _global = Global;
        }
        
        public IEnumerable<Enquiry> GetEnquirydata(int langid)
        {
            List<Enquiry> result = new List<Enquiry>();

            {

                fromDate = DateTime.Now.AddMonths(-3);
                toDate = DateTime.Now;

                try
                {
                    List<Enquiry> Enquiry = (from eq in _context.TblEnquiry
                                             join culang in _context.MstCustprofileLang on eq.CreatedbyVc equals culang.CustCodeVc
                                             join enrolcust in _context.SrMshreeEnrolcustHdr on eq.CreatedbyVc equals enrolcust.Customercode
                                             join etlang in _context.MstEnqTypeLang on eq.EnqTypeId equals etlang.EnqTypeId
                                             join tmlang in _context.MstTpdhModelLang on eq.TpdhModelcodeVc equals tmlang.ModelcodeVc
                                             join imlang in _context.MstIpdhModelLang on eq.IpdhModelcodeVc equals imlang.ModelcodeVc
                                             join tdlang in _context.TdealermasterLang on eq.DealerCodeVc equals tdlang.DealerCode
                                             join delbranchlang in _context.MstDealerbranchhierarchyLang on eq.DealerBranchCodeVc equals delbranchlang.BranchCodeVc
                                             where etlang.MstLangId == langid
                                             && (eq.EnqTypeId == 1 || eq.EnqTypeId == 2)
                                             && tmlang.MstLangId == langid
                                             && tdlang.MstLangId == langid
                                             && imlang.MstLangId == langid
                                             && culang.MstLangId == langid
                                             && delbranchlang.MstLangId == langid

                                             select new Enquiry
                                             {
                                                 ENQ_ID = eq.EnqId,
                                                 CustName_VC = culang.CustNameVc,
                                                 EnqTypeName = etlang.EnqTypeName,
                                                 TPDH_MODELNAME_VC = (eq.ProductNimplement == 1 ? tmlang.ModelnameVc : imlang.ModelnameVc),
                                                 DealerName = tdlang.DealerName,
                                                 ENQ_STATUS = (eq.EnqStatus == "open" ? "Open" : "Closed"),
                                                 ProductNImplement = eq.ProductNimplement,
                                                 ENQ_REMARKS = eq.EnqRemarks,
                                                 DealerBranchName_VC = delbranchlang.BranchNameVc,
                                                 CREATEDDT_D = eq.CreateddtD,
                                                 MemberShipNp = enrolcust.MembershipNo,
                                                 MemberShipDate = enrolcust.Membershipdate,
                                                 Intrested_IN = eq.IntrestedIn


                                             }).ToList().Where(x => x.CREATEDDT_D >= fromDate && x.CREATEDDT_D <= toDate).ToList();

                    //Udhay added to decrypt customer name
                    Enquiry.ForEach(
                        x =>
                        {
                            x.CustName_VC = _global.DecryptString(x.CustName_VC);
                        });

                    result = Enquiry;
                    return result;

                }
                catch (Exception ex)
                {
                    return result;
                }

            }
        }

        public IEnumerable<Enquiry> GetEnquirydatabySearch(int langid,DateTime fromdate,DateTime todate,int enqtype,int prodtype)
        {
            List<Enquiry> result = new List<Enquiry>();

            {

                fromDate = DateTime.Now.AddMonths(-3);
                toDate = DateTime.Now;

                try
                {
                    List<Enquiry> Enquiry = (from eq in _context.TblEnquiry
                                             join culang in _context.MstCustprofileLang on eq.CreatedbyVc equals culang.CustCodeVc
                                             join enrolcust in _context.SrMshreeEnrolcustHdr on eq.CreatedbyVc equals enrolcust.Customercode
                                             join etlang in _context.MstEnqTypeLang on eq.EnqTypeId equals etlang.EnqTypeId
                                             join tmlang in _context.MstTpdhModelLang on eq.TpdhModelcodeVc equals tmlang.ModelcodeVc
                                             join imlang in _context.MstIpdhModelLang on eq.IpdhModelcodeVc equals imlang.ModelcodeVc
                                             join tdlang in _context.TdealermasterLang on eq.DealerCodeVc equals tdlang.DealerCode
                                             join delbranchlang in _context.MstDealerbranchhierarchyLang on eq.DealerBranchCodeVc equals delbranchlang.BranchCodeVc
                                             where etlang.MstLangId == langid
                                             && (eq.EnqTypeId == 1 || eq.EnqTypeId == 2)
                                             && tmlang.MstLangId == langid
                                             && tdlang.MstLangId == langid
                                             && imlang.MstLangId == langid
                                             && culang.MstLangId == langid
                                             && delbranchlang.MstLangId == langid

                                             select new Enquiry
                                             {
                                                 ENQ_ID = eq.EnqId,
                                                 CustName_VC = culang.CustNameVc,
                                                 EnqTypeName = etlang.EnqTypeName,
                                                 TPDH_MODELNAME_VC = (eq.ProductNimplement == 1 ? tmlang.ModelnameVc : imlang.ModelnameVc),
                                                 DealerName = tdlang.DealerName,
                                                 ENQ_STATUS = (eq.EnqStatus == "open" ? "Open" : "Closed"),
                                                 ProductNImplement = eq.ProductNimplement,
                                                 ENQ_REMARKS = eq.EnqRemarks,
                                                 DealerBranchName_VC = delbranchlang.BranchNameVc,
                                                 CREATEDDT_D = eq.CreateddtD,
                                                 MemberShipNp = enrolcust.MembershipNo,
                                                 MemberShipDate = enrolcust.Membershipdate,
                                                 Intrested_IN = eq.IntrestedIn,
                                                 ENQ_TYPE_ID = eq.EnqTypeId


                                             }).ToList().Where(x => x.CREATEDDT_D >= fromDate && x.CREATEDDT_D <= toDate).ToList();

                    //Udhay added to decrypt customer name
                    //Enquiry.ForEach(
                    //    x =>
                    //    {
                    //        x.CustName_VC = Global.DescriptString(x.CustName_VC);
                    //    });

                    if (enqtype > 0)
                    {
                        Enquiry = Enquiry.Where(x => x.ENQ_TYPE_ID == enqtype).ToList();
                    }

                    if (prodtype > 0)
                    {
                        Enquiry = Enquiry.Where(x => x.ProductNImplement == prodtype).ToList();
                    }


                    result = Enquiry;
                    return result;

                }
                catch (Exception ex)
                {
                    return result;
                }

            }
        }


        public Boolean Updateenquiry(int enquiryid, string active,string updateduser)
        {

           // string message = "sucess";
            try
            {

                //int enquiryid = Convert.ToInt32(formCollection["enquiryid"]);
                // string active = formCollection["active"];
                //using (dev_digisenseEntities db = new dev_digisenseEntities())
                //  {
                _context.TblEnquiry.Where(x => x.EnqId == enquiryid).ToList().ForEach(x =>
                    {
                        x.EnqStatus = active; x.ModifiedbyVc = updateduser; x.ModifieddtD = DateTime.UtcNow;
                    });
                _context.SaveChanges();
               // }

                return true;
            }
            catch (Exception e)
            {
               // message = "error";
                return false;
            }


        }


        public IEnumerable<Language> GetLanguagedata()
        {

            {
                List<Language> result = new List<Language>();
            
                try
                {

                    List<Language> data = (from l in _context.MstLanguage
                                           orderby l.LanguageName ascending
                                           select new Language
                                           {
                                               Languageid = l.Id,
                                               Languagename = l.LanguageName

                                           }).ToList();

                    result = data;
                    return result;
                }
                catch (Exception ex)
                {
                    return result;
                }

            }
        }

    }

}
