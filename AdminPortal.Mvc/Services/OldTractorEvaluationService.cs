using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.OldTractorEvaluation;
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
    public class OldTractorEvaluationService:IOldTractorEvaluation
    {
        private readonly dev_encrypted_generalcustomerappContext _context;
        DateTime fromDate;
        DateTime toDate;

        public OldTractorEvaluationService(dev_encrypted_generalcustomerappContext Context)
        {
            _context = Context;
        }

        public IEnumerable<OldTractorEvaluation> GetOldTractordata(int langid)
        {
            List<OldTractorEvaluation> result = new List<OldTractorEvaluation>();

            {

                fromDate = DateTime.Now.AddMonths(-3);
                toDate = DateTime.Now;

                try
                {
                    
                    List<OldTractorEvaluation> OldTractorEvaluation = (from eq in _context.TblEnquiry
                                                                       join culang in _context.MstCustprofileLang on eq.CreatedbyVc equals culang.CustCodeVc
                                                                       join etlang in _context.MstEnqTypeLang on eq.EnqTypeId equals etlang.EnqTypeId
                                                                       join tmlang in _context.MstTpdhModelLang on eq.TpdhModelcodeVc equals tmlang.ModelcodeVc
                                                                       join imlang in _context.MstIpdhModelLang on eq.IpdhModelcodeVc equals imlang.ModelcodeVc
                                                                       join intmlang in _context.MstTpdhModelLang on eq.IntrestedInIpdhModelcodeVc equals intmlang.ModelcodeVc
                                                                       join inimlang in _context.MstIpdhModelLang on eq.IpdhModelcodeVc equals inimlang.ModelcodeVc
                                                                       join tdlang in _context.TdealermasterLang on eq.DealerCodeVc equals tdlang.DealerCode
                                                                       join delbranchlang in _context.MstDealerbranchhierarchyLang on eq.DealerBranchCodeVc equals delbranchlang.BranchCodeVc
                                                                       where etlang.MstLangId == langid
                                                                       && (eq.EnqTypeId == 3 || eq.EnqTypeId == 4)
                                                                       && tmlang.MstLangId == langid
                                                                       && tdlang.MstLangId == langid
                                                                       && imlang.MstLangId == langid
                                                                       && intmlang.MstLangId == langid
                                                                       && inimlang.MstLangId == langid
                                                                       && culang.MstLangId == langid
                                                                       && delbranchlang.MstLangId == langid

                                                                       select new OldTractorEvaluation
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
                                                                           ISRCAvailable = eq.Isrcavailable,
                                                                           Year_OF_MANUFACTURE = eq.YearOfManufacture,
                                                                           Intrested_IN = eq.IntrestedIn,
                                                                           Intrested_IN_TPDH_MODELNAME_VC = (eq.IntrestedIn == 1 ? intmlang.ModelnameVc : inimlang.ModelnameVc)

                                                                       }).ToList().Where(x => x.CREATEDDT_D >= fromDate && x.CREATEDDT_D <= toDate).ToList();


                    //Udhay added to decrypt customer name
                    //OldTractorEvaluation.ForEach(
                    //    x =>
                    //    {
                    //        x.CustName_VC = Global.DescriptString(x.CustName_VC);
                    //    });

                    OldTractorEvaluation.ForEach(x => x.ImageData = (from eqimagemap in _context.TblEnquiryImageMapping
                                                                     where eqimagemap.EnqId == x.ENQ_ID

                                                                     select new EnquiryImages()
                                                                     {
                                                                         ENQ_ID = eqimagemap.EnqId,
                                                                         Imagepath = eqimagemap.ImagePath
                                                                     }).ToList()
                    );

                    result = OldTractorEvaluation;
                    return result;

                }
                catch (Exception ex)
                {
                    return result;
                }

            }
        }

        public IEnumerable<OldTractorEvaluation> GetOldTractordatabySearch(int langid, DateTime fromdate, DateTime todate, int enqtype, int prodtype)
        {
            List<OldTractorEvaluation> result = new List<OldTractorEvaluation>();

            {

                fromDate = DateTime.Now.AddMonths(-3);
                toDate = DateTime.Now;

                try
                {
                    List<OldTractorEvaluation> OldTractorEvaluation = (from eq in _context.TblEnquiry
                                                                       join culang in _context.MstCustprofileLang on eq.CreatedbyVc equals culang.CustCodeVc
                                                                       join etlang in _context.MstEnqTypeLang on eq.EnqTypeId equals etlang.EnqTypeId
                                                                       join tmlang in _context.MstTpdhModelLang on eq.TpdhModelcodeVc equals tmlang.ModelcodeVc
                                                                       join imlang in _context.MstIpdhModelLang on eq.IpdhModelcodeVc equals imlang.ModelcodeVc
                                                                       join intmlang in _context.MstTpdhModelLang on eq.IntrestedInIpdhModelcodeVc equals intmlang.ModelcodeVc
                                                                       join inimlang in _context.MstIpdhModelLang on eq.IpdhModelcodeVc equals inimlang.ModelcodeVc
                                                                       join tdlang in _context.TdealermasterLang on eq.DealerCodeVc equals tdlang.DealerCode
                                                                       join delbranchlang in _context.MstDealerbranchhierarchyLang on eq.DealerBranchCodeVc equals delbranchlang.BranchCodeVc
                                                                       where etlang.MstLangId == langid
                                                                       && (eq.EnqTypeId == 3 || eq.EnqTypeId == 4)
                                                                       && tmlang.MstLangId == langid
                                                                       && tdlang.MstLangId == langid
                                                                       && imlang.MstLangId == langid
                                                                       && intmlang.MstLangId == langid
                                                                       && inimlang.MstLangId == langid
                                                                       && culang.MstLangId == langid
                                                                       && delbranchlang.MstLangId == langid

                                                                       select new OldTractorEvaluation
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
                                                                           ISRCAvailable = eq.Isrcavailable,
                                                                           Year_OF_MANUFACTURE = eq.YearOfManufacture,
                                                                           Intrested_IN = eq.IntrestedIn,
                                                                           Intrested_IN_TPDH_MODELNAME_VC = (eq.IntrestedIn == 1 ? intmlang.ModelnameVc : inimlang.ModelnameVc)

                                                                       }).ToList().Where(x => x.CREATEDDT_D >= fromDate && x.CREATEDDT_D <= toDate).ToList();


                    //Udhay added to decrypt customer name
                    //OldTractorEvaluation.ForEach(
                    //    x =>
                    //    {
                    //        x.CustName_VC = Global.DescriptString(x.CustName_VC);
                    //    });

                    //if (Convert.ToInt32(formCollection["cmbEnqtype"]) > 0)
                    //{
                    //    OldTractorEvaluation = OldTractorEvaluation.Where(x => x.ENQ_TYPE_ID == Convert.ToInt32(formCollection["cmbEnqtype"])).ToList();
                    //}

                    //if (Convert.ToInt32(formCollection["cmbprodtype"]) > 0)
                    //{
                    //    OldTractorEvaluation = OldTractorEvaluation.Where(x => x.ProductNImplement == Convert.ToInt32(formCollection["cmbprodtype"])).ToList();
                    //}

                    if (enqtype > 0)
                    {
                        OldTractorEvaluation = OldTractorEvaluation.Where(x => x.ENQ_TYPE_ID == enqtype).ToList();
                    }

                    if (prodtype > 0)
                    {
                        OldTractorEvaluation = OldTractorEvaluation.Where(x => x.ProductNImplement == prodtype).ToList();
                    }

                    OldTractorEvaluation.ForEach(x => x.ImageData = (from eqimagemap in _context.TblEnquiryImageMapping
                                                                     where eqimagemap.EnqId == x.ENQ_ID

                        select new EnquiryImages()
                        {
                            ENQ_ID = eqimagemap.EnqId,
                            Imagepath = eqimagemap.ImagePath
                        }).ToList()
                     );



                    result = OldTractorEvaluation;
                    return result;

                }
                catch (Exception ex)
                {
                    return result;
                }

            }
        }

        public IEnumerable<ModelData> GetModeldata()
        {

            {
                List<ModelData> result = new List<ModelData>();

                try
                {
                    List<ModelData> Idata = (from l in _context.MstIpdhModel
                                             join mlang in _context.MstIpdhModelLang on l.ModelcodeVc equals mlang.ModelcodeVc
                                             where mlang.MstLangId == 1
                                             orderby mlang.ModelnameVc ascending
                                             select new ModelData
                                             {
                                                 ModelID = mlang.ModelcodeVc,
                                                 ModelName = mlang.ModelnameVc
                                             }).ToList();

                    List<ModelData> Tdata = (from l in _context.MstTpdhModel
                                             join mlang in _context.MstTpdhModelLang on l.ModelcodeVc equals mlang.ModelcodeVc
                                             where mlang.MstLangId == 1
                                             orderby mlang.ModelnameVc ascending
                                             select new ModelData
                                             {
                                                 ModelID = mlang.ModelcodeVc,
                                                 ModelName = mlang.ModelnameVc
                                             }).ToList();


                    List<ModelData> Modellist = Idata.Union(Tdata).ToList();

                    result = Modellist;
                    return result;


                }
                catch (Exception ex)
                {
                    return result;
                }

            }
        }


        public Boolean Updateenquiry(int enquiryid, string active, string updateduser)
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
