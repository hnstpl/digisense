using System;
using System.Collections.Generic;

namespace Mandi.WebAPI.DataProvider
{
    public partial class MstMenu
    {
        public MstMenu()
        {
            MstSubmenu = new HashSet<MstSubmenu>();
        }

        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string TargetLink { get; set; }
        public short? Active { get; set; }
        public int ParentTitleId { get; set; }
        public string Icon { get; set; }

        public virtual MstMenutitle ParentTitle { get; set; }
        public virtual ICollection<MstSubmenu> MstSubmenu { get; set; }
    }
}
