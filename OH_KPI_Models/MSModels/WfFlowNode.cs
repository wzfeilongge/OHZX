using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class WfFlowNode
    {
        public int WorkFlowId { get; set; }
        public int TemplateNodeId { get; set; }
        public string Status { get; set; }
    }
}
