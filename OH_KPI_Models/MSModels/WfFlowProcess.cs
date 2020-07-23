using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class WfFlowProcess
    {
        public int FlowProcessId { get; set; }
        public int WorkFlowId { get; set; }
        public int TemplateNodeId { get; set; }
        public int? BatchNo { get; set; }
        public DateTime ActiveTime { get; set; }
        public DateTime? OpenTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public DateTime? LimitTime { get; set; }
        public string ProcUserId { get; set; }
        public string ConsignUserId { get; set; }
        public string Result { get; set; }
        public string ResultMemo { get; set; }
        public int? UsedHours { get; set; }
        public int? DelayHours { get; set; }
        public string IsOverTime { get; set; }
        public string TransferFlag { get; set; }
        public string BackFlag { get; set; }
        public string FinishFlag { get; set; }
        public int? FromFlowProcessId { get; set; }
    }
}
