﻿using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class OhCbxx
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int? Cid { get; set; }
        public bool? IsEnable { get; set; }
        public int? SourceType { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
