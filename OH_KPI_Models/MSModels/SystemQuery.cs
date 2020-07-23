using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemQuery
    {
        public int QueryId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string TableName { get; set; }
        public string QueryName { get; set; }
        public string SqlStr { get; set; }
        public string Description { get; set; }
    }
}
