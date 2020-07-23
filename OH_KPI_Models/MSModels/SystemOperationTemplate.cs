using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemOperationTemplate
    {
        public int TableId { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ShareFlag { get; set; }
        public string Deleted { get; set; }
        public string EndFlag { get; set; }
        public string SystemText { get; set; }
        public string TemplateName { get; set; }
        public string TemplateContent { get; set; }
    }
}
