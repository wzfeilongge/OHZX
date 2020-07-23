using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class SysUser
    {
        public string Id { get; set; }
        public int Type { get; set; }
        public string Account { get; set; }
        public string RoleId { get; set; }
        public string RealName { get; set; }
        public string NickName { get; set; }
        public string HeadIcon { get; set; }
        public sbyte? Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public string MobilePhone { get; set; }
        public string Signature { get; set; }
        public string OrganizeId { get; set; }
        public sbyte? IsAdministrator { get; set; }
        public sbyte? EnabledMark { get; set; }
        public string Description { get; set; }
        public string PatrolPointGroupId { get; set; }
        public sbyte DataFinish { get; set; }
        public sbyte AuthOk { get; set; }
        public int OccupationId { get; set; }
        public string Sfzh { get; set; }
        public string Company { get; set; }
        public string Job { get; set; }
        public string Address { get; set; }
        public sbyte HaveAddBaiduEntity { get; set; }
        public DateTime? CreatorTime { get; set; }
        public string CreatorUserId { get; set; }
        public DateTime? LastModifyTime { get; set; }
        public string LastModifyUserId { get; set; }
        public sbyte? LogicDeleteMark { get; set; }
        public DateTime? LogicDeleteTime { get; set; }
        public string LogicDeleteUserId { get; set; }
        public string OpenId { get; set; }
        public string AppSystem { get; set; }
        public string AppVersion { get; set; }
        public string AppType { get; set; }
    }
}
