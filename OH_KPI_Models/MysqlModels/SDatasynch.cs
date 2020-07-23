using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class SDatasynch
    {
        public string Id { get; set; }
        public string TableName { get; set; }
        public string OperationType { get; set; }
        public string PrimaryKeyId { get; set; }
        public DateTime? CreateTime { get; set; }
        public sbyte? SendStatus { get; set; }
        public DateTime? SendTime { get; set; }
        public string Condition { get; set; }
        public int? SortNum { get; set; }
        public string Files { get; set; }
    }
}
