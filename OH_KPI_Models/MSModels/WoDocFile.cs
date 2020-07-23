using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class WoDocFile
    {
        public int DocFileId { get; set; }
        public string RecordId { get; set; }
        public string TableName { get; set; }
        public string TableId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public int? FileSize { get; set; }
        public DateTime? FileDate { get; set; }
        public byte[] FileBody { get; set; }
        public string FilePath { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string RemoteIp { get; set; }
        public string Version { get; set; }
        public string Descript { get; set; }
        public string Template { get; set; }
        public string FilePosition { get; set; }
    }
}
