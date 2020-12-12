using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Dynamic;

namespace Profile.WebAPI.Models.Profile
{
    public class UpdateProfile
    {
        /// <summary>
        /// User id for Profile update
        /// </summary>

        public Boolean isSec { get; set; }

        [DefaultValue(null)]
        public string userID { get; set; }

        [DefaultValue(null)]
        public string firstName { get; set; }

        [DefaultValue(null)]
        public string lastName { get; set; }

        [DefaultValue(null)]
        public string address { get; set; }

        [DefaultValue(null)]
        public string city { get; set; }

        [DefaultValue(null)]
        public string state { get; set; }

        [DefaultValue(null)]
        public string pincode { get; set; }

        [DefaultValue(null)]
        public string country { get; set; }

        [DefaultValue(null)]
        public string eMailID { get; set; }

        [DefaultValue(null)]
        public string mobileNoCC { get; set; }

        [DefaultValue(null)]
        public string mobileNo { get; set; }

        [DefaultValue(null)]
        public string imageURL { get; set; }

        [DefaultValue(null)]
        public string company { get; set; }

        [DefaultValue(null)]
        public string dateOfBirth { get; set; }

        [DefaultValue(null)]
        public string emergencyContact { get; set; }

        [DefaultValue(null)]
        public string gender { get; set; }

        [DefaultValue(null)]
        public string languagePreference { get; set; }

        [DefaultValue(null)]
        public string userNameOption { get; set; }

        [DefaultValue(null)]
        public string action { get; set; }

        [DefaultValue(null)]
        public string status { get; set; }
        [DefaultValue(null)]
        public string ownedlandsize { get; set; }
        [DefaultValue(null)]
        public string leasedlandsize { get; set; }
        [DefaultValue(null)]
        public string tractorusage { get; set; }
        [DefaultValue(null)]
        public string educationid { get; set; }
        public string educationvalue { get; set; }

        [DefaultValue(null)]
        public List<UpdateCropForUser> croplist { get; set; }        
        public List<IDictionary<string, object>> customProfile { get; set; }

        [DefaultValue(null)]
        public List<UpdateMandiForUser> mandilist { get; set; }

        //public AlertCommunication alertCommunication { get; set; }
        //public NotificationCommunication notificationCommunication { get; set; }

        //need to discuss for custom profile
    }


    public class UpdateCropForUser
    {
        public string cropid { get; set; }
    }

    public class UpdateMandiForUser
    {
        public string mandiid { get; set; }
    }

}