using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class SysUserlogon
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public int UserType { get; set; }
        public string UserPassword { get; set; }
        public string UserSecretkey { get; set; }
        public int RegType { get; set; }
        public DateTime? AllowStartTime { get; set; }
        public DateTime? AllowEndTime { get; set; }
        public DateTime? LockStartDate { get; set; }
        public DateTime? LockEndDate { get; set; }
        public DateTime? FirstVisitTime { get; set; }
        public DateTime? PreviousVisitTime { get; set; }
        public DateTime? LastVisitTime { get; set; }
        public DateTime? ChangePasswordDate { get; set; }
        public sbyte? MultiUserLogin { get; set; }
        public int? LogOnCount { get; set; }
        public sbyte? UserOnLine { get; set; }
        public string Question { get; set; }
        public string AnswerQuestion { get; set; }
        public sbyte? CheckIpaddress { get; set; }
        public string Language { get; set; }
        public string Theme { get; set; }
    }
}
