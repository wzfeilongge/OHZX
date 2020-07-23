using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemResourceViewModule
    {
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string LayoutType { get; set; }
        public string ResourceZytitle { get; set; }
        public string RsZyTableName { get; set; }
        public string RsZyTableQueryId { get; set; }
        public string RsZyKeyIdField { get; set; }
        public string RsZyKeyNameField { get; set; }
        public string RsZySubjectField { get; set; }
        public string RsZyStartTimeField { get; set; }
        public string RsZyEndTimeField { get; set; }
        public string RsZyStatusField { get; set; }
        public string RsZyStatusAllowValue { get; set; }
        public string RsTableName { get; set; }
        public string RsKeyIdField { get; set; }
        public string RsKeyNameField { get; set; }
        public string RsDescripeField { get; set; }
        public string RsSortField { get; set; }
        public string RsSortAsc { get; set; }
        public string IsNew { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
