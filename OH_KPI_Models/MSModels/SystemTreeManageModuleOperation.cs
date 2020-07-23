using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemTreeManageModuleOperation
    {
        public int ModuleId { get; set; }
        public string OptName { get; set; }
        public string AccessRight { get; set; }
        public string ToolTip { get; set; }
        public string Alert { get; set; }
        public string OptCode { get; set; }
    }
}
