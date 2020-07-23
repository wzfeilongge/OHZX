using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemStat
    {
        public int StatId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string TableName { get; set; }
        public string StatName { get; set; }
        public string Description { get; set; }
        public string AutoRow { get; set; }
        public string AutoRowValue { get; set; }
        public string AutoCol { get; set; }
        public string AutoColValue { get; set; }
        public string IsCollect { get; set; }
        public string Custom { get; set; }
        public string RangeValue { get; set; }
        public string RangeText { get; set; }
    }
}
