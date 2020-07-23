using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class SysLog
    {
        public string Id { get; set; }
        public DateTime? Date { get; set; }
        public string Account { get; set; }
        public string NickName { get; set; }
        public string Type { get; set; }
        public string Ipaddress { get; set; }
        public string IpaddressName { get; set; }
        public string ModuleId { get; set; }
        public string ModuleName { get; set; }
        public sbyte? Result { get; set; }
        public string Description { get; set; }
        public DateTime? CreatorTime { get; set; }
        public string CreatorUserId { get; set; }
    }
}
