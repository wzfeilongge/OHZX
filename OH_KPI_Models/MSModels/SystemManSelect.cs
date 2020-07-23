using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemManSelect
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupText { get; set; }
        public string ConditionFlag { get; set; }
        public string GroupValue { get; set; }
        public string PinYin { get; set; }
        public string Descripe { get; set; }
        public string GroupType { get; set; }
        public string Owner { get; set; }
        public int? Sequence { get; set; }
    }
}
