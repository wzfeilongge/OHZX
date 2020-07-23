using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class WfFlowProcessApply
    {
        public int ProcessApplyId { get; set; }
        public int WorkFlowId { get; set; }
        public int TemplateNodeId { get; set; }
        public DateTime ActiveTime { get; set; }
        public DateTime? OpenTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public string ApplyType { get; set; }
        public string NotifyType { get; set; }
        public string ActionCode { get; set; }
        public string NotifySubject { get; set; }
        public string NotifyContent { get; set; }
        public string NotifyReceivers { get; set; }
        public string FinishFlag { get; set; }
        public int? FromFlowProcessId { get; set; }
    }
}
