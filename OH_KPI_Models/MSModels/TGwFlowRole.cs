using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class TGwFlowRole
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public int? EndFlag { get; set; }
        public string RoleName { get; set; }
        public string FwNodeProcUserSh { get; set; }
        public string FwNodeProcUserHg { get; set; }
        public string FwNodeProcUserHq { get; set; }
        public string FwNodeProcUserQf { get; set; }
        public string FwNodeProcUserFh { get; set; }
        public string FwNodeProcUserDj { get; set; }
        public string RoleRange { get; set; }
        public string SwNodeProcUserNb { get; set; }
        public string SwNodeProcUserPb { get; set; }
        public string SwNodeProcUserCy { get; set; }
        public string SwNodeProcUserGd { get; set; }
        public string Type { get; set; }
    }
}
