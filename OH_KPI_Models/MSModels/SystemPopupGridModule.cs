using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemPopupGridModule
    {
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string WindowTitle { get; set; }
        public int? WindowWidth { get; set; }
        public int? WindowHeight { get; set; }
        public string TableName { get; set; }
        public string TableQueryId { get; set; }
        public int? GridSize { get; set; }
        public string UpdateMode { get; set; }
        public string TemplateType { get; set; }
        public string TemplateContent { get; set; }
        public string MappTable { get; set; }
        public string MappTextField { get; set; }
        public string MappValueField { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
