using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace EnquiryMasters.WebAPI.Models.Enquiry
{
    public class Enquiry
    {
        public bool isSec { get; set; }
        [DefaultValue(null)]
        public int enquiryid { get; set; }
        [DefaultValue(null)]
        public double enquirydate { get; set; }
        [Required]
        [DefaultValue(null)]
        public string name { get; set; }
        [Required]
        [DefaultValue(null)]
        public string villagecode { get; set; }
        [Required]
        [DefaultValue(null)]
        public string mobile { get; set; }
        [DefaultValue(null)]
        public string referralname { get; set; }
        [DefaultValue(null)]
        public string referralvillagecode { get; set; }
        [DefaultValue(null)]
        public string referralmobile { get; set; }
        [DefaultValue(null)]
        public EnquiryType enquirytype { get; set; }
        [DefaultValue(null)]
        public string dealerbranchcode { get; set; }
        [DefaultValue(null)]
        public string tractorbrand { get; set; }
        [DefaultValue(null)]
        public ProductFlag productflag { get; set; }
        [DefaultValue(null)]
        public string modelcode { get; set; }
        [DefaultValue(null)]
        public string yearofmanufacturing { get; set; }
        [DefaultValue(false)]
        public Boolean rcavailability { get; set; }
        [DefaultValue(null)]
        public InterestedProduct interestedproduct { get; set; }
        [DefaultValue(null)]
        public string interestedmodelcode { get; set; }
        [DefaultValue(null)]
        public ImageList imagelist { get; set; }
        [DefaultValue(null)]
        public string remarks { get; set; }
    }

    [Flags]
    public enum EnquiryType
    {
        GeneralEnquiry = 1,
        ReferralEnquiry = 2,
        TractorEvaluationAndExchange =3
    }

    [Flags]
    public enum ProductFlag
    {
        Tractor = 1,
        Implements = 2
    }

    [Flags]
    public enum InterestedProduct
    {
        Tractor = 1,
        Implements = 2,
        None = 3
    }

    public class ImageList
    {
        public List<string> images { get; set; }
    }

}