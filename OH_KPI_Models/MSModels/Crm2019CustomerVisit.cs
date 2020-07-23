using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class Crm2019CustomerVisit
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public int? EndFlag { get; set; }
        public string Khbh { get; set; }
        public DateTime? Sj { get; set; }
        public string Bfnr { get; set; }
        public string Khfk { get; set; }
        public string Bbfkh { get; set; }
        public string Zbbh { get; set; }
        public string Dwmc { get; set; }
        public string VisitWay { get; set; }
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string VisitType { get; set; }
    }
}
