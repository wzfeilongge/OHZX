using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class BaseInfoGzjl
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public int? EndFlag { get; set; }
        public DateTime? Qssj { get; set; }
        public DateTime? Zzsj { get; set; }
        public string Szdw { get; set; }
        public string Drzw { get; set; }
        public string Fbbh { get; set; }
    }
}
