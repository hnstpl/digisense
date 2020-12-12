using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.DataProvider;
using AdminPortal.Mvc.Models.TipoftheDay;

namespace AdminPortal.Mvc.Services
{
    public interface ITipoftheDay
    {
        IEnumerable<MstTipofthedayCategoryLang> GetCategoryByLanguageID(int LanguageID);

        TipoftheDayModel GetTipoftheDayModel(int LanguageID);

        IEnumerable<TipoftheDayData> GetByLanguageID(int LanguageID, int Category, bool SubmitFlag, DateTime? From, DateTime? To);

        bool BuildAndAddNewTip(TipoftheDayModel Tip, ref int? NewTipID);

        TblTipoftheday AddMasterTip(TblTipoftheday NewTipRecord);

        IEnumerable<TblTipofthedayLang> AddLanguageTip(IEnumerable<TblTipofthedayLang> NewTipLangRecords);

        IEnumerable<TblTipofthedayLocationMapping> AddLocationTip(IEnumerable<TblTipofthedayLocationMapping> NewTipLocationRecords);

        TblTipoftheday GetTipByID(int ID);

        bool ChangeStatusByID(int ID, string Status);
    }
}
