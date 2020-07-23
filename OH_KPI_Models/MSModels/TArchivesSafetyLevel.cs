using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class TArchivesSafetyLevel
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public int? EndFlag { get; set; }
        public string AccessRight { get; set; }
        public string SafetyLevelId { get; set; }
        public string SafetyLevelName { get; set; }
    }
}
