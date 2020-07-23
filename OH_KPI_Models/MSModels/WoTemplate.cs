using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class WoTemplate
    {
        public int TemplateId { get; set; }
        public string TemplateName { get; set; }
        public string TableName { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public decimal? FileSize { get; set; }
        public DateTime? FileDate { get; set; }
        public byte[] FileBody { get; set; }
        public string FilePath { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Descript { get; set; }
    }
}
