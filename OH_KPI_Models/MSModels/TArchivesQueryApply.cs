using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class TArchivesQueryApply
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public int? EndFlag { get; set; }
        public string ArchivesNo { get; set; }
        public string ApprStatus { get; set; }
        public DateTime? EndDate { get; set; }
        public string ApplyBranch { get; set; }
        public string ApplyUser { get; set; }
        public string Descripe { get; set; }
        public DateTime? ApplyEndDate { get; set; }
        public string Subject { get; set; }
        public string SafetyLevel { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
