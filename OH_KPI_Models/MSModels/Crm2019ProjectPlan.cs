using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class Crm2019ProjectPlan
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public int? EndFlag { get; set; }
        public string Xmbh { get; set; }
        public string Jhyjd { get; set; }
        public DateTime? Tjsj { get; set; }
        public string Tjr { get; set; }
        public string Tjroaid { get; set; }
        public string Tjrddid { get; set; }
        public string Zbbh { get; set; }
    }
}
