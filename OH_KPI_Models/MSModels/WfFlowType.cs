using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class WfFlowType
    {
        public int FlowTypeId { get; set; }
        public string TypeName { get; set; }
        public int? ParentTypeId { get; set; }
        public string Descripe { get; set; }
        public int? Sequence { get; set; }
        public string CreaterId { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
