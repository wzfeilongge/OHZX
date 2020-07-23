using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class QrtzJobListeners
    {
        public string JobName { get; set; }
        public string JobGroup { get; set; }
        public string JobListener { get; set; }

        public virtual QrtzJobDetails Job { get; set; }
    }
}
