﻿using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class TGwDocType
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public int? EndFlag { get; set; }
        public string TypeName { get; set; }
        public string DocType { get; set; }
    }
}
