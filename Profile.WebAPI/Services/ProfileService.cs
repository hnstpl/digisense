using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Profile.WebAPI.Models.Profile;
using Profile.WebAPI.DataProvider;
using Microsoft.Extensions.Configuration;
using System.Dynamic;

namespace Profile.WebAPI.Services
{
    public class ProfileService : IProfileService
    {
        private dev_encrypted_generalcustomerappContext _context;

        private readonly IConfiguration _config;

        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        private readonly IGlobalService _global;

        public ProfileService(dev_encrypted_generalcustomerappContext Context, IConfiguration Config, IGlobalService Global)
        {
            _context = Context;
            _config = Config;
            _global = Global;
        }


        public Data GetCustomerData(string CustomerCode, int LanguageID)
        {
            Data customerData = (from p in _context.MstCustprofile
                                 join o in _context.MstCustprofileLang on p.CustCodeVc equals o.CustCodeVc
                                 where p.CustCodeVc == CustomerCode
                                 && p.ActiveFlagC == "A"
                                 && (o.MstLangId == LanguageID)
                                 select new Data
                                 {
                                     lastName = string.Empty,
                                     pincode = p.PincodeVc,
                                     alertCommControl = string.Empty,
                                     country = "India",
                                     address = o.Add1Vc + " " + o.Add2Vc + " " + o.Add3Vc,
                                     gender = string.Empty,
                                     city = (from i in _context.MstVillage
                                             join u in _context.MstTehsil on i.TehsilCodeVc equals u.TehsilCodeVc
                                             join y in _context.MstTehsilLang on u.TehsilCodeVc equals y.TehsilCodeVc
                                             where i.VillageCodeVc == p.VillageCodeVc
                                             && i.ActiveflagC == "A"
                                             && y.MstLangId == LanguageID
                                             select y.TehsilNameVc).FirstOrDefault(),
                                     roleID = string.Empty,
                                     //dateOfBirth = p.CustDob_D.HasValue ? DbFunctions.DiffSeconds(p.CustDob_D.Value, epoch).Value : 0,
                                     dateofbirth = p.CustDobD,
                                     mobileNo = p.MobileNoVc,
                                     userID = CustomerCode,
                                     firstName = o.CustNameVc,
                                     ownedlandsize = p.Ownedlandsize,
                                     leasedlandsize = p.Leasedlandsize,
                                     tractorusageid = p.Tractorusage.ToString(),
                                     educationid = p.EducationId.ToString(),
                                     educationvalue = p.Education,
                                     mobileNoCC = "+91",
                                     userNameOption = "mobileNo",
                                     languagePreference = (from w in _context.MstLanguage
                                                           where w.Id == p.LanguagePreference
                                                           && w.ActiveflagC == "A"
                                                           select w.LanguageCode).FirstOrDefault(),
                                     eMailID = p.EmailIdVc,
                                     imageURL = p.ProfilePicName,
                                     imageversion = p.ProfilePicNameVr.HasValue ? p.ProfilePicNameVr.Value : 0,
                                     company = string.Empty,
                                     state = (from i in _context.MstVillage
                                              join u in _context.MstTehsil on i.TehsilCodeVc equals u.TehsilCodeVc
                                              join y in _context.MstDistrict on u.DistrictCodeVc equals y.DistrictCodeVc
                                              join t in _context.MstState on y.StateCodeI equals t.StateCodeI
                                              join r in _context.MstStateLang on t.StateCodeI equals r.StateCodeI
                                              where i.VillageCodeVc == p.VillageCodeVc
                                              && i.ActiveflagC == "A"
                                              && u.ActiveflagC == "A"
                                              && y.ActiveflagC == "A"
                                              && t.ActiveFlagC == "A"
                                              && r.ActiveflagC == "A"
                                              && r.MstLangId == LanguageID
                                              select r.StateNameVc).FirstOrDefault(),
                                     status = p.ActiveFlagC == "A" ? "1" : "0",
                                     villagecode = p.VillageCodeVc,
                                     villagename = (from i in _context.MstVillageLang
                                                    where i.VillageCodeVc == p.VillageCodeVc
                                                    && i.MstLangId == LanguageID
                                                    select i.VillageNameVc).FirstOrDefault(),
                                     mahindrashree = (from q in _context.SrMshreeEnrolcustHdr
                                                      where q.Customercode == CustomerCode && q.Activeflag == "A"
                                                      select new SRMahindraShree
                                                      {
                                                          msmembershipno = q.MembershipNo,
                                                          msloyaltypts = q.Loyaltypts.ToString(),
                                                          mscategory = q.Mscategory
                                                      }).FirstOrDefault()
                                 }).FirstOrDefault();

            return customerData;
        }

        public IEnumerable<VehicleData> GetVehileData(string CustomerCode, int LanguageID)
        {
            //Get the default service advisor
            var DefaultServiceAdvisorName = _config.GetValue<string>("Default:DefaultServiceAdvisorName"); //ConfigurationManager.AppSettings["DefaultServiceAdvisorName"];
            var DefaultServiceAdvisorNumber = _config.GetValue<string>("Default:DefaultServiceAdvisor"); //ConfigurationManager.AppSettings["DefaultServiceAdvisor"];
            var SalesManDesigCode = _config.GetValue<string>("Default:SalesManDesigCode"); //ConfigurationManager.AppSettings["SalesManDesigCode"];

            //Get CustomerData
            var customerData = GetCustomerData(CustomerCode, LanguageID);


            List<VehicleData> vehicleData = (from p in _context.MstCustprofile
                                             join o in _context.PsCusttractorDtl on p.CustCodeVc equals o.CustCodeVc
                                             //join y in _context.ps_custtractor_dtl_lang on o.ID equals y.CustTractor_Dtl_ID
                                             join i in _context.MstTpdhModel on o.ModelCodeVc equals i.ModelcodeVc
                                             join u in _context.MstTpdhModelLang on i.ModelcodeVc equals u.ModelcodeVc into LeftJoin
                                             from r in LeftJoin.DefaultIfEmpty()
                                             join t in _context.SrFreeservicecoupon on o.SerialNoVc equals t.TractorSrNo
                                             where o.MasterTypeC == "C" && p.CustCodeVc == CustomerCode
                                             && r.MstLangId == LanguageID
                                             //&& y.MST_LANG_ID == Language.ID
                                             select new VehicleData
                                             {
                                                 regNo = o.RegNoVc,
                                                 vehicleModel = r.ModelnameVc,
                                                 vin = o.SerialNoVc,
                                                 vehicleTypeid = (from y in _context.MstVehiclType
                                                                  where y.ActiveflagC == "A"
                                                                  && y.Id == o.VehicleType
                                                                  select y.Id).FirstOrDefault().ToString(),
                                                 vehicleType = (from y in _context.MstVehiclType
                                                                where y.ActiveflagC == "A"
                                                                && y.Id == o.VehicleType
                                                                select y.Name).FirstOrDefault(),
                                                 vehicleCategory = i.ModelcodeVc,
                                                 customname = (from y in _context.PsCusttractorDtlLang
                                                               where y.CustTractorDtlId == o.Id
                                                               && y.ActiveflagC == "A"
                                                               //&& y.MST_LANG_ID == LanguageID
                                                               select y.CustomTractorName).FirstOrDefault(),
                                                 warrantyvalidity = "0",
                                                 purchaseddate = dev_encrypted_generalcustomerappContext.DiffSeconds(o.DopD , epoch).ToString(),
                                                 installeddate = dev_encrypted_generalcustomerappContext.DiffSeconds(t.ServiceDate, epoch).ToString(),
                                                 serviceadvisor = (((
                                                  from e in _context.MstEmployee
                                                  join d in _context.MstDesignation on e.DesigcodeC equals d.DesigcodeVc
                                                  join s in _context.MstVillagesalesmanrelation on e.EmployeeNoVc equals s.SalesmanNoVc
                                                  join a in _context.MstCustprofile on CustomerCode equals a.CustCodeVc
                                                  where
                                                  e.DesigcodeC == SalesManDesigCode &&
                                                  //((customerData.villagecode != null && s.VillageNo_VC == customerData.villagecode) || (a.DealerCode_VC != null && s.DealerCode_VC == a.DealerCode_VC))
                                                  ((customerData.villagecode != null && s.VillageNoVc == customerData.villagecode))
                                                  && e.ActiveflagC == "A"
                                                  && d.ActiveflagC == "A"
                                                  && s.ActiveFlagC == "A"
                                                  && string.IsNullOrEmpty(e.EmployeeNameVc) == false
                                                  && string.IsNullOrEmpty(e.PphoneVc) == false
                                                  select new ServiceAdvisor
                                                  {
                                                      serviceadvisorname = e.EmployeeNameVc,
                                                      serviceadvisornumber = e.PphoneVc
                                                  }).FirstOrDefault()) == null ?
                                                  ((
                                                  from e in _context.MstEmployee
                                                  join d in _context.MstDesignation on e.DesigcodeC equals d.DesigcodeVc
                                                  join s in _context.MstVillagesalesmanrelation on e.EmployeeNoVc equals s.SalesmanNoVc
                                                  join a in _context.MstCustprofile on customerData.userID equals a.CustCodeVc
                                                  where
                                                  e.DesigcodeC == SalesManDesigCode &&
                                                  ((a.DealerCodeVc != null && s.DealerCodeVc == a.DealerCodeVc))
                                                  && e.ActiveflagC == "A"
                                                  && d.ActiveflagC == "A"
                                                  && s.ActiveFlagC == "A"
                                                  && string.IsNullOrEmpty(e.EmployeeNameVc) == false
                                                  && string.IsNullOrEmpty(e.PphoneVc) == false
                                                  select new ServiceAdvisor
                                                  {
                                                      serviceadvisorname = e.EmployeeNameVc,
                                                      serviceadvisornumber = e.PphoneVc
                                                  }).FirstOrDefault())
                                                  :
                                                  ((
                                                  from e in _context.MstEmployee
                                                  join d in _context.MstDesignation on e.DesigcodeC equals d.DesigcodeVc
                                                  join s in _context.MstVillagesalesmanrelation on e.EmployeeNoVc equals s.SalesmanNoVc
                                                  join a in _context.MstCustprofile on customerData.userID equals a.CustCodeVc
                                                  where
                                                  e.DesigcodeC == SalesManDesigCode &&
                                                  ((customerData.villagecode != null && s.VillageNoVc == customerData.villagecode))
                                                  && e.ActiveflagC == "A"
                                                  && d.ActiveflagC == "A"
                                                  && s.ActiveFlagC == "A"
                                                  && string.IsNullOrEmpty(e.EmployeeNameVc) == false
                                                  && string.IsNullOrEmpty(e.PphoneVc) == false
                                                  select new ServiceAdvisor
                                                  {
                                                      serviceadvisorname = e.EmployeeNameVc,
                                                      serviceadvisornumber = e.PphoneVc
                                                  }).FirstOrDefault() == null ?
                                                  (new ServiceAdvisor
                                                  {
                                                      serviceadvisorname = DefaultServiceAdvisorName,
                                                      serviceadvisornumber = DefaultServiceAdvisorNumber
                                                  })
                                                  :
                                                  ((
                                                  from e in _context.MstEmployee
                                                  join d in _context.MstDesignation on e.DesigcodeC equals d.DesigcodeVc
                                                  join s in _context.MstVillagesalesmanrelation on e.EmployeeNoVc equals s.SalesmanNoVc
                                                  join a in _context.MstCustprofile on customerData.userID equals a.CustCodeVc
                                                  where
                                                  e.DesigcodeC == SalesManDesigCode &&
                                                  ((customerData.villagecode != null && s.VillageNoVc == customerData.villagecode))
                                                  && e.ActiveflagC == "A"
                                                  && d.ActiveflagC == "A"
                                                  && s.ActiveFlagC == "A"
                                                  && string.IsNullOrEmpty(e.EmployeeNameVc) == false
                                                  && string.IsNullOrEmpty(e.PphoneVc) == false
                                                  select new ServiceAdvisor
                                                  {
                                                      serviceadvisorname = e.EmployeeNameVc,
                                                      serviceadvisornumber = e.PphoneVc
                                                  }).FirstOrDefault())
                                                  ))
                                             }).Distinct().ToList();

            return vehicleData;
        }

        public IEnumerable<VehicleData> CalculateWarranty(List<VehicleData> vehicleData)
        {
            //Extended warranty is not applicable for tractor delivered after Feb'20
            var ExtWarrantyPointer = DateTime.Parse(_config.GetValue<string>("Default:TractorWarrantyPointer")); // DateTime.Parse(ConfigurationManager.AppSettings["TractorWarrantyPointer"]);
            var ModelCode = _config.GetValue<string>("Default:ExtWarrantyNotApply"); //ConfigurationManager.AppSettings["ExtWarrantyNotApply"];

            vehicleData.ForEach(
                           x =>
                           {
                               try
                               {
                                   var DateOfPurchase = _context.PsCusttractorDtl.Where(y => y.SerialNoVc == x.vin).FirstOrDefault().DopD;

                                   if (x.vehicleCategory == ModelCode || DateOfPurchase > ExtWarrantyPointer)
                                   {
                                       x.warrantyvalidity = (DateOfPurchase.Value.AddYears(1) - epoch).TotalSeconds.ToString();
                                   }
                                   else
                                   {
                                       var ServiceDate = _context.SrFreeservicecoupon.Where(y => y.TractorSrNo == x.vin && y.CouponNo == 10).FirstOrDefault().ServiceDate;

                                       x.warrantyvalidity = (ServiceDate.Value - epoch).TotalSeconds.ToString();
                                   }
                               }
                               catch (Exception)
                               {

                               }

                           });

            return vehicleData;
        }

        public IEnumerable<ExpandoObject> GetCustomNameData(string CustomerCode, int LanguageID, bool isSec)
        {
            //set property dynamically since existing API uses like this way
            var vehicles = (from p in _context.PsCusttractorDtl
                            join o in _context.PsCusttractorDtlLang on p.Id equals o.CustTractorDtlId
                            where p.CustCodeVc == CustomerCode && p.MasterTypeC == "C"
                            && o.MstLangId == LanguageID
                            select new
                            {
                                p.SerialNoVc,
                                o.CustomTractorName
                            }).ToList();


            List<ExpandoObject> ctmpl = new List<ExpandoObject>();

            foreach (var itm in vehicles)
            {
                dynamic ctmp = new ExpandoObject();

                if (isSec) DynamicSetProperty.AddProperty(ctmp, _global.EncryptString(itm.SerialNoVc).Result, _global.EncryptString(itm.CustomTractorName).Result);
                else DynamicSetProperty.AddProperty(ctmp, itm.SerialNoVc, itm.CustomTractorName);
                ctmpl.Add(ctmp);
            }

            return ctmpl;
        }

        public int GetContentVersion(string Module, string CustomerCode)
        {
            var contentversion = (from p in _context.MstCustprofile
                                  where p.ActiveFlagC == "A"
                                  && p.CustCodeVc == CustomerCode
                                  select p.Version).FirstOrDefault() == null ?
                                          0 :
                                          (from p in _context.MstCustprofile
                                           where p.ActiveFlagC == "A"
                                           && p.CustCodeVc == CustomerCode
                                           select p.Version.Value).FirstOrDefault();

            return contentversion;
        }

        public IEnumerable<LoyaltyptsHistory> GetMShreeHistory(string CustomerCode, string MembershipNo)
        {
            //Get MS Redemtion history
            var msptshistory = (from l in _context.SrMshreeRedemptionDtl
                                where l.Membershipno == MembershipNo
                                select new LoyaltyptsHistory
                                {
                                    description = l.RedemptProduct,
                                    type = "REDEMTION",
                                    date = l.RedemptReqDate.HasValue ? dev_encrypted_generalcustomerappContext.DiffSeconds(l.RedemptReqDate.Value, epoch).ToString() : "0",
                                    mspts = l.RedemptPts.Value.ToString()
                                }).ToList();

            return msptshistory;

        }

        public SelectedCropsList GetSelectedCrops(string CustomerCode, int LanguageID)
        {
            //Get selected crops list
            SelectedCropsList selectedCropsList = new SelectedCropsList
            {
                selectedcrops = (from p in _context.TblCutomerCropMapping
                                 join o in _context.MstMandiCropListLang on p.CropId equals o.CropId
                                 where p.CustCodeVc == CustomerCode && p.ActiveflagC == "A"
                                 && o.MstLangId == LanguageID
                                 select new SelectedCrops
                                 {
                                     cropid = p.CropId.Value.ToString(),
                                     cropname = o.CropName
                                 }).ToList()
            };

            return selectedCropsList;
        }

        public MstCustprofile GetCustomerProfile(string CustomerCode)
        {
            var custData = (from p in _context.MstCustprofile
                            where p.CustCodeVc == CustomerCode && p.ActiveFlagC == "A"
                            select p).FirstOrDefault();

            return custData;
        }

        public MstCustprofileLang GetCustomerLangProfile(string CustomerCode, int LanguageID)
        {
            var custDataLang = (from p in _context.MstCustprofileLang
                                where p.CustCodeVc == CustomerCode
                                && p.ActiveflagC == "A"
                                && p.MstLangId == LanguageID
                                select p).FirstOrDefault();

            return custDataLang;
        }

        public IEnumerable<PsCusttractorDtl> GetCustomerTractorProfile(string CustomerCode)
        {
            var custTractorDtl = (from p in _context.PsCusttractorDtl
                                  join o in _context.MstCustprofile on p.CustCodeVc equals o.CustCodeVc
                                  where o.CustCodeVc == CustomerCode
                                  select p).ToList();

            return custTractorDtl;
        }

        public IEnumerable<MstCustprofile> GetCustomerProfileByMobile(string Mobile)
        {
            var dataOnMobile = (from p in _context.MstCustprofile
                                where p.MobileNoVc == Mobile && p.ActiveFlagC == "A"
                                select p).ToList();

            return dataOnMobile;
        }

        public PsCusttractorDtlLang GetCustomerTractorLangProfileByVin(string VIN, string CustomerCode, int LanguageID)
        {
            //update custom name
            var CustomUpdateRecord = (from p in _context.PsCusttractorDtl
                                      join o in _context.PsCusttractorDtlLang on p.Id equals o.CustTractorDtlId
                                      where p.CustCodeVc == CustomerCode
                                      && p.SerialNoVc == VIN
                                      && p.MasterTypeC == "C"
                                      && o.MstLangId == LanguageID
                                      select o).FirstOrDefault();

            return CustomUpdateRecord;
        }

        public PsCusttractorDtl GetCustomerTractorProfileByVin(string VIN, string CustomerCode, int LanguageID)
        {

            //get custom Tractor Detail ID
            var TractorVinNumer = (from p in _context.PsCusttractorDtl
                                   where p.CustCodeVc == CustomerCode
                                   && p.SerialNoVc == VIN
                                   && p.MasterTypeC == "C"
                                   select p).FirstOrDefault();

            return TractorVinNumer;
        }

        public PsCusttractorDtlLang AddCustomerLangTractor(PsCusttractorDtlLang Record)
        {
            _context.PsCusttractorDtlLang.Add(Record);

            return Record;
        }

        public bool AddCropsForCustomer(List<TblCutomerCropMapping> Record, string CustomerCode)
        {

            //remove existing crops
            var result = (from p in _context.TblCutomerCropMapping
                          where p.CustCodeVc == CustomerCode
                          && p.ActiveflagC == "A"
                          select p).ToList();

            result.ForEach(x => x.ActiveflagC = "I");

            if (Record != null)
            {
                foreach (var itm in Record)
                {
                    _context.TblCutomerCropMapping.Add(itm);
                }
            }

            _context.SaveChanges();

            return true;
        }


        public bool AddMandiForCustomer(List<TblCutomerMandiMapping> Record, string CustomerCode)
        {

            //remove existing crops
            var result = (from p in _context.TblCutomerMandiMapping
                          where p.CustCodeVc == CustomerCode
                          && p.ActiveflagC == "A"
                          select p).ToList();

            result.ForEach(x => x.ActiveflagC = "I");
            if (Record != null)
            {
                foreach (var itm in Record)
                {
                    _context.TblCutomerMandiMapping.Add(itm);
                }
            }

            _context.SaveChanges();

            return true;
        }

        public bool UpdateCustomerData(MstCustprofile Record, MstCustprofileLang Recordlang, string CustomerCode,int languageId)
        {
            var custData = (from p in _context.MstCustprofile
                            where p.CustCodeVc == CustomerCode && p.ActiveFlagC == "A"
                            select p).FirstOrDefault();


            var custDataLang = (from p in _context.MstCustprofileLang
                                where p.CustCodeVc == CustomerCode
                                && p.ActiveflagC == "A"
                                && p.MstLangId == languageId
                                select p).FirstOrDefault();


            if (!string.IsNullOrEmpty(Record.PincodeVc))
            {
                custData.PincodeVc = Record.PincodeVc;
            }
            if (!string.IsNullOrEmpty(Record.EmailIdVc))
            {
                custData.EmailIdVc = Record.EmailIdVc;
            }
            if (!string.IsNullOrEmpty(Record.MobileNoVc))
            {

                custData.MobileNoVc = Record.MobileNoVc;
            }
            if (!string.IsNullOrEmpty(Record.ProfilePicName))
            {
                custData.ProfilePicName = Record.ProfilePicName;                
            }

            if (!(Record.ProfilePicNameVr==null))
            {                
                custData.ProfilePicNameVr = Record.ProfilePicNameVr;
            }

            if (!string.IsNullOrEmpty(Record.CustDobD))
            {
                custData.CustDobD = Record.CustDobD;
            }
            

            if (!(Record.EducationId == null))
            {
                custData.EducationId = Record.EducationId;
            }

            if (!string.IsNullOrEmpty(Record.Education))
            {
                custData.Education = Record.Education;
            }


            if (!(Record.Ownedlandsize == null))
            {
                custData.Ownedlandsize = Record.Ownedlandsize;
            }

            if (!(Record.Leasedlandsize == null))
            {
                custData.Leasedlandsize = Record.Leasedlandsize;
            }

            if (!(Record.Tractorusage == null))
            {
                custData.Tractorusage = Record.Tractorusage;
            }

            if (!(Record.LanguagePreference == null))
            {
                custData.LanguagePreference = Record.LanguagePreference;
            }

             Record.Version = custData.Version;

   
         //Customer Language Date update

            if (!string.IsNullOrEmpty(Recordlang.CustNameVc))
            {
                custDataLang.CustNameVc = custDataLang.CustNameVc;
            }
            if (!string.IsNullOrEmpty(Recordlang.Add1Vc))
            {
                custDataLang.Add1Vc = Recordlang.Add1Vc;
            }

            _context.SaveChanges();

            return true;
        }

        public bool UpdateCustomerTractorLangProfileByVin(PsCusttractorDtlLang Record, string VIN, string CustomerCode, int LanguageID)
        {
            var CustomUpdateRecord = (from p in _context.PsCusttractorDtl
                                      join o in _context.PsCusttractorDtlLang on p.Id equals o.CustTractorDtlId
                                      where p.CustCodeVc == CustomerCode
                                      && p.SerialNoVc == VIN
                                      && p.MasterTypeC == "C"
                                      && o.MstLangId == LanguageID
                                      select o).FirstOrDefault();

            if (!string.IsNullOrEmpty(Record.CustomTractorName))
            {
                CustomUpdateRecord.CustomTractorName = Record.CustomTractorName;
            }
            _context.SaveChanges();

            return true;
        }

    }
}
