using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Profile.WebAPI.Services;
using Profile.WebAPI.Models;
using Profile.WebAPI.Models.Error;
using Microsoft.AspNetCore.Authorization;
using Profile.WebAPI.Models.Profile;
using Microsoft.Extensions.Configuration;

namespace Profile.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {

        ErrResponse err = new ErrResponse();

        ErrorData errD = new ErrorData();

        private readonly IGlobalService _global;

        private readonly IConfiguration _config;

        private readonly IProfileService _profile;

        public ProfileController(IGlobalService Global, IConfiguration Config, IProfileService Profile)
        {
            _global = Global;
            _config = Config;
            _profile = Profile;
        }


        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);



        /// <summary>
        /// Get user details
        /// </summary>
        /// <param name="input"></param>
        /// <param name="isSec"></param>
        /// <returns></returns>
        [HttpGet("Get_Profile")]
        [Authorize]
        public IActionResult Get_Profile([FromQuery] LanguageCode input, Boolean isSec)
        {

            //if user have valid token
            try
            {
                    string customerCode = _global.GetCustomerCode();

                    var LanguagePreference = _global.GetLanguagePreference(customerCode);

                    var LanguageID = LanguagePreference;

                    var IsUserInfoAvailForTargetLanguage = _global.IsUserLangAvail(customerCode, LanguageID);

                    if (!_global.IsUserLangAvail(customerCode, LanguageID)) LanguageID = Convert.ToInt32(_config.GetValue<string>("Default:LanguageID"));


                    if (LanguageID == 0)
                    {
                        var errData = new ErrorData()
                        {
                            code = 400,
                            context = null,
                            message = "Language code required!",
                            status_code = 400
                        };
                        var err = new Error()
                        {
                            error = errData
                        };
                        return BadRequest(err);
                    }


                    Data customerData = _profile.GetCustomerData(customerCode, LanguageID);

                    if (customerData == null)
                    {
                        throw new NullReferenceException("User profile not found");
                    }
                    else
                    {
                        customerData.dateofbirth = (DateTime.Parse(_global.DecryptString(customerData.dateofbirth).Result) - epoch).TotalSeconds.ToString();
                    }

                    //Get the default service advisor
                    var DefaultServiceAdvisorName = _config.GetValue<string>("Default:DefaultServiceAdvisorName"); //ConfigurationManager.AppSettings["DefaultServiceAdvisorName"];
                    var DefaultServiceAdvisorNumber = _config.GetValue<string>("Default:DefaultServiceAdvisor"); //ConfigurationManager.AppSettings["DefaultServiceAdvisor"];
                    var SalesManDesigCode = _config.GetValue<string>("Default:SalesManDesigCode"); //ConfigurationManager.AppSettings["SalesManDesigCode"];



                    //Get the user owned vehicle information
                    List<VehicleData> vehicleData = _profile.GetVehileData(customerCode, LanguageID).ToList();

                    vehicleData = vehicleData.Distinct().ToList();

                    //calculate warranty

                    //Extended warranty is not applicable for tractor delivered after Feb'20
                    var ExtWarrantyPointer = DateTime.Parse(_config.GetValue<string>("Default:TractorWarrantyPointer")); // DateTime.Parse(ConfigurationManager.AppSettings["TractorWarrantyPointer"]);
                    var ModelCode = _config.GetValue<string>("Default:ExtWarrantyNotApply"); //ConfigurationManager.AppSettings["ExtWarrantyNotApply"];

                    vehicleData = _profile.CalculateWarranty(vehicleData).ToList();

                    var ctmpl = _profile.GetCustomNameData(customerCode, LanguageID, isSec).ToList();

                    if (ctmpl != null)
                    {
                        customerData.customProfile = ctmpl;
                    }

                    Summary summary = new Summary();
                    List<ServiceAccessPrivileges> serviceaccess = new List<ServiceAccessPrivileges>();
                    List<AlertCommunication> alertcommunication = new List<AlertCommunication>();
                    List<NotificationCommunication> notification = new List<NotificationCommunication>();
                    List<FeatureAccessPrivileges> feture = new List<FeatureAccessPrivileges>();

                    if (customerData.mahindrashree != null)
                    {
                        //Get MS Redemtion history
                        customerData.mahindrashree.msptshistory = _profile.GetMShreeHistory(customerCode, customerData.mahindrashree.msmembershipno).ToList();
                            
                    }

                    //Get selected crops list
                    SelectedCropsList selectedCropsList = _profile.GetSelectedCrops(customerCode, LanguageID);

                    //If request enabled encryption
                    if (isSec)
                    {
                        customerData.country = _global.EncryptString(customerData.country).Result;
                        customerData.gender = _global.EncryptString(customerData.gender).Result;
                        customerData.dateofbirth = _global.EncryptString(customerData.dateofbirth).Result;
                        customerData.city = _global.EncryptString(customerData.city).Result;
                        customerData.roleID = _global.EncryptString(customerData.roleID).Result;
                        customerData.userID = _global.EncryptString(customerData.userID).Result;
                        customerData.tractorusageid = _global.EncryptString(customerData.tractorusageid).Result;
                        customerData.educationid = _global.EncryptString(customerData.educationid).Result;
                        customerData.mobileNoCC = _global.EncryptString(customerData.mobileNoCC).Result;
                        customerData.userNameOption = _global.EncryptString(customerData.userNameOption).Result;
                        customerData.languagePreference = _global.EncryptString(customerData.languagePreference).Result;
                        customerData.company = _global.EncryptString(customerData.company).Result;
                        customerData.state = _global.EncryptString(customerData.state).Result;
                        customerData.status = _global.EncryptString(customerData.status).Result;
                        customerData.villagecode = _global.EncryptString(customerData.villagecode).Result;
                        customerData.villagename = _global.EncryptString(customerData.villagename).Result;
                        //customerData.status = _global.EncryptString(customerData.status);



                        foreach (var itm in vehicleData)
                        {
                            itm.regNo = _global.EncryptString(itm.regNo).Result;
                            itm.vehicleCategory = _global.EncryptString(itm.vehicleCategory).Result;
                            itm.vin = _global.EncryptString(itm.vin).Result;
                            itm.vehicleTypeid = _global.EncryptString(itm.vehicleTypeid).Result;
                            itm.vehicleType = _global.EncryptString(itm.vehicleType).Result;
                            itm.vehicleModel = _global.EncryptString(itm.vehicleModel).Result;
                            itm.customname = _global.EncryptString(itm.customname).Result;
                            itm.warrantyvalidity = _global.EncryptString(itm.warrantyvalidity).Result;
                            itm.purchaseddate = _global.EncryptString(itm.purchaseddate).Result;
                            itm.installeddate = _global.EncryptString(itm.installeddate).Result;
                        }

                        if (customerData.mahindrashree != null)
                        {
                            customerData.mahindrashree.msmembershipno = _global.EncryptString(customerData.mahindrashree.msmembershipno).Result;
                            customerData.mahindrashree.msloyaltypts = _global.EncryptString(customerData.mahindrashree.msloyaltypts).Result;
                            customerData.mahindrashree.mscategory = _global.EncryptString(customerData.mahindrashree.mscategory).Result;

                            if (customerData.mahindrashree.msptshistory.Count > 0)
                            {
                                customerData.mahindrashree.msptshistory.ForEach
                                    (x =>
                                    {
                                        x.description = _global.EncryptString(x.description).Result;
                                        x.type = _global.EncryptString(x.type).Result;
                                        x.date = _global.EncryptString(x.date).Result;
                                        x.mspts = _global.EncryptString(x.mspts).Result;
                                    });
                            }
                        }


                        if (selectedCropsList != null && selectedCropsList.selectedcrops.Count > 0)
                        {
                            selectedCropsList.selectedcrops.ForEach(
                                x =>
                                {
                                    x.cropid = _global.EncryptString(x.cropid).Result;
                                    x.cropname = _global.EncryptString(x.cropname).Result;
                                });
                        }

                    }
                    //decrypt all encrypted data
                    else
                    {
                        customerData.pincode = _global.DecryptString(customerData.pincode).Result;
                        customerData.address = _global.DecryptString(customerData.address).Result;
                        customerData.mobileNo = _global.DecryptString(customerData.mobileNo).Result;
                        customerData.firstName = _global.DecryptString(customerData.firstName).Result;
                        customerData.ownedlandsize = _global.DecryptString(customerData.ownedlandsize).Result;
                        customerData.leasedlandsize = _global.DecryptString(customerData.leasedlandsize).Result;
                        customerData.educationvalue = _global.DecryptString(customerData.educationvalue).Result;
                        customerData.eMailID = _global.DecryptString(customerData.eMailID).Result;
                        customerData.imageURL = _global.DecryptString(customerData.imageURL).Result;
                    }

                    Profile.WebAPI.Models.Profile.Profile userData = new Profile.WebAPI.Models.Profile.Profile
                    {
                        contentversion = _profile.GetContentVersion(null, customerCode),
                        summary = summary,
                        serviceAccessPrivileges = serviceaccess,
                        alertCommunication = alertcommunication,
                        notificationCommunication = notification,
                        featureAccessPrivileges = feture,
                        data = customerData,
                        vehicleData = vehicleData,
                        selectedcropslist = selectedCropsList,
                        //cropslist = cropsList
                    };

                    return Ok(userData);


                //}
                //else
                //{
                //    var errData = new ErrorData()
                //    {
                //        code = 401,
                //        context = null,
                //        message = "Authentication failed",
                //        status_code = 401
                //    };
                //    var err = new Error()
                //    {
                //        error = errData
                //    };
                //    return Unauthorized(err);
                //}
            }
            catch (Exception e)
            {
                err.Message = e.Message;
                return BadRequest(err);
            }
        }

    }
}
