using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.Dealer;
using AdminPortal.Mvc.GlobalProvider;

namespace AdminPortal.Mvc.Services
{
    public class DealerService : IDealerService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        public DealerService(dev_encrypted_generalcustomerappContext Context)
        {
            _context = Context;
        }

        public IEnumerable<Dealer> GetAll(int LanguageID)
        {
            List<Dealer> Dealer = (from de in _context.Tdealermaster
                                   join delang in _context.TdealermasterLang on de.DealerCode equals delang.DealerCode
                                   join delbranch in _context.MstDealerbranchhierarchy on de.DealerCode equals delbranch.MainDealerCodeVc
                                   join delbranchlang in _context.MstDealerbranchhierarchyLang on delbranch.BranchCodeVc equals delbranchlang.BranchCodeVc
                                   join mlang in _context.MstLanguage on delang.MstLangId equals mlang.Id
                                   where delang.MstLangId == LanguageID && delbranchlang.MstLangId == LanguageID
                                   orderby delang.DealerName ascending
                                   select new Dealer
                                   {
                                       MDealerCode = de.DealerCode,
                                       MDealerName = delang.DealerName,
                                       MAddress = delbranchlang.Address1Vc + "<br/>" + delbranchlang.Address2Vc + "  " + delbranchlang.Address3Vc + "  " + delbranchlang.BranchlLocationVc + "  " + delbranch.PincodeVc + "<br/>" + delbranch.PhoneNoVc,
                                       MStatus = (delbranch.ActiveFlagC == "A" ? "Active" : "In Active"),
                                       MEmail = de.Email,
                                       MLanguagecode = LanguageID,
                                       MLanguagename = mlang.LanguageName,
                                       MBranchName = delbranchlang.BranchNameVc,
                                       MdealerType_vc = String.Concat(delbranch.IsSalesVc , "," , delbranch.IsServiceVc, "," , delbranch.IsSparesVc), // + "," + delbranch.IsSparesVc,//delbranch.IsSalesVc.ToLower() == "yes" ? "Sales" : delbranch.IsServiceVc.ToLower() == "yes" ? "Service" : delbranch.IsSparesVc.ToLower() == "yes" ? "Spares" : "",
                                       MCategoryCode_VC = delbranch.BranchCategoryVc,
                                       MPhone = delbranch.PhoneNoVc,
                                       MMobile = delbranch.MobileNoVc,
                                       MBranchCode_VC = delbranch.BranchCodeVc
                                   }).ToList();

            Dealer = Global.FormatDealerType(Dealer);

            return Dealer;
        }

        public IEnumerable<Dealer> GetByType(int LanguageID, int type)
        {
            List<Dealer> result = new List<Dealer>(); if (type == 0)
            {
                List<Dealer> Dealer = (from de in _context.Tdealermaster

                                       join delang in _context.TdealermasterLang on de.DealerCode equals delang.DealerCode
                                       join delbranch in _context.MstDealerbranchhierarchy on de.DealerCode equals delbranch.MainDealerCodeVc
                                       join delbranchlang in _context.MstDealerbranchhierarchyLang on delbranch.BranchCodeVc equals delbranchlang.BranchCodeVc
                                       join mlang in _context.MstLanguage on delang.MstLangId equals mlang.Id
                                       where delang.MstLangId == LanguageID && delbranchlang.MstLangId == LanguageID
                                       orderby delang.DealerName ascending
                                       select new Dealer
                                       {
                                           MDealerCode = de.DealerCode,
                                           MDealerName = delang.DealerName,
                                           MAddress = delbranchlang.Address1Vc + "<br/>" + delbranchlang.Address2Vc + "  " + delbranchlang.Address3Vc + "  " + delbranchlang.BranchlLocationVc + "  " + delbranch.PincodeVc + "<br/>" + delbranch.PhoneNoVc,
                                           MStatus = (delbranch.ActiveFlagC == "A" ? "Active" : "In Active"),
                                           MEmail = de.Email,
                                           MLanguagecode = LanguageID,
                                           MLanguagename = mlang.LanguageName,
                                           MBranchName = delbranchlang.BranchNameVc,
                                           MdealerType_vc = String.Concat(delbranch.IsSalesVc, ",", delbranch.IsServiceVc, ",", delbranch.IsSparesVc),//                                           delbranch.IsSalesVc.ToLower() == "yes" ? "Sales" : delbranch.IsServiceVc.ToLower() == "yes" ? "Service" : delbranch.IsSparesVc.ToLower() == "yes" ? "Spares" : "",
                                           MCategoryCode_VC = delbranch.BranchCategoryVc,
                                           MPhone = delbranch.PhoneNoVc,
                                           MMobile = delbranch.MobileNoVc,
                                           MBranchCode_VC = delbranch.BranchCodeVc
                                           // (delbranch.isSales_VC.ToLower() == "yes" ? "Active" : "In Active")


                                       }).ToList();

                Dealer = Global.FormatDealerType(Dealer);

                result = Dealer;
            }

            else
            {
                List<Dealer> Dealer = (from de in _context.Tdealermaster

                                       join delang in _context.TdealermasterLang on de.DealerCode equals delang.DealerCode
                                       join delbranch in _context.MstDealerbranchhierarchy on de.DealerCode equals delbranch.MainDealerCodeVc
                                       join delbranchlang in _context.MstDealerbranchhierarchyLang on delbranch.BranchCodeVc equals delbranchlang.BranchCodeVc
                                       join mlang in _context.MstLanguage on delang.MstLangId equals mlang.Id
                                       where delang.MstLangId == LanguageID && delbranchlang.MstLangId == LanguageID && delbranch.IsSalesVc == (type == 1 ? "yes" : null) && delbranch.IsServiceVc == (type == 2 ? "yes" : null) && delbranch.IsSparesVc == (type == 3 ? "yes" : null)
                                       orderby delang.DealerName ascending
                                       select new Dealer
                                       {
                                           MDealerCode = de.DealerCode,
                                           MDealerName = delang.DealerName,
                                           MAddress = delbranchlang.Address1Vc + "<br/>" + delbranchlang.Address2Vc + "  " + delbranchlang.Address3Vc + "  " + delbranchlang.BranchlLocationVc + "  " + delbranch.PincodeVc + "<br/>" + delbranch.PhoneNoVc,
                                           MStatus = (delbranch.ActiveFlagC == "A" ? "Active" : "In Active"),
                                           MEmail = de.Email,
                                           MLanguagecode = LanguageID,
                                           MLanguagename = mlang.LanguageName,
                                           MBranchName = delbranchlang.BranchNameVc,
                                           MdealerType_vc = String.Concat(delbranch.IsSalesVc, ",", delbranch.IsServiceVc, ",", delbranch.IsSparesVc),//                                           delbranch.IsSalesVc.ToLower() == "yes" ? "Sales" : delbranch.IsServiceVc.ToLower() == "yes" ? "Service" : delbranch.IsSparesVc.ToLower() == "yes" ? "Spares" : "",
                                           MCategoryCode_VC = delbranch.BranchCategoryVc,
                                           MPhone = delbranch.PhoneNoVc,
                                           MMobile = delbranch.MobileNoVc,
                                           MBranchCode_VC = delbranch.BranchCodeVc
                                           // (delbranch.isSales_VC.ToLower() == "yes" ? "Active" : "In Active")


                                       }).ToList();

                Dealer = Global.FormatDealerType(Dealer);

                result = Dealer;
            }

            return result;
        }

        public Boolean UpdateByID(string DealerCode, string User, string ActiveFlag, int LanguageID, string BranchCode)
        {
            _context.Tdealermaster.Where(x => x.DealerCode == DealerCode).ToList().ForEach(x =>
            {
                x.ModifiedByVc = User; x.ModifiedDtD = DateTime.UtcNow;
            });
            _context.SaveChanges();

            _context.TdealermasterLang.Where(x => x.DealerCode == DealerCode && x.MstLangId == LanguageID).ToList().ForEach(x =>
            {
                x.ModifiedbyVc = User; x.ModifieddtD = DateTime.UtcNow;
            });
            _context.SaveChanges();

            _context.MstDealerbranchhierarchy.Where(x => x.MainDealerCodeVc == DealerCode && x.BranchCodeVc == BranchCode).ToList().ForEach(x =>
            {
                x.ActiveFlagC = ActiveFlag; x.ModifiedByVc = User; x.ModifiedDtD = DateTime.UtcNow;
            });
            _context.SaveChanges();

            _context.MstDealerbranchhierarchyLang.Where(x => x.BranchCodeVc == DealerCode && x.MstLangId == LanguageID).ToList().ForEach(x =>
            {
                x.ModifiedbyVc = User; x.ModifieddtD = DateTime.UtcNow;
            });
            _context.SaveChanges();

            return true;
        }
    }
}
