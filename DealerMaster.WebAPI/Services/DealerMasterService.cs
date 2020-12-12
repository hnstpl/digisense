using DealerMaster.WebAPI.DataProvider;
using DealerMaster.WebAPI.Models.Dealers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace DealerMaster.WebAPI.Services
{
    public class DealerMasterService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;



        private readonly IConfiguration _config;
        private readonly IGlobalService _global;

        string moduleName = "";
        public DealerMasterService(dev_encrypted_generalcustomerappContext dataContext, IConfiguration config, IGlobalService Global)
        {
            _context = dataContext;
            _config = config;
            _global = Global;

            //Get Module name from config to get the content version
            moduleName = _config.GetValue<string>("DealerMaster:DealerMaster");
        }

        public MastersModel GetDealers(string LanguageCode, string customerCode)
        {

            MastersModel masterModel = new MastersModel();


            //Get Languages
            List<MstLanguage> languages = _global.GetLanguageList(LanguageCode, customerCode);

            List<DealerMaster.WebAPI.Models.Dealers.DealerMaster> masterList = new List<DealerMaster.WebAPI.Models.Dealers.DealerMaster>();
            foreach (var Language in languages)
            {
                int LanguageID = Language.Id;

                var IsDealerInfoAvailForTargetLanguage = _context.TdealermasterLang.Where(x => x.MstLangId == LanguageID).FirstOrDefault() != null ? true : false;

                if (!IsDealerInfoAvailForTargetLanguage) LanguageID = Convert.ToInt32(ConfigurationManager.AppSettings["DefaultLanguageID"]);

                DealerMaster.WebAPI.Models.Dealers.DealerMaster master = new DealerMaster.WebAPI.Models.Dealers.DealerMaster
                {
                    contentversion = (from p in _context.TblVersionController
                                      where p.ActiveflagC == "A"
                                      && p.ModuleName == moduleName
                                      select p.Version.Value).FirstOrDefault(),
                    languagecode = Language.LanguageCode,
                    dealerlist = new DealersList
                    {
                        dealers = (from p in _context.MstDealerbranchhierarchyLang
                                   join o in _context.MstDealerbranchhierarchy on p.BranchCodeVc equals o.BranchCodeVc
                                   join i in _context.Tdealermaster on o.MainDealerCodeVc equals i.DealerCode
                                   join u in _context.TdealermasterLang on i.DealerCode equals u.DealerCode
                                   join y in _context.MstVillage on o.VillageCodeVc equals y.VillageCodeVc
                                   join t in _context.MstVillageLang on y.VillageCodeVc equals t.VillageCodeVc
                                   join r in _context.MstTehsil on y.TehsilCodeVc equals r.TehsilCodeVc
                                   join e in _context.MstTehsilLang on r.TehsilCodeVc equals e.TehsilCodeVc
                                   join w in _context.MstDistrict on r.DistrictCodeVc equals w.DistrictCodeVc
                                   join q in _context.MstDistrictLang on w.DistrictCodeVc equals q.DistrictCodeVc
                                   join l in _context.MstState on w.StateCodeI equals l.StateCodeI
                                   join k in _context.MstStateLang on l.StateCodeI equals k.StateCodeI
                                   where p.ActiveflagC == "A" && o.ActiveFlagC == "A" && u.ActiveflagC == "A" && y.ActiveflagC == "A"
                                   && t.ActiveflagC == "A" && r.ActiveflagC == "A" && e.ActiveflagC == "A" && w.ActiveflagC.Equals("A")
                                   //&& l.ActiveFlag_C == "A"// && k.ACTIVEFLAG_C == "A"
                                   && p.MstLangId == LanguageID
                                   && u.MstLangId == LanguageID
                                   && t.MstLangId == Language.Id
                                   && e.MstLangId == Language.Id
                                   && q.MstLangId == Language.Id
                                   && k.MstLangId == Language.Id
                                   select new Dealers
                                   {
                                       dealerid = o.MainDealerCodeVc,
                                       dealername = u.DealerName,
                                       branchid = o.BranchCodeVc,
                                       contactname = u.ContactPerson,
                                       contactnumber = o.MobileNoVc,
                                       email = o.EmailIdVc,
                                       statecode = l.StateCodeI,
                                       statename = k.StateNameVc,
                                       districtcode = w.DistrictCodeVc,
                                       districtname = q.DistrictNameVc,
                                       tehsilcode = r.TehsilCodeVc,
                                       tehsilname = e.TehsilNameVc,
                                       address = p.Address1Vc + " " + p.Address2Vc + " " + p.Address3Vc,
                                       sales = o.IsSalesVc.ToLower().Contains("yes") ? true : false,
                                       service = o.IsServiceVc.ToLower().ToString().Contains("yes") ? true : false,
                                       spare = o.IsSparesVc.ToLower().ToString().Contains("yes") ? true : false,
                                       position = new Position
                                       {
                                           //lattitude = o.latitude,
                                           //logitude = o.longitude
                                           lattitude = y.Latitude,
                                           logitude = y.Longitude
                                       }
                                   }).Distinct().ToList()
                    }

                };
                masterList.Add(master);
            }

            masterList.ForEach(x => x.dealerlist.totalrecords = x.dealerlist.dealers.Count);



            masterModel.masters = masterList;

            return masterModel;

        }
    }
}
