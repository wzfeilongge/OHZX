using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class PatPatrolpointgroup
    {
        public string Id { get; set; }
        public string PatrolGroupId { get; set; }
        public string OrganizeId { get; set; }
        public int PatrolPointId { get; set; }
        public string PatrolPointName { get; set; }
        public string PatrolGroupName { get; set; }
    }
}
