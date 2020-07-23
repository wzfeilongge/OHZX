using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class TGwTopicKey
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public int? EndFlag { get; set; }
        public string Type2 { get; set; }
        public string TopicKey { get; set; }
        public string Type1 { get; set; }
    }
}
