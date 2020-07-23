using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class BaseInfoLccp
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public int? EndFlag { get; set; }
        public string Fbbh { get; set; }
        public string Mc { get; set; }
        public decimal? Sz { get; set; }
        public string Cyr { get; set; }
    }
}
