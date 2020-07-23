using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class TService
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SiteUrl { get; set; }
        public string Remark { get; set; }
        public string CreatorId { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
