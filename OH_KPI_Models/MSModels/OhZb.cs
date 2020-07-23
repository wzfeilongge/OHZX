using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class OhZb
    {
        public int Id { get; set; }
        public int? Xh { get; set; }
        public string Zbmc { get; set; }
        public string Express { get; set; }
        public string ExpressC { get; set; }
        public string Formula { get; set; }
        public string FormulaC { get; set; }
        public int? Cid { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int Type { get; set; }
        public int? SpZxType { get; set; }
        public bool? IsEnable { get; set; }
    }
}
