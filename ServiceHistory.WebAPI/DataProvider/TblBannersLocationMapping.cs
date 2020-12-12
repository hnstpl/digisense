﻿using System;
using System.Collections.Generic;

namespace ServiceHistoryMaster.WebAPI.DataProvider
{
    public partial class TblBannersLocationMapping
    {
        public int Id { get; set; }
        public int BannerId { get; set; }
        public string StateCodeI { get; set; }
        public string DistrictCodeVc { get; set; }

        public virtual TblBanners Banner { get; set; }
        public virtual MstDistrict DistrictCodeVcNavigation { get; set; }
        public virtual MstState StateCodeINavigation { get; set; }
    }
}
