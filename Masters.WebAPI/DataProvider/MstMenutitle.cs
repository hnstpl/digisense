using System;
using System.Collections.Generic;

namespace Masters.WebAPI.DataProvider
{
    public partial class MstMenutitle
    {
        public MstMenutitle()
        {
            MstMenu = new HashSet<MstMenu>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public short? Active { get; set; }
        public int OrderNumber { get; set; }

        public virtual ICollection<MstMenu> MstMenu { get; set; }
    }
}
