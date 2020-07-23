using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class SysDictionary
    {
        public int Id { get; set; }
        public string Module { get; set; }
        public int Index { get; set; }
        public string Value { get; set; }
    }
}
