using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemTableQuery
    {
        public int QueryId { get; set; }
        public string QueryName { get; set; }
        public string Type { get; set; }
        public string TableName { get; set; }
        public string IsQueryPage { get; set; }
        public string IsListSet { get; set; }
        public string QueryField { get; set; }
        public string OperationConfig { get; set; }
        public string ListWhere { get; set; }
        public string InitValue { get; set; }
        public string ListDisplayField { get; set; }
        public string ListNavField { get; set; }
        public string ListOrderBy { get; set; }
        public string ListQueryField { get; set; }
        public string ListOrderField { get; set; }
        public string ListAllowDisplayField { get; set; }
        public string ReportFormViewId { get; set; }
        public string ReportFormEditId { get; set; }
        public string ReportFormPrintId { get; set; }
        public string Descripe { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
