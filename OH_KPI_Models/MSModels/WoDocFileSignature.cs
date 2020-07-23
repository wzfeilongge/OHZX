using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class WoDocFileSignature
    {
        public int SignatureId { get; set; }
        public string RecordId { get; set; }
        public string MarkName { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? DateTime { get; set; }
        public string RemoteIp { get; set; }
        public string MarkGuid { get; set; }
        public string Descript { get; set; }
    }
}
