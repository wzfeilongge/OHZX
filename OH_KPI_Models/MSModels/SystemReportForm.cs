using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemReportForm
    {
        public int ReportFormId { get; set; }
        public string TableName { get; set; }
        public string ReportFormName { get; set; }
        public string DefaultFlag { get; set; }
        public string Descripe { get; set; }
        public string AccessRight { get; set; }
        public string Condition { get; set; }
        public string ApplyType { get; set; }
        public int? ReportFormTemplateId { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
