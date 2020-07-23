using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class ShtSuspiciousphotovideo
    {
        public int Id { get; set; }
        public int Module { get; set; }
        public int ItemId { get; set; }
        public int Type { get; set; }
        public string MediaUrl { get; set; }
        public string ImageThumbUrl { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
