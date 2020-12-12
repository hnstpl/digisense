using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Profile.WebAPI.Models.Profile;
using Profile.WebAPI.DataProvider;

namespace Profile.WebAPI.Services
{
    public interface IProfileService
    {
        Data GetCustomerData(string CustomerCode, int LanguageID);
        IEnumerable<VehicleData> GetVehileData(string CustomerCode, int LanguageID);

        IEnumerable<VehicleData> CalculateWarranty(List<VehicleData> vehicleData);

        IEnumerable<ExpandoObject> GetCustomNameData(string CustomerCode, int LanguageID, bool isSec);

        int GetContentVersion(string Module, string CustomerCode);

        IEnumerable<LoyaltyptsHistory> GetMShreeHistory(string CustomerCode, string MembershipNo);

        SelectedCropsList GetSelectedCrops(string CustomerCode, int LanguageID);

        MstCustprofile GetCustomerProfile(string CustomerCode);

        MstCustprofileLang GetCustomerLangProfile(string CustomerCode, int LanguageID);

        IEnumerable<PsCusttractorDtl> GetCustomerTractorProfile(string CustomerCode);

        IEnumerable<MstCustprofile> GetCustomerProfileByMobile(string Mobile);

        PsCusttractorDtlLang GetCustomerTractorLangProfileByVin(string VIN, string CustomerCode, int LanguageID);

        PsCusttractorDtl GetCustomerTractorProfileByVin(string VIN, string CustomerCode, int LanguageID);

        PsCusttractorDtlLang AddCustomerLangTractor(PsCusttractorDtlLang Record);

        bool AddCropsForCustomer(List<TblCutomerCropMapping> Record, string CustomerCode);

        public bool AddMandiForCustomer(List<TblCutomerMandiMapping> Record, string CustomerCode);
        public bool UpdateCustomerData(MstCustprofile Record, MstCustprofileLang Recordlang, string CustomerCode, int languageId);
        public bool UpdateCustomerTractorLangProfileByVin(PsCusttractorDtlLang Record, string VIN, string CustomerCode, int LanguageID);



    }
}
