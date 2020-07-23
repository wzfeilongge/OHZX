using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemTreeManageModule
    {
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string TableName { get; set; }
        public string TableQueryId { get; set; }
        public string IdField { get; set; }
        public string TextField { get; set; }
        public string ParentField { get; set; }
        public string RootValue { get; set; }
        public string SortField { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
