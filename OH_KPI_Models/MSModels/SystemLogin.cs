using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemLogin
    {
        public decimal LogId { get; set; }
        public DateTime LoginTime { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string RemoteIp { get; set; }
        public string Browser { get; set; }
        public string UserOs { get; set; }
        public DateTime? LogoutTime { get; set; }
    }
}
