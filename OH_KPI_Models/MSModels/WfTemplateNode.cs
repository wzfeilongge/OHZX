using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class WfTemplateNode
    {
        public int FlowTemplateId { get; set; }
        public int TemplateNodeId { get; set; }
        public string NodeName { get; set; }
        public string NodeType { get; set; }
        public string IteratorLays { get; set; }
        public string SendTitle { get; set; }
        public string ActionType { get; set; }
        public string ActionConfig { get; set; }
        public string ActionCode { get; set; }
        public string NotifyType { get; set; }
        public string NotifySubject { get; set; }
        public string NotifyContent { get; set; }
        public string RoleUnitList { get; set; }
        public string RoleUnitName { get; set; }
        public string RoleUnitCondition { get; set; }
        public string ChildTableRightList { get; set; }
        public string RoleunitCode { get; set; }
        public string RoleUnitLimit { get; set; }
        public string RoleUnitProcLogic { get; set; }
        public string RoleUnitRangeType { get; set; }
        public string ResultList { get; set; }
        public string ResultProcType { get; set; }
        public string ResultRight { get; set; }
        public int? LimitHours { get; set; }
        public string WordLevel { get; set; }
        public string AffixLevel { get; set; }
        public string FieldRightList { get; set; }
        public string ActionRightList { get; set; }
        public string IsEditExpandFields { get; set; }
        public string IsJoinNodeSelect { get; set; }
        public string IsReturn { get; set; }
        public string IsRecall { get; set; }
        public string IsTransfer { get; set; }
        public string IsAppoint { get; set; }
        public string IsSkipForNullRole { get; set; }
        public int? Xpos { get; set; }
        public int? Ypos { get; set; }
        public int? Cxpos { get; set; }
        public int? Cypos { get; set; }
        public int? GroupId { get; set; }
        public string GroupName { get; set; }
        public int? GroupSequence { get; set; }
        public string Descripe { get; set; }
    }
}
