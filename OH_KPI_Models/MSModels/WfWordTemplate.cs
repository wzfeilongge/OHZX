using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class WfWordTemplate
    {
        public int WordTemplateId { get; set; }
        public int FlowTemplateId { get; set; }
        public string TemplateName { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public decimal? FileSize { get; set; }
        public byte[] FileBody { get; set; }
        public int? CreaterId { get; set; }
        public DateTime? CreateTime { get; set; }
        public string IsActive { get; set; }
        public string Memo { get; set; }
    }
}
