using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class SysDbbackup
    {
        public string Id { get; set; }
        public string BackupType { get; set; }
        public string DbName { get; set; }
        public string FileName { get; set; }
        public string FileSize { get; set; }
        public string FilePath { get; set; }
        public DateTime? BackupTime { get; set; }
        public int? SortCode { get; set; }
        public sbyte? EnabledMark { get; set; }
        public string Description { get; set; }
        public sbyte SupportCloud { get; set; }
        public string StorageNamespace { get; set; }
        public DateTime? CreatorTime { get; set; }
        public string CreatorUserId { get; set; }
    }
}
