using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemDepartment
    {
        public int DepartId { get; set; }
        public string Creater { get; set; }
        public DateTime CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public string EndFlag { get; set; }
        public int? ParentId { get; set; }
        public string SystemText { get; set; }
        public string DepartName { get; set; }
        public int? MainDuty { get; set; }
        public int? Sequence { get; set; }
        public string IsEnabled { get; set; }
    }
}
