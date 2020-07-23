using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemMenus
    {
        public int MenuId { get; set; }
        public int? ParentId { get; set; }
        public short? Sequence { get; set; }
        public string EnableFlag { get; set; }
        public string MenuName { get; set; }
        public string IconPath { get; set; }
        public string Target { get; set; }
        public string AccessRight { get; set; }
        public string Description { get; set; }
        public string Operation { get; set; }
    }
}
