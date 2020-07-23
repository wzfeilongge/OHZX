using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemSms
    {
        public decimal Id { get; set; }
        public string MobileNo { get; set; }
        public string Message { get; set; }
        public DateTime? SmsTime { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Creater { get; set; }
        public string IsSend { get; set; }
        public int? SendTimes { get; set; }
    }
}
