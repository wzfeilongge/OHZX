using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class WfFlowConsignAgent
    {
        public int ConsignAgentId { get; set; }
        public string ConsignUserId { get; set; }
        public string AgentUser { get; set; }
        public int FlowTemplateId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
