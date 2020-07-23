using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemReport
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public string Deleted { get; set; }
        public int? EndFlag { get; set; }
        public string SystemText { get; set; }
        public int ReportId { get; set; }
        public string ReportName { get; set; }
        public string Descripe { get; set; }
        public int? ReportTypeId { get; set; }
        public byte[] ReportStream { get; set; }
        public string AccessRight { get; set; }
        public string ExportType { get; set; }
        public string DatabaseConn { get; set; }
        public string DataSourceType { get; set; }
        public string DataSource { get; set; }
        public string TableName { get; set; }
        public string TableQueryId { get; set; }
    }
}
