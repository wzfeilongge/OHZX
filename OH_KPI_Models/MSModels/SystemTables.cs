using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemTables
    {
        public string TableName { get; set; }
        public string Cnname { get; set; }
        public string TypeName { get; set; }
        public string ReferFlag { get; set; }
        public string SystemFlag { get; set; }
        public string AffixFlag { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string DataProperty { get; set; }
        public string OrderBy { get; set; }
        public string OnUpdated { get; set; }
        public string OnDeleted { get; set; }
        public string OnLoad { get; set; }
        public string OnOpen { get; set; }
        public string ValidCode { get; set; }
        public string KeyField { get; set; }
        public string FieldRelation { get; set; }
        public string DataRelation { get; set; }
        public string ListType { get; set; }
        public string FormType { get; set; }
        public string EnableReportForm { get; set; }
        public string FormData { get; set; }
        public string FormData2 { get; set; }
        public string SummaryField { get; set; }
        public string NavField { get; set; }
        public string OperationConfig { get; set; }
        public string ListWhere { get; set; }
        public string RightCode { get; set; }
    }
}
