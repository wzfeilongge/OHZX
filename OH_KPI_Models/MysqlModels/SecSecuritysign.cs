using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class SecSecuritysign
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string RealName { get; set; }
        public string OrganizeId { get; set; }
        public string OrganizeName { get; set; }
        public string GatherAddress { get; set; }
        public DateTime SignTime { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
