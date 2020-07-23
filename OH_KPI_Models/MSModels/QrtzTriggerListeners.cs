using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class QrtzTriggerListeners
    {
        public string TriggerName { get; set; }
        public string TriggerGroup { get; set; }
        public string TriggerListener { get; set; }

        public virtual QrtzTriggers Trigger { get; set; }
    }
}
