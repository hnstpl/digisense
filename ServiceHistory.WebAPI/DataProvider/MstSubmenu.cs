using System;
using System.Collections.Generic;

namespace ServiceHistoryMaster.WebAPI.DataProvider
{
    public partial class MstSubmenu
    {
        public MstSubmenu()
        {
            MstChildmenu = new HashSet<MstChildmenu>();
        }

        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string TargetLink { get; set; }
        public short? Active { get; set; }
        public int ParenMenutId { get; set; }

        public virtual MstMenu ParenMenut { get; set; }
        public virtual ICollection<MstChildmenu> MstChildmenu { get; set; }
    }
}
