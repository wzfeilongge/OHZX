using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class OhSet
    {
        public int Id { get; set; }
        public int? JudgesNum { get; set; }
        public int? StaffNum { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
