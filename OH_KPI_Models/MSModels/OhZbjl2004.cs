using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class OhZbjl2004
    {
        public int Id { get; set; }
        public int? Month { get; set; }
        public int? Zbid { get; set; }
        public double? Data { get; set; }
        public string Code { get; set; }
        public int? Type { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
