using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemDayViewModule
    {
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string TableName { get; set; }
        public string TableQueryId { get; set; }
        public string DateField { get; set; }
        public string SubjectField { get; set; }
        public string DescripeField { get; set; }
        public string StatusField { get; set; }
        public string StatusAllowValue { get; set; }
        public string DateCompFormat { get; set; }
        public string IsNew { get; set; }
        public string Creater { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
