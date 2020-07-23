using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class TRole
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public sbyte Status { get; set; }
        public string CreatorId { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Describe { get; set; }
        public sbyte? Administrative { get; set; }
        public sbyte? AdminLevel { get; set; }
    }
}
