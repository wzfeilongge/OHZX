using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemDesk
    {
        public int DeskId { get; set; }
        public string DeskName { get; set; }
        public string DeskXml { get; set; }
        public string DeskFileName { get; set; }
        public string DeskUsers { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
