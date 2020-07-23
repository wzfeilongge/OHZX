using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class QrtzCronTriggers
    {
        public string TriggerName { get; set; }
        public string TriggerGroup { get; set; }
        public string CronExpression { get; set; }
        public string TimeZoneId { get; set; }

        public virtual QrtzTriggers Trigger { get; set; }
    }
}
