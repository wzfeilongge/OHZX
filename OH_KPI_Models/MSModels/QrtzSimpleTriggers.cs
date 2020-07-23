using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class QrtzSimpleTriggers
    {
        public string TriggerName { get; set; }
        public string TriggerGroup { get; set; }
        public long RepeatCount { get; set; }
        public long RepeatInterval { get; set; }
        public long TimesTriggered { get; set; }

        public virtual QrtzTriggers Trigger { get; set; }
    }
}
