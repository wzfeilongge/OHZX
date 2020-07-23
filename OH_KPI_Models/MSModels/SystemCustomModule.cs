using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemCustomModule
    {
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDescripe { get; set; }
        public string ModuleCode { get; set; }
        public string ModuleFileName { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
