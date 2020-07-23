using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemUserDefine
    {
        public int DeployId { get; set; }
        public string UserId { get; set; }
        public short? ListLines { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string StylePath { get; set; }
        public string DateFormat { get; set; }
        public string TimeFormat { get; set; }
        public string AlertVoice { get; set; }
        public string PrivateSeal { get; set; }
    }
}
