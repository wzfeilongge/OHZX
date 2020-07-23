using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class SysOrganize
    {
        public string Id { get; set; }
        public string ParentId { get; set; }
        public int? Layers { get; set; }
        public string EnCode { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public int CategoryId { get; set; }
        public string ManagerId { get; set; }
        public string TelePhone { get; set; }
        public string MobilePhone { get; set; }
        public string WeChat { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string AreaId { get; set; }
        public string Address { get; set; }
        public sbyte? AllowEdit { get; set; }
        public sbyte? AllowDelete { get; set; }
        public int? SortCode { get; set; }
        public sbyte? EnabledMark { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public DateTime? CreatorTime { get; set; }
        public string CreatorUserId { get; set; }
        public DateTime? LastModifyTime { get; set; }
        public string LastModifyUserId { get; set; }
        public sbyte? LogicDeleteMark { get; set; }
        public DateTime? LogicDeleteTime { get; set; }
        public string LogicDeleteUserId { get; set; }
    }
}
