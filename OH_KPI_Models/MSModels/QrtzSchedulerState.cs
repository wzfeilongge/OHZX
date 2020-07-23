using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class QrtzSchedulerState
    {
        public string InstanceName { get; set; }
        public long LastCheckinTime { get; set; }
        public long CheckinInterval { get; set; }
    }
}
