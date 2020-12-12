using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.TipoftheDay;
using AdminPortal.Mvc.TipoftheDay;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace AdminPortal.Mvc.Services
{
    public class TipoftheDay : ITipoftheDay
    {

        private readonly dev_encrypted_generalcustomerappContext _context;

        private readonly IGeoLocationService _geolocation;

        private readonly IGlobalService _global;

        public TipoftheDay(dev_encrypted_generalcustomerappContext entityContext, IGeoLocationService GeoLocation, IGlobalService Global)
        {
            _context = entityContext;
            _geolocation = GeoLocation;
            _global = Global;
        }

        public IEnumerable<MstTipofthedayCategoryLang> GetCategoryByLanguageID(int LanguageID)
        {
             return _context.MstTipofthedayCategoryLang.Where(x => x.MstLangId == LanguageID).ToList();
        }

        public TipoftheDayModel GetTipoftheDayModel(int LanguageID)
        {
            TipoftheDayModel tipModel = new TipoftheDayModel
            {
                languageModel = new LanguageModel
                {
                    LanguageList = new SelectList(_global.GetLanguageAlldata(), "MLanguageID", "MLanguage_Name"),
                    selectedLanguage = LanguageID
                },
                tipoftheDayData = null,
                tipListCount = 11,
                NewTip = new AddNewTip
                {
                    TipCategoryList = new SelectList(GetCategoryByLanguageID(LanguageID), "TipCategoryId", "CategoryName"),
                    StateList = new SelectList(_geolocation.GetAllStates(LanguageID), "MStateCode_I", "MStateName_VC"),
                    DistrictList = new SelectList(_geolocation.GetAllDistricts(LanguageID), "DistrictCodeVc", "DistrictNameVc"),
                    languageModel = new ApplicableLanguageModel
                    {
                        LanguageList = new SelectList(_global.GetLanguagedata(), "Languageid", "Languagename"),
                        selectedApplicableLanguage = null
                    }
                },
                searchFilters = new SearchFilters
                {
                    SelectedLanguage = LanguageID
                }
            };

            return tipModel;
        }

        public IEnumerable<TipoftheDayData> GetByLanguageID(int LanguageID, int Category, bool SubmitFlag, DateTime? From, DateTime? To)
        {
            //to use DBFunctions
            var DbF = Microsoft.EntityFrameworkCore.EF.Functions;

            List<TipoftheDayData> tipData = (from p in _context.TblTipofthedayLang
                                             join o in _context.TblTipoftheday on p.TipId equals o.TipId
                                             join i in _context.MstTipofthedayCategory on o.CategoryId equals i.TipCategoryId
                                             join u in _context.MstTipofthedayCategoryLang on i.TipCategoryId equals u.TipCategoryId
                                             where p.MstLangId == LanguageID
                                             && u.MstLangId == LanguageID
                                             && (Category == 0 || o.CategoryId == Category)
                                             && (SubmitFlag || From == null || o.ValidFrom <= From)
                                             && (SubmitFlag || To == null || o.ValidThru >= To)
                                             select new TipoftheDayData
                                             {
                                                 tipID = o.TipId,
                                                 tipCategory = u.CategoryName,
                                                 tipTitle = p.TipTitle,
                                                 tipText = p.TipText,
                                                 validfrom = o.ValidFrom.Value.Date,
                                                 validthru = o.ValidThru.Value.Date,
                                                 status = o.ActiveflagC
                                             }).OrderBy(x => x.tipID).Distinct().ToList();


            tipData.ForEach(x => { if (x.validthru.Value.Date < DateTime.Now.Date) { x.status = "E"; } });

            return tipData;
        }

        public bool BuildAndAddNewTip(TipoftheDayModel Tip, ref int? NewTipID)
        {
            try
            {
                var FromValidity = _global.ConvertStringtoDatetime(Tip.NewTip.Validity.Split("-")[0].Trim());
                var ToValidity = _global.ConvertStringtoDatetime(Tip.NewTip.Validity.Split("-")[1].Trim());

                if (FromValidity != null && ToValidity != null)
                {
                    TblTipoftheday Record = new TblTipoftheday
                    {
                        CategoryId = Tip.NewTip.SelectedCategory,
                        ValidFrom = FromValidity,
                        ValidThru = ToValidity,
                        ActiveflagC = "A",
                        CreateddtD = DateTime.Now,
                        //CreatedbyVc = HttpContext.Session.GetString("User")
                    };

                    AddMasterTip(Record);

                    NewTipID = Record.TipId;

                    List<TblTipofthedayLang> LanguageRecords = new List<TblTipofthedayLang>();

                    List<TblTipofthedayLocationMapping> LocationRecords = new List<TblTipofthedayLocationMapping>();

                    foreach (var itm in Tip.NewTip.languageModel.selectedApplicableLanguage)
                    {
                        TblTipofthedayLang LanguageRecord = new TblTipofthedayLang
                        {
                            TipId = Record.TipId,
                            TipTitle = Tip.NewTip.TipTitle,
                            TipText = Tip.NewTip.TipText,
                            MstLangId = itm,
                            ActiveflagC = "A",
                            CreateddtD = DateTime.Now,
                            //CreatedbyVc = HttpContext.Session.GetString("User")
                        };

                        LanguageRecords.Add(LanguageRecord);
                    }

                    AddLanguageTip(LanguageRecords);

                    if (Tip.NewTip.SelectedStates != null)
                    {
                        foreach (var itm in Tip.NewTip.SelectedStates)
                        {
                            var recordForMapping = new TblTipofthedayLocationMapping
                            {
                                TipId = Record.TipId,
                                StateCodeI = itm
                            };

                            LocationRecords.Add(recordForMapping);
                        }

                    }

                    if (Tip.NewTip.SelectedDistricts != null)
                    {
                        foreach (var itm in Tip.NewTip.SelectedDistricts)
                        {
                            var recordForMapping = new TblTipofthedayLocationMapping
                            {
                                TipId = Record.TipId,
                                DistrictCodeVc = itm
                            };

                            LocationRecords.Add(recordForMapping);
                        }
                    }

                    AddLocationTip(LocationRecords);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public TblTipoftheday AddMasterTip(TblTipoftheday NewTipRecord)
        {
            _context.TblTipoftheday.Add(NewTipRecord);

            _context.SaveChanges();

            return NewTipRecord;
        }

        public IEnumerable<TblTipofthedayLang> AddLanguageTip(IEnumerable<TblTipofthedayLang> NewTipLangRecords)
        {
            foreach(var itm in NewTipLangRecords)
            {
                _context.TblTipofthedayLang.Add(itm);
            }

            _context.SaveChanges();

            return NewTipLangRecords;
        }

        public IEnumerable<TblTipofthedayLocationMapping> AddLocationTip(IEnumerable<TblTipofthedayLocationMapping> NewTipLocationRecords)
        {
            foreach(var itm in NewTipLocationRecords)
            {
                _context.TblTipofthedayLocationMapping.Add(itm);
            }

            _context.SaveChanges();

            return NewTipLocationRecords;
        }

        public TblTipoftheday GetTipByID(int ID)
        {
            return _context.TblTipoftheday.Where(x => x.TipId == ID).FirstOrDefault();
        }

        public bool ChangeStatusByID(int ID, string Status)
        {
            try
            {
                var Record = GetTipByID(ID);
                if (Record != null)
                {
                    Record.ActiveflagC = Status;
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                return false;
            }
        }

    }
}
