﻿using System;
using System.Collections.Generic;

namespace AdminPortal.Mvc.DataProvider
{
    public partial class MstBannercategoryLang
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int MstLangId { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstBannercategory Category { get; set; }
        public virtual MstLanguage MstLang { get; set; }
    }
}
