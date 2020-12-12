using AdminPortal.Mvc.DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.GeoLocation;

namespace AdminPortal.Mvc.Services
{
    public class GeoLocationService : IGeoLocationService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        public GeoLocationService(dev_encrypted_generalcustomerappContext entityContext)
        {
            _context = entityContext;
        }

        //Get State List
        public IEnumerable<State> GetAllStates(int LanguageID)
        {
            List<State> result = new List<State>();

            try
            {

                List<State> data = (from s in _context.MstState
                                    join slang in _context.MstStateLang on s.StateCodeI equals slang.StateCodeI
                                    where slang.MstLangId == LanguageID
                                    orderby slang.StateNameVc ascending
                                    select new State
                                    {
                                        MStateCode_I = s.StateCodeI,
                                        MStateCode_VC = s.StateCodeVc,
                                        MStateName_VC = slang.StateNameVc,
                                        MZoneCode_VC = s.ZoneCodeVc,
                                        MActiveFlag_C = (s.ActiveFlagC == "A" ? "Active" : "In Active"),
                                        MLanguagecode = slang.MstLangId
                                    }).ToList();

                return data;
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        //Get District List
        public IEnumerable<District> GetAllDistricts(int LanguageID)
        {
            List<District> Districtresult = new List<District>();

            try
            {

                List<District> district = (from d in _context.MstDistrict
                                           join st in _context.MstState on d.StateCodeI equals st.StateCodeI
                                           join stlang in _context.MstStateLang on st.StateCodeI equals stlang.StateCodeI
                                           join dlang in _context.MstDistrictLang on d.DistrictCodeVc equals dlang.DistrictCodeVc
                                           where dlang.MstLangId == LanguageID && stlang.MstLangId == LanguageID
                                           orderby dlang.DistrictNameVc ascending
                                           select new District
                                           {
                                               MDistrictCode_VC = d.DistrictCodeVc,
                                               MDistrictName_VC = dlang.DistrictNameVc,
                                               MStatenAME_I = stlang.StateNameVc,
                                               MACTIVEFLAG_C = (d.ActiveflagC == "A" ? "Active" : "In Active")
                                           }).ToList();

                return district;
            }
            catch (Exception ex)
            {
                return Districtresult;
            }

        }

        //Get Tehsil List
        public IEnumerable<Tehsil> GetAllTehsils(int LanguageID)
        {
            List<Tehsil> Tehsilresult = new List<Tehsil>();

            try
            {

                List<Tehsil> Tehsil = (from t in _context.MstTehsil
                                       join d in _context.MstDistrict on t.DistrictCodeVc equals d.DistrictCodeVc
                                       join tlang in _context.MstTehsilLang on t.TehsilCodeVc equals tlang.TehsilCodeVc
                                       join dlang in _context.MstDistrictLang on t.DistrictCodeVc equals dlang.DistrictCodeVc
                                       where tlang.MstLangId == LanguageID && dlang.MstLangId == LanguageID
                                       orderby tlang.TehsilNameVc ascending
                                       select new Tehsil
                                       {
                                           MTehsilCode_VC = t.TehsilCodeVc,
                                           MTehsilName_VC = tlang.TehsilNameVc,
                                           MDistrictName = dlang.DistrictNameVc,
                                           MACTIVEFLAG_C = (t.ActiveflagC == "A" ? "Active" : "In Active")
                                       }).ToList();

                return Tehsil;
            }
            catch (Exception ex)
            {
                return Tehsilresult;
            }

        }

        //Get Village List
        public IEnumerable<Village> GetAllVillages(int LanguageID)
        {
            List<Village> village = new List<Village>();

            try
            {

                village = (from p in _context.MstVillageLang
                           join o in _context.MstVillage on p.VillageCodeVc equals o.VillageCodeVc
                           join i in _context.MstTehsil on o.TehsilCodeVc equals i.TehsilCodeVc
                           where p.MstLangId == LanguageID
                           orderby o.VillageCodeVc
                           select new Village
                           {
                               MVillageCode_VC = p.VillageCodeVc,
                               MVillageName_VC = p.VillageNameVc,
                               MTehsilCode_VC = o.TehsilCodeVc,
                               MACTIVEFLAG_C = (o.ActiveflagC == "A" ? "Active" : "In Active")
                           }).ToList();


                return village;
            }
            catch (Exception ex)
            {
                return village;
            }

        }

    }
}
