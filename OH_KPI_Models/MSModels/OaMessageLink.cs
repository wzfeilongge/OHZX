using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class OaMessageLink
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public string Deleted { get; set; }
        public int? EndFlag { get; set; }
        public string SystemText { get; set; }
        public string LinkName { get; set; }
        public string LinkUrl { get; set; }
        public string LinkType { get; set; }
        public string InsideFlag { get; set; }
        public string SubWinFlag { get; set; }
    }
}
