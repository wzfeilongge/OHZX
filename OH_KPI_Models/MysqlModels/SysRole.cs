using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class SysRole
    {
        public string Id { get; set; }
        public string ParentRoleId { get; set; }
        public int? Category { get; set; }
        public string EnCode { get; set; }
        public string FullName { get; set; }
        public int Type { get; set; }
        public sbyte? AllowEdit { get; set; }
        public sbyte? AllowDelete { get; set; }
        public int? SortCode { get; set; }
        public sbyte? EnabledMark { get; set; }
        public string Description { get; set; }
        public DateTime? CreatorTime { get; set; }
        public string CreatorUserId { get; set; }
        public DateTime? LastModifyTime { get; set; }
        public string LastModifyUserId { get; set; }
        public sbyte? LogicDeleteMark { get; set; }
        public DateTime? LogicDeleteTime { get; set; }
        public string LogicDeleteUserId { get; set; }
    }
}
