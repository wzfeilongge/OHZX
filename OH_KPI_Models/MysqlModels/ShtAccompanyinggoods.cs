using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class ShtAccompanyinggoods
    {
        public int Id { get; set; }
        public int Module { get; set; }
        public int ItemId { get; set; }
        public int CategoryIndex { get; set; }
        public string Card { get; set; }
        public string Desc { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
