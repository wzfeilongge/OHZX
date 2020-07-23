using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class WfFlowTemplate
    {
        public int FlowTemplateId { get; set; }
        public string TemplateName { get; set; }
        public int FlowTypeId { get; set; }
        public string TableName { get; set; }
        public int? TableQueryId { get; set; }
        public string TableBaseActions { get; set; }
        public string IsPigeonhole { get; set; }
        public string PigeonholeFieldList { get; set; }
        public string EnableWord { get; set; }
        public string EnableAffix { get; set; }
        public string WordTemplateType { get; set; }
        public int? WordTemplateId { get; set; }
        public byte[] ObjectData { get; set; }
        public string StartRight { get; set; }
        public string TrackRight { get; set; }
        public string ManageRight { get; set; }
        public string StartEvent { get; set; }
        public string EndEvent { get; set; }
        public string CancelEvent { get; set; }
        public string OverTimeEvent { get; set; }
        public string TransEvent { get; set; }
        public int? LimitHours { get; set; }
        public string Descripe { get; set; }
        public string CreaterId { get; set; }
        public DateTime? CreateTime { get; set; }
        public string IsActive { get; set; }
    }
}
