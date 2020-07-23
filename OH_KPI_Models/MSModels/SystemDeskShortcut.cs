using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemDeskShortcut
    {
        public int TableId { get; set; }
        public int? MenuId { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int? Sid { get; set; }
    }
}
