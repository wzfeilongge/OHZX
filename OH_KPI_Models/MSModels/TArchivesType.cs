using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class TArchivesType
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public int? EndFlag { get; set; }
        public string TypeId { get; set; }
        public string TypeName { get; set; }
        public string Descripe { get; set; }
        public string DataTableName { get; set; }
        public string FileTableName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string AccessRight { get; set; }
        public string CreateUser { get; set; }
        public int? Sequence { get; set; }
        public string ParentId { get; set; }
        public string AccessRightList { get; set; }
        public string IsPigeonhole { get; set; }
    }
}
