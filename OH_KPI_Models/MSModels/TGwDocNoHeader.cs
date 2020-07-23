using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class TGwDocNoHeader
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public int? EndFlag { get; set; }
        public string BranchRange { get; set; }
        public string DocNoHeader { get; set; }
    }
}
