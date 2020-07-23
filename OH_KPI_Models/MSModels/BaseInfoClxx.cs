using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class BaseInfoClxx
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public int? EndFlag { get; set; }
        public string Fbbh { get; set; }
        public string Ppxh { get; set; }
        public string Pzh { get; set; }
        public int? Gmjg { get; set; }
        public DateTime? Gmsj { get; set; }
    }
}
