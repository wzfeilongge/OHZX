using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemReportQueryParm
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public string Deleted { get; set; }
        public string EndFlag { get; set; }
        public string SystemText { get; set; }
        public string ReportId { get; set; }
        public string ParmName { get; set; }
        public string ParmCaption { get; set; }
        public string DisplayType { get; set; }
        public string DisplayTypeData { get; set; }
        public string DefaultData { get; set; }
        public string DataType { get; set; }
    }
}
