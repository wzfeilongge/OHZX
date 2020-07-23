using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class TRewardLog
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string ScheduleId { get; set; }
        public string TaskCode { get; set; }
        public int? DutyTypeCode { get; set; }
        public int? Change { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Describe { get; set; }
        public string AttendanceId { get; set; }
        public int? BaseDuty { get; set; }
        public int? Type { get; set; }
        public string TypeName { get; set; }
        public string CheckupPersonId { get; set; }
        public string CheckupVehicleId { get; set; }
        public string IsWaitAudit { get; set; }
        public int? DutyType { get; set; }
    }
}
