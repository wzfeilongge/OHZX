using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class PersonalTask
    {
        public int TaskId { get; set; }
        public string UserId { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public int? TypeId { get; set; }
        public string Level { get; set; }
        public string Status { get; set; }
        public string IsRemind { get; set; }
        public int? Renum { get; set; }
        public int? Rmnum { get; set; }
        public int? RemindType { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
