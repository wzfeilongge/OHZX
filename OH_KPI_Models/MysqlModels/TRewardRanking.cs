using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class TRewardRanking
    {
        public string Id { get; set; }
        public int? Pcsreward { get; set; }
        public int? Jgreward { get; set; }
        public int? Gtreward { get; set; }
        public int? Ptureward { get; set; }
        public int? Pazxreward { get; set; }
        public string UserId { get; set; }
        public DateTime? StatisticsTime { get; set; }
    }
}
