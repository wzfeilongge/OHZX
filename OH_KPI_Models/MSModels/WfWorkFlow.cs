using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class WfWorkFlow
    {
        public int WorkFlowId { get; set; }
        public string FlowName { get; set; }
        public int FlowTemplateId { get; set; }
        public string ApplyUserId { get; set; }
        public DateTime ApplyTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public DateTime? LimitTime { get; set; }
        public string Status { get; set; }
        public string PauseFlag { get; set; }
        public string TableDataId { get; set; }
        public int? UsedHours { get; set; }
        public string IsOverTime { get; set; }
    }
}
