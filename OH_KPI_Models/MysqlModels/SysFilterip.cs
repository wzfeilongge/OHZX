using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class SysFilterip
    {
        public string Id { get; set; }
        public sbyte? Type { get; set; }
        public string StartIp { get; set; }
        public string EndIp { get; set; }
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
