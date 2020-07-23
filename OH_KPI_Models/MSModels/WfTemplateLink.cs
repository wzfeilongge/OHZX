using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class WfTemplateLink
    {
        public int FlowTemplateId { get; set; }
        public int TemplateLinkId { get; set; }
        public string LinkName { get; set; }
        public string ConditionList { get; set; }
        public int? FromNodeId { get; set; }
        public int? ToNodeId { get; set; }
        public int? Xpos { get; set; }
        public int? Ypos { get; set; }
        public int? Cxpos { get; set; }
        public int? Cypos { get; set; }
        public string Descripe { get; set; }
    }
}
