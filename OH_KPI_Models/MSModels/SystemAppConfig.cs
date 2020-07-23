using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemAppConfig
    {
        public int AppId { get; set; }
        public string AppName { get; set; }
        public string Descripe { get; set; }
        public string LoginTypeSet { get; set; }
        public string LoginTypeDefault { get; set; }
        public string OnLoginBefore { get; set; }
        public string OnLoginAfter { get; set; }
        public string OnApplicationStart { get; set; }
        public string OnApplicationEnd { get; set; }
        public string OnSessionStart { get; set; }
        public string OnSessionEnd { get; set; }
        public string Smsusers { get; set; }
        public string SmsfreeUsers { get; set; }
        public string Sms2Users { get; set; }
        public string Sms2freeUsers { get; set; }
    }
}
