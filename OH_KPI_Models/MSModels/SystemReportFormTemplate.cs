using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class SystemReportFormTemplate
    {
        public int TemplateId { get; set; }
        public string TableName { get; set; }
        public string TemplateName { get; set; }
        public string TemplateContent { get; set; }
        public string OnUpdated { get; set; }
        public string Descripe { get; set; }
    }
}
