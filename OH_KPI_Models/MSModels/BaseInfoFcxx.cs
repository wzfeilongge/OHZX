using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class BaseInfoFcxx
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public int? EndFlag { get; set; }
        public string Fbbh { get; set; }
        public string Fcdz { get; set; }
        public string Jzmj { get; set; }
        public string Lyjg { get; set; }
    }
}
