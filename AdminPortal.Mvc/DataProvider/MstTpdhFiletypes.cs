﻿using System;
using System.Collections.Generic;

namespace AdminPortal.Mvc.DataProvider
{
    public partial class MstTpdhFiletypes
    {
        public MstTpdhFiletypes()
        {
            MstTpdhModelDetails = new HashSet<MstTpdhModelDetails>();
        }

        public int Id { get; set; }
        public string FileType { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual ICollection<MstTpdhModelDetails> MstTpdhModelDetails { get; set; }
    }
}
