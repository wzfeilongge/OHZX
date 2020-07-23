using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemScheduler
    {
        public string SchedulerId { get; set; }
        public DateTime CreateTime { get; set; }
        public string Name { get; set; }
        public string CronExpr { get; set; }
        public string ExecuteCode { get; set; }
    }
}
