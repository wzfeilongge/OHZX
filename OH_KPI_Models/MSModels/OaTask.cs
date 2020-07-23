using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class OaTask
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public string Deleted { get; set; }
        public int? EndFlag { get; set; }
        public string SystemText { get; set; }
        public string TaskId { get; set; }
        public string TaskName { get; set; }
        public string Receiver { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? RequestFinishTime { get; set; }
        public string TaskStatus { get; set; }
        public string TaskRequest { get; set; }
        public string Feedback { get; set; }
        public string OrigData { get; set; }
        public DateTime? StartTime { get; set; }
        public string CreateUser { get; set; }
    }
}
