using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemMessageType
    {
        public string TypeId { get; set; }
        public string TypeName { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
