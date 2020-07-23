using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class WfFlowHurryPress
    {
        public int HurryPressId { get; set; }
        public int WorkFlowId { get; set; }
        public string PressUserId { get; set; }
        public DateTime? PressTime { get; set; }
        public string Content { get; set; }
        public string RoleUnitList { get; set; }
    }
}
