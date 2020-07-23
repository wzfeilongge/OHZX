using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class TVote
    {
        public int VoteId { get; set; }
        public string Creater { get; set; }
        public DateTime CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public string Deleted { get; set; }
        public int? EndFlag { get; set; }
        public string SystemText { get; set; }
        public string Subject { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string PublishInDefault { get; set; }
        public int? VoteCount { get; set; }
        public string IsFactName { get; set; }
    }
}
