using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemAd
    {
        public int Adid { get; set; }
        public string Adname { get; set; }
        public string Content { get; set; }
        public string AccessRight { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Url { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
