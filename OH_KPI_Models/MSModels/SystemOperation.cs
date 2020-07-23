using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemOperation
    {
        public int OptId { get; set; }
        public string TableName { get; set; }
        public string OptName { get; set; }
        public int? OptIndex { get; set; }
        public string IconPath { get; set; }
        public string ToolTip { get; set; }
        public string Alert { get; set; }
        public string Condition { get; set; }
        public string AccessRight { get; set; }
        public string OptType { get; set; }
        public string OptParm { get; set; }
        public string OptCode { get; set; }
        public string WindowType { get; set; }
        public string WindowParm { get; set; }
        public string DisplayFlag { get; set; }
    }
}
