using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemErrorLog
    {
        public int LogId { get; set; }
        public DateTime? LogTime { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string RemoteIp { get; set; }
        public string Browser { get; set; }
        public string Os { get; set; }
        public DateTime? ErrDate { get; set; }
        public string ErrMessage { get; set; }
        public string Content { get; set; }
        public string CodeFile { get; set; }
    }
}
