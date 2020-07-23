using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class TAccount
    {
        public string Id { get; set; }
        public string RoleId { get; set; }
        public string AccountName { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Contact { get; set; }
        public sbyte Status { get; set; }
        public string CreatorId { get; set; }
        public DateTime? CreateTime { get; set; }
        public sbyte? CredentialsCategory { get; set; }
        public string CredentialsNumber { get; set; }
        public string JobNum { get; set; }
        public string OrgCode { get; set; }
        public string PersonType { get; set; }
        public sbyte? Sex { get; set; }
        public string HeadImg { get; set; }
        public double? Mileage { get; set; }
        public int? StepNo { get; set; }
        public int? Reward { get; set; }
        public int? Pcsreward { get; set; }
        public int? Jgreward { get; set; }
        public int? Gtreward { get; set; }
        public int? Ptureward { get; set; }
        public int? Pazxreward { get; set; }
        public string ReceiveId { get; set; }
        public string Csrq { get; set; }
        public string Ksgzsj { get; set; }
        public string Jrbzsj { get; set; }
        public string Rdsj { get; set; }
        public string Cydh { get; set; }
        public string LeaderPostName { get; set; }
        public string UnleaderPostName { get; set; }
        public string BianZhiName { get; set; }
        public string ZzmmName { get; set; }
        public int? UserSortNum { get; set; }
        public string OriginalId { get; set; }
        public string Email { get; set; }
        public int? SumStepNo { get; set; }
        public double? SumTime { get; set; }
        public sbyte? DutyAuditStatus { get; set; }
        public DateTime? DutyAuditTime { get; set; }
        public DateTime? LastDutyTime { get; set; }
        public string JurisdictionId { get; set; }
        public string OrgCustomCode { get; set; }
        public string WxopenId { get; set; }
        public string CradImage { get; set; }
        public string CradBackImage { get; set; }
        public string DutyAuditReply { get; set; }
        public string PatrolId { get; set; }
        public string EnterpriseName { get; set; }
        public string DispatchEnterpriseName { get; set; }
        public int? TotalPatrolCoin { get; set; }
        public int? CurrentPatrolCoin { get; set; }
        public sbyte? TribeType { get; set; }
        public string TribeId { get; set; }
        public DateTime? Birthday { get; set; }
        public string DispatchTribeId { get; set; }
        public string SecurityCertificateNum { get; set; }
        public string WorkUnit { get; set; }
        public string JobName { get; set; }
        public string DeptId { get; set; }
        public string Bgdh { get; set; }
        public string Xnw { get; set; }
        public string Zw { get; set; }
        public string Gywm { get; set; }
        public sbyte? IsInside { get; set; }
        public DateTime? ApplyDutyAuditTime { get; set; }
    }
}
