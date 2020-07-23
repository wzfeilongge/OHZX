using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemAffix
    {
        public int AffixId { get; set; }
        public string TableName { get; set; }
        public string TableId { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Creater { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string Description { get; set; }
        public string IsRefers { get; set; }
    }
}
