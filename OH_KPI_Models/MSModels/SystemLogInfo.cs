using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemLogInfo
    {
        public decimal LogId { get; set; }
        public DateTime LogDate { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Operation { get; set; }
        public string RemoteIp { get; set; }
        public string ModelName { get; set; }
        public string Referer { get; set; }
    }
}
