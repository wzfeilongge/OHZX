using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemMyOpinion
    {
        public int OpinionId { get; set; }
        public string Opinion { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
