using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class SysVerifysmsmessage
    {
        public long Id { get; set; }
        public string Telphone { get; set; }
        public string KeyValue { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime OverdueTime { get; set; }
        public int ValidityType { get; set; }
    }
}
