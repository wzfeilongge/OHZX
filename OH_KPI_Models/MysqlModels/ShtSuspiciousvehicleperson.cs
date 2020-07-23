using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class ShtSuspiciousvehicleperson
    {
        public int Id { get; set; }
        public int Module { get; set; }
        public int ItemId { get; set; }
        public int VehiclePersonTypeIndex { get; set; }
        public int CertCategoryIndex { get; set; }
        public string CertNo { get; set; }
        public string Name { get; set; }
        public int Sex { get; set; }
        public string Phone { get; set; }
        public string Desc { get; set; }
        public DateTime CreateTime { get; set; }
        public sbyte Enable { get; set; }
    }
}
