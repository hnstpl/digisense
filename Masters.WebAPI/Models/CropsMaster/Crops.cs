using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
//using Masters.WebAPI.Areas.HelpPage.ModelDescriptions;

namespace Masters.WebAPI.Models.CropsMaster
{
    //[ModelName("MastersModelForCrops")]
    public class MastersModel
    {
        public List<CropsMaster> masters { get; set; }
    }


    public class CropsMaster
    {
        public decimal contentversion { get; set; }
        public string languagecode { get; set; }
        public CropsList cropslist { get; set; }
    }


    public class CropsList
    {
        public List<Crops> crops { get; set; }
        public int totalrecords { get; set; }
    }

    public class Crops
    {
        public int cropid { get; set; }
        public string cropname { get; set; }
        public string cropcode { get; set; }
        public int categoryid { get; set; }
        public string categoryname { get; set; }
        public string imageurl { get; set; }
        public int imageversion { get; set; }
    }


    public class SelectedCropsList
    {
        public List<SelectedCrops> selectedcrops { get; set; }
    }

    public class SelectedCrops
    {
        public int cropid { get; set; }
        public string cropname { get; set; }
    }

    public class LanguageCode
    {
        [DefaultValue(null)]
        public string languagecode { get; set; }
    }

}