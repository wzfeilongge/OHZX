using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class PatUsertrack
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string OrganizeId { get; set; }
        public int PatrolState { get; set; }
        public string PatrolPointGroupId { get; set; }
        public double StartTime { get; set; }
        public double EndTime { get; set; }
        public string StartAddress { get; set; }
        public string EndAddress { get; set; }
        public long Integral { get; set; }
        public double Mileage { get; set; }
        public double LongTime { get; set; }
        public string TrackJson { get; set; }
        public int StepCount { get; set; }
        public string RealName { get; set; }
        public string OrganizeName { get; set; }
    }
}
