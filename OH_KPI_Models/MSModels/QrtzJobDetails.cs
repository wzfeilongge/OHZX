using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class QrtzJobDetails
    {
        public QrtzJobDetails()
        {
            QrtzJobListeners = new HashSet<QrtzJobListeners>();
            QrtzTriggers = new HashSet<QrtzTriggers>();
        }

        public string JobName { get; set; }
        public string JobGroup { get; set; }
        public string Description { get; set; }
        public string JobClassName { get; set; }
        public string IsDurable { get; set; }
        public string IsVolatile { get; set; }
        public string IsStateful { get; set; }
        public string RequestsRecovery { get; set; }
        public byte[] JobData { get; set; }

        public virtual ICollection<QrtzJobListeners> QrtzJobListeners { get; set; }
        public virtual ICollection<QrtzTriggers> QrtzTriggers { get; set; }
    }
}
