using System;
using System.Collections.Generic;

namespace UserAnalyticsMaster.WebAPI.DataProvider
{
    public partial class MstUserrole
    {
        public MstUserrole()
        {
            TblAdminusers = new HashSet<TblAdminusers>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; }
        public short? Active { get; set; }

        public virtual ICollection<TblAdminusers> TblAdminusers { get; set; }
    }
}
