using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemDeskTemplate
    {
        public int TemplateId { get; set; }
        public string TemplateName { get; set; }
        public string TemplateFileName { get; set; }
        public string TemplateImg { get; set; }
        public string MainLink { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
