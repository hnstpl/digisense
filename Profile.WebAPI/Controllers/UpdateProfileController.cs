using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Profile.WebAPI.Models.Error;
using Microsoft.AspNetCore.Authorization;
using Profile.WebAPI.Models.Profile;
using Microsoft.Extensions.Configuration;
using Profile.WebAPI.Services;
using Profile.WebAPI.DataProvider;

namespace Profile.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateProfileController : ControllerBase
    {
        ErrResponse err = new ErrResponse();

        ErrorData errD = new ErrorData();

        private readonly IGlobalService _global;

        private readonly IConfiguration _config;

        private readonly IProfileService _profile;

        public UpdateProfileController(IGlobalService Global, IConfiguration Config, IProfileService Profile)
        {
            _global = Global;
            _config = Config;
            _profile = Profile;
        }


        /// <summary>
        /// Profile update
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPut("Updateprofile")]
        [HttpPost("Updateprofile")]
        [Authorize]
        public IActionResult Updateprofile(UpdateProfile input)
        {
            var error = new Error();

            try
            {
                if (ModelState.IsValid)
                {
                        string customerCode = _global.GetCustomerCode();

                        if (input.isSec)
                        {

                            if (!string.IsNullOrEmpty(input.firstName)) input.firstName = _global.DecryptString(input.firstName).Result;
                            if (!string.IsNullOrEmpty(input.lastName)) input.lastName = _global.DecryptString(input.lastName).Result;
                            if (!string.IsNullOrEmpty(input.address)) input.address = _global.DecryptString(input.address).Result;
                            if (!string.IsNullOrEmpty(input.city)) input.city = _global.DecryptString(input.city).Result;
                            if (!string.IsNullOrEmpty(input.state)) input.state = _global.DecryptString(input.state).Result;
                            if (!string.IsNullOrEmpty(input.pincode)) input.pincode = _global.DecryptString(input.pincode).Result;
                            if (!string.IsNullOrEmpty(input.country)) input.country = _global.DecryptString(input.country).Result;
                            if (!string.IsNullOrEmpty(input.eMailID)) input.eMailID = _global.DecryptString(input.eMailID).Result;
                            if (!string.IsNullOrEmpty(input.mobileNoCC)) input.mobileNoCC = _global.DecryptString(input.mobileNoCC).Result;
                            if (!string.IsNullOrEmpty(input.mobileNo)) input.mobileNo = _global.DecryptString(input.mobileNo).Result;
                            if (!string.IsNullOrEmpty(input.imageURL)) input.imageURL = _global.DecryptString(input.imageURL).Result;
                            if (!string.IsNullOrEmpty(input.company)) input.company = _global.DecryptString(input.company).Result;
                            if (!string.IsNullOrEmpty(input.dateOfBirth)) input.dateOfBirth = _global.DecryptString(input.dateOfBirth).Result;
                            if (!string.IsNullOrEmpty(input.emergencyContact)) input.emergencyContact = _global.DecryptString(input.emergencyContact).Result;
                            if (!string.IsNullOrEmpty(input.gender)) input.gender = _global.DecryptString(input.gender).Result;
                            if (!string.IsNullOrEmpty(input.languagePreference)) input.languagePreference = _global.DecryptString(input.languagePreference).Result;
                            if (!string.IsNullOrEmpty(input.userNameOption)) input.userNameOption = _global.DecryptString(input.userNameOption).Result;
                            if (!string.IsNullOrEmpty(input.action)) input.action = _global.DecryptString(input.action).Result;
                            if (!string.IsNullOrEmpty(input.status)) input.status = _global.DecryptString(input.status).Result;
                            if (!string.IsNullOrEmpty(input.ownedlandsize)) input.ownedlandsize = _global.DecryptString(input.ownedlandsize).Result;
                            if (!string.IsNullOrEmpty(input.leasedlandsize)) input.leasedlandsize = _global.DecryptString(input.leasedlandsize).Result;
                            if (!string.IsNullOrEmpty(input.tractorusage)) input.tractorusage = _global.DecryptString(input.tractorusage).Result;
                            if (!string.IsNullOrEmpty(input.educationid)) input.educationid = _global.DecryptString(input.educationid).Result;
                            if (!string.IsNullOrEmpty(input.educationvalue)) input.educationvalue = _global.DecryptString(input.educationvalue).Result;
                            if (input.croplist != null && input.croplist.Count > 0)
                            {
                                input.croplist.ForEach(
                                    x =>
                                    {
                                        x.cropid = _global.DecryptString(x.cropid).Result;
                                    });
                            }
                            if (input.mandilist != null && input.mandilist.Count > 0)
                            {
                                input.mandilist.ForEach(
                                    x =>
                                    {
                                        x.mandiid = _global.DecryptString(x.mandiid).Result;
                                    });
                            }
                        }


                            var custData = _profile.GetCustomerProfile(customerCode);

                            var custDataLang = _profile.GetCustomerLangProfile(customerCode, 1);

                            var custTractorDtl = _profile.GetCustomerTractorProfile(customerCode).ToList();

                        //var dataOnMobile = (from p in entities.mst_custprofile
                        //                    where p.MobileNo_VC == input.mobileNo && p.ActiveFlag_C == "A"
                        //                    select p).ToList();

                        var dataOnMobile = _profile.GetCustomerProfileByMobile(input.mobileNo).ToList();

                        if (_profile.GetCustomerProfileByMobile(input.mobileNo).ToList().Count > 1)
                        {
                            var err = new ErrorData
                            {
                                code = 400,
                                context = "",
                                status_code = 400,
                                message = "Another user registered the requested mobile number"
                            };
                            error.error = err;
                            return Forbid();
                        }
                        else if (input.status != null && input.status.ToLower() == "false")
                        {
                            if (custTractorDtl.Count > 0)
                            {
                                var err = new ErrorData
                                {
                                    code = 400,
                                    context = "",
                                    status_code = 400,
                                    message = "User have tractors cannot be set as Inactive"
                                };
                                error.error = err;
                                return Forbid();
                            }
                        }
                        else
                        {
                            //validate dob dateformat
                            DateTime? dob = new DateTime();
                            if (!string.IsNullOrEmpty(input.dateOfBirth))
                            {
                                //var dateFormatFlag = DateTime.TryParseExact(input.dateOfBirth, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime temp_dob);

                                try
                                {
                                    dob = new DateTime(1970, 1, 1).Add(TimeSpan.FromSeconds((int)Convert.ToDouble(input.dateOfBirth)));
                                    if ((Convert.ToDouble(input.dateOfBirth) != 0 && dob == new DateTime(1970, 1, 1)) || dob == DateTime.MinValue)
                                    {
                                        throw new Exception("Format error");
                                    }
                                }
                                catch (Exception)
                                {
                                    var err = new ErrorData
                                    {
                                        code = 400,
                                        context = "",
                                        status_code = 400,
                                        message = "Format error in date parameter"
                                    };
                                    error.error = err;
                                    return BadRequest(error);

                                }
                            }
                            if (!string.IsNullOrEmpty(input.firstName))
                            {
                                custDataLang.CustNameVc = _global.EncryptString(input.firstName).Result;
                            }
                            if (!string.IsNullOrEmpty(input.address))
                            {
                                custDataLang.Add1Vc = _global.EncryptString(input.address).Result;
                            }
                            if (!string.IsNullOrEmpty(input.pincode))
                            {
                                custData.PincodeVc = _global.EncryptString(input.pincode).Result;
                            }
                            if (!string.IsNullOrEmpty(input.eMailID))
                            {
                                custData.EmailIdVc = _global.EncryptString(input.eMailID).Result;
                            }
                            if (!string.IsNullOrEmpty(input.mobileNo))
                            {
                                if (!input.mobileNo.All(char.IsDigit))
                                {
                                    return BadRequest("Not a Valid mobile number");
                                }
                                else
                                {
                                    custData.MobileNoVc = _global.EncryptString(input.mobileNo).Result;
                                }
                            }
                            if (!string.IsNullOrEmpty(input.imageURL))
                            {
                                custData.ProfilePicName = _global.EncryptString(input.imageURL).Result;
                                custData.ProfilePicNameVr = custData.ProfilePicNameVr == null ? 1 : (custData.ProfilePicNameVr + 1);
                            }
                            if (!string.IsNullOrEmpty(input.dateOfBirth))
                            {
                                custData.CustDobD = _global.EncryptString(dob.ToString()).Result;
                            }
                            if (!string.IsNullOrEmpty(input.educationid))
                            {
                                if (input.educationid == "5")
                                {
                                    custData.EducationId = Convert.ToInt32(input.educationid);
                                    custData.Education = _global.EncryptString(input.educationvalue).Result;
                                }
                                else
                                {
                                    int EducationID = int.Parse(input.educationid);

                                    var educationValue = _global.GetEducationByID(EducationID).Education;
                                    if (educationValue != null)
                                    {
                                        custData.EducationId = Convert.ToInt32(input.educationid);
                                        custData.Education = _global.EncryptString(educationValue).Result;
                                    }
                                    else
                                    {
                                        throw new ArgumentException("Error occured while updating education");
                                    }
                                }
                            }
                            if (input.ownedlandsize != null && Convert.ToInt32(input.ownedlandsize) != 0)
                            {
                                custData.Ownedlandsize = _global.EncryptString(input.ownedlandsize).Result;
                            }
                            if (input.leasedlandsize != null && Convert.ToInt32(input.leasedlandsize) != 0)
                            {
                                custData.Leasedlandsize = _global.EncryptString(input.leasedlandsize).Result;
                            }
                            if (input.tractorusage != null && Convert.ToInt32(input.tractorusage) != 0)
                            {
                                custData.Tractorusage = Convert.ToInt32(input.tractorusage);
                            }
                            if (input.languagePreference != null && Convert.ToInt32(input.languagePreference) != 0)
                            {
                                custData.LanguagePreference = Convert.ToInt32(input.languagePreference);
                            }

                            //increase the version
                            if (custData.Version == null)
                            {
                                custData.Version = 1;
                            }
                            else
                                custData.Version = custData.Version + 1;
                            }

                            //update custom tractor names
                            if (input.customProfile != null && input.customProfile.Count > 0)
                                {
                                //save entities if language preference sent along with this request
                                //int SaveResult = entities.SaveChanges();

                                    foreach (var itm in input.customProfile)
                                    {
                                        for (int i = 0; i < itm.Keys.Count; i++)
                                        {
                                            var PropertyName = itm.Keys.ElementAt(i);
                                            var PropertyValue = itm.Values.ElementAt(i);

                                            //if encrypted
                                            if (input.isSec)
                                            {
                                                PropertyName = _global.DecryptString(PropertyName).Result;
                                                PropertyValue = _global.DecryptString(PropertyValue.ToString()).Result;
                                            }

                                            //Get Language Preference
                                            var LanguagePreferenceRecord = _profile.GetCustomerProfile(customerCode);

                                            if (LanguagePreferenceRecord != null)
                                            {
                                                //update custom name
                                                var CustomUpdateRecord = _profile.GetCustomerTractorLangProfileByVin(PropertyName, customerCode, LanguagePreferenceRecord.LanguagePreference.Value);

                                                if (CustomUpdateRecord == null)
                                                {
                                                    //get custom Tractor Detail ID
                                                    var TractorVinNumer = _profile.GetCustomerTractorProfileByVin(PropertyName, customerCode, LanguagePreferenceRecord.LanguagePreference.Value);

                                                    if (TractorVinNumer == null)
                                                    {
                                                        throw new ArgumentException("Update profile failed");
                                                    }

                                                    PsCusttractorDtlLang NewCusomRecord = new PsCusttractorDtlLang
                                                    {
                                                        CustTractorDtlId = TractorVinNumer.Id,
                                                        CustomTractorName = PropertyValue.ToString(),
                                                        MstLangId = LanguagePreferenceRecord.LanguagePreference.Value,
                                                        ActiveflagC = "A",
                                                        CreatedbyVc = customerCode,
                                                        CreateddtD = DateTime.Now
                                                    };

                                                    var Result = _profile.AddCustomerLangTractor(NewCusomRecord);
                                                }
                                                else
                                                {
                                                    CustomUpdateRecord.CustomTractorName = PropertyValue.ToString();
                                                    _profile.UpdateCustomerTractorLangProfileByVin(CustomUpdateRecord, PropertyName, customerCode, LanguagePreferenceRecord.LanguagePreference.Value);
                                                }

                                            }
                                            else
                                            {
                                                throw new ArgumentException("Incorrect language Preference");
                                            }

                                        }
                                    }
                                }




                                if (input.croplist != null && input.croplist.Count > 0)
                                {

                                var CropRecords = new List<TblCutomerCropMapping>();


                                    foreach (var itm in input.croplist)
                                    {
                                        TblCutomerCropMapping record = new TblCutomerCropMapping
                                        {
                                            CustCodeVc = customerCode,
                                            CropId = Convert.ToInt32(itm.cropid),
                                            ActiveflagC = "A",
                                            CreatedbyVc = customerCode,
                                            CreateddtD = DateTime.Now
                                        };

                                    CropRecords.Add(record);
                                    }

                                if (!_profile.AddCropsForCustomer(CropRecords, customerCode)) return BadRequest();

                                }
                                else if (input.croplist != null && input.croplist.Count <= 0)
                                {
                                //remove existing crops
                                var result = _profile.AddCropsForCustomer(null, customerCode);

                                }


                                if (input.mandilist != null && input.mandilist.Count > 0)
                                {
                                var Mandirecords = new List<TblCutomerMandiMapping>();

                                foreach (var itm in input.mandilist)
                                    {
                                        TblCutomerMandiMapping record = new TblCutomerMandiMapping
                                        {
                                            CustCodeVc = customerCode,
                                            MandiId = Convert.ToInt32(itm.mandiid),
                                            ActiveflagC = "A",
                                            CreatedbyVc = customerCode,
                                            CreateddtD = DateTime.Now
                                        };

                                    Mandirecords.Add(record);
                                }
                                if (!_profile.AddMandiForCustomer(Mandirecords, customerCode)) return BadRequest();
                            }
                            else if (input.mandilist != null && input.mandilist.Count <= 0)
                            {
                                //remove existing crops
                                var result = _profile.AddMandiForCustomer(null, customerCode);

                    }


                    bool Resutl = _profile.UpdateCustomerData(custData, custDataLang, customerCode, 1);
                }


                err.Message = "Profile Updated Successfully";
                return Ok(err);
            }
            catch (Exception e)
            {
                var err = new ErrorData
                {
                    code = 400,
                    context = "",
                    status_code = 400,
                    message = e.Message
                };
                err.message = e.Message;
                return BadRequest(err);
            }


        }

    }
}
