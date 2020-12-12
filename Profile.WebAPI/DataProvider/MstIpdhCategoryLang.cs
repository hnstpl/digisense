﻿using System;
using System.Collections.Generic;

namespace Profile.WebAPI.DataProvider
{
    public partial class MstIpdhCategoryLang
    {
        public int Id { get; set; }
        public int ImplementCategoryId { get; set; }
        public string ImpCategoryName { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstIpdhCategory ImplementCategory { get; set; }
        public virtual MstLanguage MstLang { get; set; }
    }
}
