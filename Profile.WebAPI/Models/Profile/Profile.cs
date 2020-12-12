using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Profile.WebAPI.Models.Profile
{

    /// <summary>
    /// Profile request data
    /// </summary>
    public class Profile
    {
        public int contentversion { get; set; }
        public Summary summary { get; set; }
        public List<ServiceAccessPrivileges> serviceAccessPrivileges { get; set; }
        public List<AlertCommunication> alertCommunication { get; set; }
        public Data data { get; set; }
        public List<VehicleData> vehicleData { get; set; }
        public List<NotificationCommunication> notificationCommunication { get; set; }
        public List<FeatureAccessPrivileges> featureAccessPrivileges { get; set; }
        public SelectedCropsList selectedcropslist { get; set; }
        //public CropsList cropslist { get; set; }

    }

    /// <summary>
    /// Summary
    /// </summary>
    public class Summary
    {
        public int alertUnReadCount { get; set; }
        public int notificationUnReadCount { get; set; }
        public int alertReadCount { get; set; }
        public int notificationReadCount { get; set; }
    }

    /// <summary>
    /// User information
    /// </summary>
    public class Data
    {
        public string lastName { get; set; }
        public string pincode { get; set; }
        public string alertCommControl { get; set; }
        public string country { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public string city { get; set; }
        public string roleID { get; set; }
        //public double dateOfBirth { get; set; }
        public string /*encrypt*/dateofbirth { get; set; }
        public string mobileNo { get; set; }
        //custom profile need json parameters for this array
        public List<ExpandoObject> customProfile { get; set; }
        public string userID { get; set; }
        public string firstName { get; set; }
        public string ownedlandsize { get; set; }
        public string leasedlandsize { get; set; }
        public string tractorusageid { get; set; }
        public string educationid { get; set; }
        public string educationvalue { get; set; }
        public string mobileNoCC { get; set; }
        public string userNameOption { get; set; }
        public string languagePreference { get; set; }
        public string eMailID { get; set; }
        public string imageURL { get; set; }
        public int imageversion { get; set; }
        public string company { get; set; }
        public string state { get; set; }
        public string status { get; set; }
        public string villagecode { get; set; }
        public string villagename { get; set; }
        public SRMahindraShree mahindrashree { get; set; }        
    }

    public class CustomProfile
    {

    }


    public class SRMahindraShree
    {
        public string msmembershipno { get; set; }
        public string msloyaltypts { get; set; }
        public string mscategory { get; set; }
        public List<LoyaltyptsHistory> msptshistory { get; set; }

    }

    public class LoyaltyptsHistory
    {
        public string description { get; set; }
        public string type { get; set; }
        public string date { get; set; }
        public string mspts { get; set; }
    }

    /// <summary>
    /// Gender
    /// </summary>
    public enum Gender
    {
        Male,
        Female,
        Transgender
    }

    /// <summary>
    /// Vehicle information
    /// </summary>
    public class VehicleData
    {
        public string regNo { get; set; }
        public string vehicleModel { get; set; }
        public string vin { get; set; }
        public string vehicleTypeid { get; set; }
        public string vehicleType { get; set; }
        public string vehicleCategory { get; set; }
        public string customname { get; set; }
        public string warrantyvalidity { get; set; }
        public string purchaseddate { get; set; }
        public string installeddate { get; set; }
        public ServiceAdvisor serviceadvisor { get; set; }

    }

    public class ServiceAdvisor
    {
        public string serviceadvisorname { get; set; }
        public string serviceadvisornumber { get; set; }
    }

    /// <summary>
    /// Alert Communication
    /// </summary>
    public class AlertCommunication
    {
        public string alertTypeID { get; set; }
        public Boolean alertViaSMS { get; set; }
        public Boolean alertViaEmail { get; set; }
        public Boolean alertViaPushNotification { get; set; }
    }

    /// <summary>
    /// Notification communication
    /// </summary>
    public class NotificationCommunication
    {
        public string notificationTypeID { get; set; }
        public Boolean notificationViaSMS { get; set; }
        public Boolean notificationViaEmail { get; set; }
        public Boolean notificationViaPushNotification { get; set; }
    }

    /// <summary>
    /// Service access privileges
    /// </summary>
    public class ServiceAccessPrivileges
    {
        public string serviceID { get; set; }
        public Boolean serviceView { get; set; }
        public Boolean serviceEdit { get; set; }
        public Boolean serviceModify { get; set; }
        public Boolean serviceCreate { get; set; }
    }

    /// <summary>
    /// Feature access privileges
    /// </summary>
    public class FeatureAccessPrivileges
    {
        public string featureID { get; set; }
        public Boolean featureView { get; set; }
        public Boolean featureEdit { get; set; }
        public Boolean featureModify { get; set; }
        public Boolean featureCreate { get; set; }
    }

    public class MasterMyProfile
    {
        public List<MyProf> MyProfile { get; set; }
        public int totalrecords { get; set; }
    }


    public class MyProf
    {
        public string name { get; set; }
        public DateTime birthdate { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string image { get; set; }
        public List<MahindraShree> mahindrashree { get; set; }
    }


    public class MahindraShree
    {
        public string category { get; set; }
        public string membershipno { get; set; }
        public string avaliLoyaltypts { get; set; }
        public List<MSLoyaltyPointsHistory> loyaltyptshistory { get; set; }
    }

    public class MSLoyaltyPointsHistory
    {
        public string transdate { get; set; }
        public string transsummary { get; set; }
        public string pts { get; set; }
    }


    public class CropsList
    {
        public List<Crops> crops { get; set; }
    }

    public class Crops
    {
        public string cropid { get; set; }
        public string cropname { get; set; }
        public string cropcode { get; set; }
        public string categoryid { get; set; }
        public string categoryname { get; set; }
        public string imageurl { get; set; }
        public string imageversion { get; set; }
    }


    public class SelectedCropsList
    {
        public List<SelectedCrops> selectedcrops { get; set; }
    }

    public class SelectedCrops
    {
        public string cropid { get; set; }
        public string cropname { get; set; }
    }

    public class LanguageCode
    {
        [DefaultValue(null)]
        public string languagecode { get; set; }
    }

}