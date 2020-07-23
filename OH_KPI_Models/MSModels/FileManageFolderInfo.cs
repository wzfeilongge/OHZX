using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class FileManageFolderInfo
    {
        public int FolderId { get; set; }
        public int? ParentFolderId { get; set; }
        public string FolderName { get; set; }
        public string FolderInfo { get; set; }
        public string Creater { get; set; }
        public DateTime? CreateTime { get; set; }
        public string FolderClass { get; set; }
        public string RightRead { get; set; }
        public string RightWrite { get; set; }
        public string RightDelete { get; set; }
        public string RightAll { get; set; }
    }
}
