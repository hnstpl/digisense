using System;
using System.Collections.Generic;

namespace Profile.WebAPI.DataProvider
{
    public partial class TblAdminusers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? RoleId { get; set; }
        public short? Active { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual MstUserrole Role { get; set; }
    }
}
