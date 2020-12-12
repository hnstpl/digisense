using System;
using System.Collections.Generic;

namespace Masters.WebAPI.DataProvider
{
    public partial class MstChildmenu
    {
        public int Id { get; set; }
        public int? OrderNumber { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string TargetLink { get; set; }
        public short? Active { get; set; }
        public int? ParentMenuId { get; set; }

        public virtual MstSubmenu ParentMenu { get; set; }
    }
}
