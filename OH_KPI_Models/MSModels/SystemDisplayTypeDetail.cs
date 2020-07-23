using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemDisplayTypeDetail
    {
        public string DisplayTypeId { get; set; }
        public string ParmName { get; set; }
        public int? OrderNo { get; set; }
        public string DataType { get; set; }
        public int? FieldLength { get; set; }
        public string DisplayType { get; set; }
        public string DisplayTypeData { get; set; }
        public string DisplayHelpMsg { get; set; }
        public string ValidType { get; set; }
        public string EmptyFlag { get; set; }
        public string Descripe { get; set; }
    }
}
