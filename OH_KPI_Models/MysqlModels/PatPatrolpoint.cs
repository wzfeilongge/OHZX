using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class PatPatrolpoint
    {
        public int Id { get; set; }
        public string OrganizeId { get; set; }
        public string Name { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public sbyte Enable { get; set; }
    }
}
